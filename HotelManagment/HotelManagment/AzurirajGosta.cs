using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient.Cypher;
using Neo4jClient;

namespace HotelManagment
{
    public partial class AzurirajGosta : Form
    {
        public Rezervacija rezervacijaZaProsledjivanje;
        public GraphClient client;
        public Gosti roditeljskaForma;
        public AzurirajGosta()
        {
            InitializeComponent();
        }
        public AzurirajGosta(Rezervacija r, Gosti g)
        {
            InitializeComponent();
            rezervacijaZaProsledjivanje = r;
            roditeljskaForma = g;

        }

        private void AzurirajGosta_Load(object sender, EventArgs e)
        {
            textBox1.Text = rezervacijaZaProsledjivanje.gost.ime;
            textBox2.Text = rezervacijaZaProsledjivanje.gost.prezime;
            textBox3.Text = rezervacijaZaProsledjivanje.gost.email;
            textBox4.Text = rezervacijaZaProsledjivanje.gost.brojTelefona;
            textBox5.Text = rezervacijaZaProsledjivanje.gost.dokument;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            Int32 idGostaZaProsledjivanje = Convert.ToInt32(rezervacijaZaProsledjivanje.gost.idGosta);
            var query1 = new Neo4jClient.Cypher.CypherQuery("match(s:Soba) return s", queryDict, CypherResultMode.Set);
            List<Soba> sobe = ((IRawGraphClient)client).ExecuteGetCypherResults<Soba>(query1).ToList();
            foreach (Soba s in sobe)
            {
                comboBox1.Items.Add(s.brojProstorije);
                if (s.brojProstorije == rezervacijaZaProsledjivanje.soba.brojProstorije)
                {
                    comboBox1.SelectedText = rezervacijaZaProsledjivanje.soba.brojProstorije;
                    comboBox1.SelectedItem = rezervacijaZaProsledjivanje.soba.brojProstorije;
                }
            }
            dateTimePicker1.Value = rezervacijaZaProsledjivanje.datumDo;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            rezervacijaZaProsledjivanje.gost.ime = textBox1.Text;
            rezervacijaZaProsledjivanje.gost.prezime = textBox2.Text;
            rezervacijaZaProsledjivanje.gost.email = textBox3.Text;
            rezervacijaZaProsledjivanje.gost.brojTelefona = textBox4.Text;
            rezervacijaZaProsledjivanje.gost.dokument = textBox5.Text;
            rezervacijaZaProsledjivanje.soba.brojProstorije = comboBox1.SelectedItem.ToString();
            rezervacijaZaProsledjivanje.datumDo = dateTimePicker1.Value.Date;

            Int32 idGostaZaProsledjivanje = Convert.ToInt32(rezervacijaZaProsledjivanje.gost.idGosta);

            String brojSobeGostaZaProsledjivanje = rezervacijaZaProsledjivanje.soba.brojProstorije.ToString();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            queryDict.Add("ime", rezervacijaZaProsledjivanje.gost.ime);
            queryDict.Add("prezime", rezervacijaZaProsledjivanje.gost.prezime);
            queryDict.Add("email", rezervacijaZaProsledjivanje.gost.email);
            queryDict.Add("brojTelefona", rezervacijaZaProsledjivanje.gost.brojTelefona);
            queryDict.Add("dokument", rezervacijaZaProsledjivanje.gost.dokument);

            var query = new Neo4jClient.Cypher.CypherQuery("match(n:Gost)-[r:REZERVACIJA]->(s:Soba) WHERE ID(n)=" + idGostaZaProsledjivanje + ""
                + " set n.ime='" + rezervacijaZaProsledjivanje.gost.ime + "', n.prezime='" + rezervacijaZaProsledjivanje.gost.prezime + "', "
                + "  n.email='" + rezervacijaZaProsledjivanje.gost.email + "',  n.brojTelefona='" + rezervacijaZaProsledjivanje.gost.brojTelefona + "', "
                + "  n.dokument='" + rezervacijaZaProsledjivanje.gost.dokument + "' return n", queryDict, CypherResultMode.Set);

            List<Gost> gost = ((IRawGraphClient)client).ExecuteGetCypherResults<Gost>(query).ToList();

            var query1 = new Neo4jClient.Cypher.CypherQuery("match(n:Gost)-[r:REZERVACIJA]->(s:Soba) WHERE ID(n)=" + idGostaZaProsledjivanje + " return s", queryDict, CypherResultMode.Set);

            List<Soba> soba = ((IRawGraphClient)client).ExecuteGetCypherResults<Soba>(query1).ToList();

            var query2 = new Neo4jClient.Cypher.CypherQuery("match(n:Gost)-[r:REZERVACIJA]->(s:Soba) WHERE ID(n)=" + idGostaZaProsledjivanje + " delete r", queryDict, CypherResultMode.Set);


            ((IRawGraphClient)client).ExecuteCypher(query2);

            //kreiranje rezervacije
            var query3 = new Neo4jClient.Cypher.CypherQuery("match(g:Gost) WHERE ID(g)=" + idGostaZaProsledjivanje + ""
                 + " match(s:Soba) WHERE exists(s.brojProstorije) and s.brojProstorije='" + rezervacijaZaProsledjivanje.soba.brojProstorije + "' "
                 + " create (g)-[r:REZERVACIJA {ukupnaCena:'" + rezervacijaZaProsledjivanje.ukupnaCena + "', datumOd:'" + rezervacijaZaProsledjivanje.datumOd.ToString() + "', "
                 + " datumDo:'" + rezervacijaZaProsledjivanje.datumDo.ToString() + "'}]->(s) return r", queryDict, CypherResultMode.Set);

            List<Rezervacija> rezervacije = ((IRawGraphClient)client).ExecuteGetCypherResults<Rezervacija>(query3).ToList();

            foreach (Rezervacija r in rezervacije)
            {
                r.gost = rezervacijaZaProsledjivanje.gost;
                r.soba = rezervacijaZaProsledjivanje.soba;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
