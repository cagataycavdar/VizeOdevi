using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace VizeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string rss = ("http://koeri.boun.edu.tr/rss/");
            XmlDocument deprem = new XmlDocument();
            deprem.Load(rss);

            var nodes = deprem.SelectNodes("rss/channel/item");

            foreach (XmlNode node in nodes)
            {
                string title = node["title"].InnerText;
                string date = node["pubDate"].InnerText;

                listBox1.Items.Add(title + "  ---  " + date);
            }

        }
    }
}
