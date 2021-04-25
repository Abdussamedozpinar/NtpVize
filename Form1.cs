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
using System.IO;



namespace ödev
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sitelink = "https://www.cnnturk.com/feed/rss/all/news";
        private int sayac;



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {











            XmlDocument doc1 = new XmlDocument();
            doc1.Load(sitelink);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("channel/item");


            foreach (XmlNode node in nodes)
            {



                string baslik = node["title"].InnerText;
                string haber = node["description"].InnerText;


            }
        }
    }
}
