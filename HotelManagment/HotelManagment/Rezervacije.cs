using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace HotelManagment
{
    public partial class Rezervacije : Form
    {
        public GraphClient client;
        public List<Gost> gosti; //dodala sam da ne bih dva puta pisala isti upit
        String prostorija = "";
        public Rezervacije()
        {
            InitializeComponent();
            cmbProstorija.Text = "Izaberite prostoriju";
            cmbProstorija.Items.Insert(0, "Soba");
            gosti = new List<Gost>();
        }

        private Soba vratiSobu(String brojSobe)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("brojProstorije", brojSobe);
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Soba) and exists(n.brojProstorije) and n.brojProstorije =~ {brojProstorije} return n",
                                                           queryDict, CypherResultMode.Set);

            List<Soba> prostor = ((IRawGraphClient)client).ExecuteGetCypherResults<Soba>(query).ToList();

            if (prostor.Count != 0)
            {

                return prostor[0];
            }
            else
            {
                return null;
            }
        }
        private void btnDodajGoste_Click(object sender, EventArgs e)
        {

            DodajGosta gost = new DodajGosta();
            gost.client = client;
            gost.ShowDialog();
            Gost g = gost.vratiGosta();
            if (g == null)
                return;
            else
            {
                gosti.Add(g);
                ListViewItem lvi = new ListViewItem(g.ime);
                lvi.SubItems.Add(g.prezime);
                lvi.SubItems.Add(g.dokument);

                lvGosti.Items.Add(lvi);
            }
        }

        private void btnZapamtiRezervaciju_Click(object sender, EventArgs e)
        {
            if (dgvProstorije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati prostoriju.");
                return;
            }

            foreach (Gost g in gosti)
            {
                Rezervacija r = new Rezervacija();
                r.datumDo = dtpDatumDo.Value;
                r.datumOd = dtpDatumOd.Value;
                r.ukupnaCena = lblCena.Text;
                String brojSobe = dgvProstorije.SelectedRows[0].Cells[0].Value.ToString();
                r.soba = vratiSobu(brojSobe);

                var query1 = new Neo4jClient.Cypher.CypherQuery("match (a:Gost),(b:Soba:" + prostorija + " ) WHERE a.dokument = '" + g.dokument + "'  AND  b.brojProstorije = '" + brojSobe + "' CREATE (a)-[r:REZERVACIJA{datumOd: date({day:" + r.datumOd.Day
                    + ", month: " + r.datumOd.Month + ", year: " + r.datumOd.Year + " }), datumDo: date({day:" + r.datumDo.Day
                    + ", month: " + r.datumDo.Month + ", year: " + r.datumDo.Year + " }), ukupnaCena: '" + r.ukupnaCena + "' }]->(b) return r",
                                                          new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query1);

            }
            this.Close();
        }

        private void btnIzracunajCenu_Click(object sender, EventArgs e)
        {
            if (dgvProstorije.SelectedRows.Count != 1)
            {
                MessageBox.Show("Mozete izabrati samo jednu prostoriju");
                return;
            }
            DataGridViewRow row = dgvProstorije.SelectedRows[0];
            float cena = float.Parse(row.Cells[2].Value.ToString());
            int brojdana = new TimeSpan(dtpDatumDo.Value.Date.Ticks - dtpDatumOd.Value.Date.Ticks).Days;
            lblCena.Text = ((brojdana + 1) * cena).ToString();
        }

        private void dgvProstorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajRezervaciju_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                            this.DisplayRectangle);
        }

        private void cmbProstorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProstorije.Rows.Clear();
            String filter = cmbProstorija.SelectedIndex.ToString();
            if (filter == "-1")
            {
                MessageBox.Show("Izaberite filter");
                return;
            }
            switch (filter)
            {
                case "0":
                    {
                        prostorija = "Soba";
                        DateTime datumOd = dtpDatumOd.Value.Date;
                        DateTime datumDo = dtpDatumDo.Value.Date;
                        Dictionary<string, object> queryDict = new Dictionary<string, object>();
                        queryDict.Add("datumOd", dtpDatumOd.Value);
                        queryDict.Add("datumDo", dtpDatumDo.Value);

                        var query = new Neo4jClient.Cypher.CypherQuery("MATCH(n) -[r: REZERVACIJA]->(a:Soba) where r.datumOd >= date({ day:  " + datumOd.Day + ", month: " + datumOd.Month + ", year: " + datumOd.Year + "})  and r.datumOd <=  date({ day:  " + datumDo.Day + ", month: " + datumDo.Month + ", year: " + datumDo.Year + "}) or (r.datumDo >=  date({ day: " + datumOd.Day + ", month: " + datumOd.Month + ", year: " + datumOd.Year + "})  and r.datumDo <=  date({ day:  " + datumDo.Day + ", month: " + datumDo.Month + ", year: " + datumDo.Year + "}) ) return a",
                                                                        queryDict, CypherResultMode.Set);

                        List<Soba> sobe = ((IRawGraphClient)client).ExecuteGetCypherResults<Soba>(query).ToList();

                        var query1 = new Neo4jClient.Cypher.CypherQuery("match(n:Soba)return n",
                                                                      new Dictionary<string, object>(), CypherResultMode.Set);
                        List<Soba> sveSobe = ((IRawGraphClient)client).ExecuteGetCypherResults<Soba>(query1).ToList();


                        foreach (Soba a in sobe)
                        {
                            // MessageBox.Show(a.brojProstorije);
                            if (sveSobe.Exists(x => x.brojProstorije == a.brojProstorije))
                            {
                                var s = sveSobe.Where(x => x.brojProstorije == a.brojProstorije).ToList();
                                sveSobe.Remove(s.First());
                            }
                        }

                        dgvProstorije.ColumnCount = 7;
                        dgvProstorije.Columns[0].Name = "Broj sobe";
                        dgvProstorije.Columns[1].Name = "Broj kreveta";
                        dgvProstorije.Columns[2].Name = "Cena nocenja";
                        dgvProstorije.Columns[3].Name = "Klima";
                        dgvProstorije.Columns[4].Name = "TV";
                        dgvProstorije.Columns[5].Name = "Terasa";
                        dgvProstorije.Columns[6].Name = "Opis";


                        foreach (Soba a in sveSobe)
                        {

                            string[] row = new string[] { a.brojProstorije.ToString(), a.brojKreveta.ToString(),
                            a.cena.ToString(), a.klima, a.tv, a.terasa, a.opis};
                            dgvProstorije.Rows.Add(row);
                        }
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
