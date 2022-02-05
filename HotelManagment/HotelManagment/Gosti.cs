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
    public partial class Gosti : Form
    {
        public GraphClient client;
        List<Rezervacija> listaRezervacija = new List<Rezervacija>();
        public Gosti()
        {
            InitializeComponent();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (pregledGostijuListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite gosta!");
                return;
            }
            if (pregledGostijuListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Odaberite samo jednog gosta!");
                return;
            }

            String id = pregledGostijuListView.SelectedItems[0].Text;

            foreach (Rezervacija r in listaRezervacija.ToList())
            {
                if (r.gost.idGosta == id)
                {
                    AzurirajGosta azurirajForma = new AzurirajGosta(r, this);
                    azurirajForma.client = client;
                    if (azurirajForma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.PopuniPodacima();
                    }
                }
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            if (pregledGostijuListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite gosta!");
                return;
            }
            List<int> listaID = new List<int>();
            foreach (ListViewItem item in pregledGostijuListView.SelectedItems)
            {
                int id = Convert.ToInt32(item.Text);
                //obrisi gosta i rezervaciju/e detach
                var query = new Neo4jClient.Cypher.CypherQuery("match(n:Gost)-[r:REZERVACIJA]->(s:Soba) WHERE ID(n)=" + id + " detach delete n", queryDict, CypherResultMode.Projection);
                ((IRawGraphClient)client).ExecuteCypher(query);
                //obrisi gosta/e 
            }
            this.PopuniPodacima();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopuniPodacima()
        {
            pregledGostijuListView.Items.Clear();

            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("match(n:Gost)-[r:REZERVACIJA]->(s:Soba) return n",
                                                            queryDict, CypherResultMode.Set);
            List<Gost> gosti = ((IRawGraphClient)client).ExecuteGetCypherResults<Gost>(query).ToList();
            var query1 = new Neo4jClient.Cypher.CypherQuery("match(n:Gost)-[r:REZERVACIJA]->(s:Soba) return ID(n)",
                                                            queryDict, CypherResultMode.Set);
            List<String> listaID = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query1).ToList();
            var query2 = new Neo4jClient.Cypher.CypherQuery("match(n:Gost)-[r:REZERVACIJA]->(s:Soba) return s",
                                                            queryDict, CypherResultMode.Set);
            List<Soba> sobe = ((IRawGraphClient)client).ExecuteGetCypherResults<Soba>(query2).ToList();
            var query3 = new Neo4jClient.Cypher.CypherQuery("match(n:Gost)-[r:REZERVACIJA]->(s:Soba) return r",
                                                            queryDict, CypherResultMode.Set);
            List<Rezervacija> rezervacije = ((IRawGraphClient)client).ExecuteGetCypherResults<Rezervacija>(query3).ToList();

            for (int i = 0; i < rezervacije.Count; i++)
            {
                gosti[i].idGosta = listaID[i].ToString();
                rezervacije[i].gost = gosti[i];
            }
            listaRezervacija = rezervacije;
            foreach (Rezervacija r in rezervacije)
            {
                ListViewItem item = new ListViewItem(new string[] { r.gost.idGosta, r.gost.ime, r.gost.prezime, r.soba.brojProstorije.ToString(), r.gost.brojTelefona, r.gost.email, r.gost.dokument });

                pregledGostijuListView.Items.Add(item);

            }
            pregledGostijuListView.Refresh();
        }
        private void Gosti_Load(object sender, EventArgs e)
        {
            this.PopuniPodacima();
        }
    }
}
