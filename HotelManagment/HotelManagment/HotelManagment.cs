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
    public partial class HotelManagment : Form
    {
        private GraphClient client;
        public HotelManagment()
        {
            InitializeComponent();
        }

        private void HotelManagment_Load(object sender, EventArgs e)
        {

            //MATCH (n) OPTIONAL MATCH (n)-[r]-() DELETE n,r // za brisanje svih cvoreva

            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "edukacija");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSobe_Click(object sender, EventArgs e)
        {
            Sobe pregledSobe = new Sobe();
            pregledSobe.client = client;
            pregledSobe.ShowDialog();
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            Rezervacije rezervacija = new Rezervacije();
            rezervacija.client = client;
            rezervacija.ShowDialog();
        }

        private void btnGosti_Click(object sender, EventArgs e)
        {
            Gosti gosti = new Gosti();
            gosti.client = client;
            gosti.ShowDialog();
        }
    }
}
