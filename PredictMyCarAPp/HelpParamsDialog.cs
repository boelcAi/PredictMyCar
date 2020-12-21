using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PredictMyCarAPp
{
    public partial class HelpParamsDialog : Form
    {
        public HelpParamsDialog()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            CallWebsite("https://www.destatis.de/DE/Themen/Gesellschaft-Umwelt/Bevoelkerung/Bevoelkerungsstand/_inhalt.html");
        }



        private static void CallWebsite(string linkUrl)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "cmd",
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = $"/c start {linkUrl}"
            };
            Process.Start(psi);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            CallWebsite("https://www.destatis.de/DE/Themen/Arbeit/Arbeitsmarkt/Erwerbstaetigkeit/_inhalt.html");
        
        }


        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel3.LinkVisited = true;
            CallWebsite("https://www.destatis.de/DE/Themen/Arbeit/Arbeitsmarkt/Erwerbslosigkeit/_inhalt.html");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel4.LinkVisited = true;
            CallWebsite("https://www.destatis.de/DE/Themen/Arbeit/Arbeitsmarkt/Erwerbstaetigkeit/Tabellen/pendler1.html?nn=206552");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel5.LinkVisited = true;
            CallWebsite(
                "https://www.destatis.de/DE/Themen/Arbeit/Arbeitsmarkt/Erwerbstaetigkeit/Arbeitsmarktstrukturen-Covid19.html#fussnote-2-409718");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel6.LinkVisited = true;
            CallWebsite("https://www.destatis.de/DE/Themen/Arbeit/Arbeitsmarkt/Qualitaet-Arbeit/Dimension-2/_Interaktiv/2-4-krankenstand.html");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel7.LinkVisited = true;
            CallWebsite("https://www.destatis.de/DE/Service/Statistik-Campus/Datenreport/Downloads/datenreport-2018-kap-5.pdf?__blob=publicationFile");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel8.LinkVisited = true;
            CallWebsite("http://appsso.eurostat.ec.europa.eu/nui/show.do?dataset=lfsa_ewpshi&lang=de");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel9.LinkVisited = true;
            CallWebsite("https://www.destatis.de/DE/Themen/Branchen-Unternehmen/Transport-Verkehr/Unternehmen-Infrastruktur-Fahrzeugbestand/Tabellen/fahrzeugbestand.html");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnableSimulation_Click(object sender, EventArgs e)
        {
            EnableSimulation = true;
            MessageBox.Show("Simulation Forecasting enabled");
        }

        public bool EnableSimulation { get; set; }
    }
}
