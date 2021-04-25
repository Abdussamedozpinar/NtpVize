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



            sayac++;
            timer1.Start();
            timer1.Interval = 1000;
            label1.Text = sayac.ToString();
            if (sayac == 3595)
            {

                TextWriter tw = new StreamWriter(@"C:\deneme\deneme.txt");
                tw.Write("");
                tw.Close();


            }
            if (sayac == 3600)
            {
                sayac = 0;
                MessageBox.Show("1 saat doldu tekrar analiz yapıyorum.", "Uyar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Keşke kodlarını hatırlaya bilseydim veya bulabilseydim çok yakındı 










                XmlDocument doc1 = new XmlDocument();
            doc1.Load(sitelink);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("channel/item");


            foreach (XmlNode node in nodes)
            {



                string baslik = node["title"].InnerText;
                string haber = node["description"].InnerText;


                string fileName = @"C:\deneme\deneme.txt";
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                File.AppendAllText(fileName, Environment.NewLine + "Haber Başlığı::" + baslik + Environment.NewLine + "Haber içeriği::" + haber + Environment.NewLine);


            }
        }
    }
}
