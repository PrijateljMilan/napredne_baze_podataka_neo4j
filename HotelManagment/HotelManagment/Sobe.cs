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
    public partial class Sobe : Form
    {
        public GraphClient client;
        public Sobe()
        {
            InitializeComponent();
        }

        private void Sobe_Load(object sender, EventArgs e)
        {
            this.ucitajSobe();
        }
        public void ucitajSobe()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match(n:Soba)return n",new Dictionary<string, object>(), CypherResultMode.Set);
            List<Soba> sobe = ((IRawGraphClient)client).ExecuteGetCypherResults<Soba>(query).ToList();
            dgvSobe.Rows.Clear();
            foreach (Soba s in sobe)
            {
                dgvSobe.Rows.Add(new string[] { s.brojProstorije, s.sprat, s.brojKreveta, s.cena.ToString(), s.klima, s.tv, s.terasa });
            }
            dgvSobe.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajSobu dodajSobu = new DodajSobu();
            dodajSobu.client = client;
            if (dodajSobu.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                    ucitajSobe();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(dgvSobe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite sobu koju zelite da izbrisete.");
                return;
            }
            string brojProstorije = dgvSobe.CurrentRow.Cells[0].Value.ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("brojProstorije", brojProstorije);
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Soba) and exists(n.brojProstorije) and n.brojProstorije =~ {brojProstorije} detach delete n",
                                                              queryDict, CypherResultMode.Projection);

            List<Soba> sobe = ((IRawGraphClient)client).ExecuteGetCypherResults<Soba>(query).ToList();
            ucitajSobe();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
