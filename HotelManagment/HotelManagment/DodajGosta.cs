﻿using System;
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
    public partial class DodajGosta : Form
    {
        public GraphClient client;
        Gost gost;
        public DodajGosta()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            gost = this.createGost();
            string maxId = getMaxId();

            try
            {
                int mId = Int32.Parse(maxId);
                gost.idGosta = (mId++).ToString();
            }
            catch (Exception exception)
            {
                gost.idGosta = "";
            }

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ime", gost.ime);
            queryDict.Add("prezime", gost.prezime);
            queryDict.Add("dokument", gost.dokument);
            queryDict.Add("email", gost.email);


            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Gost {ime:'" + gost.ime
                                                            + "', prezime:'" + gost.prezime + "', dokument:'" + gost.dokument
                                                            + "', email:'" + gost.email + "',brojTelefona:'" + gost.brojTelefona
                                                            + "' }) return n",
                                                            queryDict, CypherResultMode.Set);

            List<Gost> gosti = ((IRawGraphClient)client).ExecuteGetCypherResults<Gost>(query).ToList();

            this.Close();

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Gost createGost()
        {
            Gost a = new Gost();

            a.ime = txtIme.Text;
            a.prezime = txtPrezime.Text;
            a.email = txtEmail.Text;
            a.dokument = txtDokument.Text;
            a.brojTelefona = txtBrojTelefona.Text;

            return a;
        }
        public Gost vratiGosta()
        {
            return gost;
        }

        private String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where exists(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }
    }
}
