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
    public partial class DodajSobu : Form
    {
        public GraphClient client;
        public DodajSobu()
        {
            InitializeComponent();
        }
        private Soba kreirajSobu()
        {
            Soba s = new Soba();

            s.brojProstorije = txtBrojSobe.Text.ToString();
            s.brojKreveta = txtKrevet.Text.ToString();
            s.sprat = txtSprat.Text.ToString();
            s.klima = txtKlima.Text.ToString();
            s.tv = txtTv.Text.ToString();
            s.terasa = txtTerasa.Text.ToString();
            s.opis = txtOpis.Text.ToString();
            s.cena = Int32.Parse(txtCena.Text);

            return s;
        }
        private String maxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Soba soba = this.kreirajSobu();
            string id = maxId();

            try
            {
                int mId = Int32.Parse(id);
                soba.idProstorije = (mId++).ToString();

            }
            catch (Exception exception)
            {
                soba.idProstorije = "";
            }


            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            queryDict.Add("brojProstorije", soba.brojProstorije);
            queryDict.Add("brojKreveta", soba.brojKreveta);
            queryDict.Add("sprat", soba.sprat);
            queryDict.Add("klima", soba.klima);
            queryDict.Add("tv", soba.tv);
            queryDict.Add("terasa", soba.terasa);
            queryDict.Add("opis", soba.opis);
            queryDict.Add("cena", soba.cena);
            queryDict.Add("idProstorije", soba.idProstorije);

            var query1 = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Soba {brojProstorije:'" + soba.brojProstorije + "',brojKreveta:'"
                                                            + soba.brojKreveta + "',sprat:'" + soba.sprat
                                                            + "', klima:'" + soba.klima + "', tv:'" + soba.tv + "', terasa:'" + soba.terasa + "', cena:'" + soba.cena.ToString()
                                                            + "', opis:'" + soba.opis
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);
            List<Soba> sobe = ((IRawGraphClient)client).ExecuteGetCypherResults<Soba>(query1).ToList();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
