using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maç_tahmin_Sonuçları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random karsilastir = new Random();

        int gspuan = 0;
        int fbpuan = 0;
        int tspuan = 0;
        int bjkpuan = 0;
        int pndkpuan = 0;
        int svspuan = 0;
        int gztpuan = 0;
        int mltypuan = 0;
        int dnzpuan = 0;
        int knypuan = 0;
        int ksmpuan = 0;
        int antpuan = 0;

        int r, g, b;
        Random renkkaristir = new Random();

        int hafta = 0;

        private void button1Karsilastir_Click(object sender, EventArgs e)
        {

            int a = karsilastir.Next(0, 6);
            int b = karsilastir.Next(0, 6);
            int c = karsilastir.Next(0, 6);
            int d = karsilastir.Next(0, 6);
            int f = karsilastir.Next(0, 6);
            int g = karsilastir.Next(0, 6);
            int u = karsilastir.Next(0, 6);
            int v = karsilastir.Next(0, 6);
            int w = karsilastir.Next(0, 6);
            int x = karsilastir.Next(0, 6);
            int y = karsilastir.Next(0, 6);
            int z = karsilastir.Next(0, 6);

            label2bjk.Text = a.ToString();
            label4gs.Text = b.ToString();
            label8fb.Text = c.ToString();
            label9ts.Text = d.ToString();
            label13pndk.Text = f.ToString();
            label14svs.Text = g.ToString();
            label18gztp.Text = u.ToString();
            label19mlt.Text = v.ToString();
            label23dnz.Text = w.ToString();
            label24kny.Text = x.ToString();
            label28ksm.Text = y.ToString();
            label29ant.Text = z.ToString();
            // label40Kazanan.Text = ".....";



            //2.maç karşılaması
           
            hafta++;
            label4Haftayaz.Text = hafta.ToString() + " .Hafta";

            if (hafta >10)
            {
                hafta = 0;

                gspuan = 0;
                fbpuan = 0;
                tspuan = 0;
                bjkpuan = 0;
                pndkpuan = 0;
                svspuan = 0;
                gztpuan = 0;
                mltypuan = 0;
                dnzpuan = 0;
                knypuan = 0;
                ksmpuan = 0;
                antpuan = 0;

                label4gs.Text = "0";
                label8fb.Text = "0";
                label9ts.Text = "0";
                label2bjk.Text = "0";
                label13pndk.Text = "0";
                label14svs.Text = "0";
                label18gztp.Text = "0";
                label19mlt.Text = "0";
                label23dnz.Text = "0";
                label24kny.Text = "0";
                label28ksm.Text = "0";
                label29ant.Text = "0";

                label4Haftayaz.Text = hafta.ToString() + " Puan Tablosu sıfırlandı .."+Environment.NewLine +" yeniden maç başladı..";

                //MessageBox.Show("Zorlu Bir Karşılaşmanın sonuna gelindi. Puan Tablosunu inceleyin ..!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }

            //1.hafta karşılaşması
            //once cevırıyoruz,neyle ve kimi soruları soruyoruz..

            if (Convert.ToInt32(label2bjk.Text) > Convert.ToInt32(label4gs.Text))
            {

                bjkpuan = bjkpuan + 3; //bjk 3 puan ver
                label58bjkpuan.Text = bjkpuan.ToString();  //3 puan ,nereye ve neyle yazdırıyorsun..
            }
            else if (Convert.ToInt32(label4gs.Text) > Convert.ToInt32(label2bjk.Text))
            {
                gspuan = gspuan + 3;
                label59gspuan.Text = gspuan.ToString();
            }
            else
            {

                bjkpuan = bjkpuan + 1; //hepsine 1ve 1 puan ve
                gspuan = gspuan + 1;

                label58bjkpuan.Text = bjkpuan.ToString(); //ve isimi yazdır,nereye,neyi
                label59gspuan.Text = gspuan.ToString();
            }

            //2.hafta karşılaması
            if (Convert.ToInt32(label8fb.Text) > Convert.ToInt32(label9ts.Text))
            {
                fbpuan = fbpuan + 3;
                label53fbpuan.Text = fbpuan.ToString();
            }
            else if (Convert.ToInt32(label9ts.Text) > Convert.ToInt32(label8fb.Text))
            {
                tspuan = tspuan + 3;
                label54tspuan.Text = tspuan.ToString();
            }
            else
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                label53fbpuan.Text = fbpuan.ToString();
                label54tspuan.Text = tspuan.ToString();
            }

            //3.hafta karşılasması
            if (Convert.ToInt32(label13pndk.Text) > Convert.ToInt32(label14svs.Text))
            {
                pndkpuan = pndkpuan + 3;
                label48pndkpuan.Text = pndkpuan.ToString();
            }
            else if (Convert.ToInt32(label14svs.Text) > Convert.ToInt32(label13pndk.Text))
            {
                svspuan = svspuan + 3;
                label49svspuan.Text = svspuan.ToString();
            }
            else
            {
                pndkpuan = pndkpuan + 1;
                svspuan = svspuan + 1;
                label48pndkpuan.Text = pndkpuan.ToString();
                label49svspuan.Text = svspuan.ToString();
            }

            //4.hafta karşılaşmaıs
            if (Convert.ToInt32(label18gztp.Text) > Convert.ToInt32(label19mlt.Text))
            {
                gztpuan = gztpuan + 3;
                label43gztpuan.Text = gztpuan.ToString();
            }
            else if (Convert.ToInt32(label19mlt.Text) > Convert.ToInt32(label18gztp.Text))
            {
                mltypuan = mltypuan + 3;
                label44mltpuan.Text = mltypuan.ToString();
            }
            else
            {
                gztpuan = gztpuan + 1;
                mltypuan = mltypuan + 1;
                label43gztpuan.Text = gztpuan.ToString();
                label44mltpuan.Text = mltypuan.ToString();
            }

            //5.hafta karşılasması
            if (Convert.ToInt32(label23dnz.Text) > Convert.ToInt32(label24kny.Text))
            {
                dnzpuan = dnzpuan + 3;
                label38dnzpuan.Text = dnzpuan.ToString();
            }
            else if (Convert.ToInt32(label24kny.Text) > Convert.ToInt32(label23dnz.Text))
            {
                knypuan = knypuan + 3;
                label39knypuan.Text = knypuan.ToString();
            }
            else
            {
                dnzpuan = dnzpuan + 1;
                knypuan = knypuan + 1;
                label38dnzpuan.Text = dnzpuan.ToString();
                label39knypuan.Text = knypuan.ToString();
            }

            //6.hafta karşılastırma
            if (Convert.ToInt32(label28ksm.Text) > Convert.ToInt32(label29ant.Text))
            {
                ksmpuan = ksmpuan + 3;
                label33ksmpuan.Text = ksmpuan.ToString();
            }
            else if (Convert.ToInt32(label29ant.Text) > Convert.ToInt32(label28ksm.Text))
            {
                antpuan = antpuan + 3;
                label34antpuan.Text = antpuan.ToString();
            }
            else
            {
                antpuan = antpuan + 1;
                ksmpuan = ksmpuan + 1;
                label34antpuan.Text = antpuan.ToString();
                label33ksmpuan.Text = ksmpuan.ToString();
            }
        }


        private void button2KontrolEt_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(label58bjkpuan.Text) > Convert.ToInt32(label59gspuan.Text) && Convert.ToInt32(label58bjkpuan.Text) > Convert.ToInt32(label53fbpuan.Text) && Convert.ToInt32(label58bjkpuan.Text) > Convert.ToInt32(label54tspuan.Text))
            {
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\dosyalar\\bjk.mp3";
                label40Kazanan.Text = "BeşikTaş";
                pictureBox1.ImageLocation = Application.StartupPath + "\\dosyalar\\bjk.jpg";
            }
            else if (Convert.ToInt32(label59gspuan.Text) > Convert.ToInt32(label58bjkpuan.Text) && Convert.ToInt32(label59gspuan.Text) > Convert.ToInt32(label53fbpuan.Text) && Convert.ToInt32(label59gspuan.Text) > Convert.ToInt32(label54tspuan.Text))
            {
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\dosyalar\\gs.mp3";
                label40Kazanan.Text = "GalataSaray";
                pictureBox1.ImageLocation = Application.StartupPath + "\\dosyalar\\gs.jpg";
            }
            else if (Convert.ToInt32(label53fbpuan.Text) > Convert.ToInt32(label58bjkpuan.Text) && Convert.ToInt32(label53fbpuan.Text) > Convert.ToInt32(label59gspuan.Text) && Convert.ToInt32(label53fbpuan.Text) > Convert.ToInt32(label54tspuan.Text))
            {
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\dosyalar\\fb.mp3";
                label40Kazanan.Text = "FenerBahÇe";
                pictureBox1.ImageLocation = Application.StartupPath + "\\dosyalar\\fb.jpg";
            }
            else if (Convert.ToInt32(label54tspuan.Text) > Convert.ToInt32(label58bjkpuan.Text) && Convert.ToInt32(label54tspuan.Text) > Convert.ToInt32(label59gspuan.Text) && Convert.ToInt32(label54tspuan.Text) > Convert.ToInt32(label53fbpuan.Text))
            {
                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\dosyalar\\ts.mp3";
                label40Kazanan.Text = "TrabZonSpor";
                pictureBox1.ImageLocation = Application.StartupPath + "\\dosyalar\\ts.jpg";
            }
            else
            {
                label40Kazanan.Text = "4 Büyük Takımdan " + Environment.NewLine + " Henüz Kazanan Çıkmadı..";
                // MessageBox.Show("4 Büyük Takımdan Kazanan Yok", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1Sifirla_Click(object sender, EventArgs e)
        {
            hafta = 0;

            gspuan = 0;
            fbpuan = 0;
            tspuan = 0;
            bjkpuan = 0;
            pndkpuan = 0;
            svspuan = 0;
            gztpuan = 0;
            mltypuan = 0;
            dnzpuan = 0;
            knypuan = 0;
            ksmpuan = 0;
            antpuan = 0;

            label4gs.Text = "0";
            label8fb.Text = "0";
            label9ts.Text = "0";
            label2bjk.Text = "0";
            label13pndk.Text = "0";
            label14svs.Text = "0";
            label18gztp.Text = "0";
            label19mlt.Text = "0";
            label23dnz.Text = "0";
            label24kny.Text = "0";
            label28ksm.Text = "0";
            label29ant.Text = "0";


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/n.beyi");

        }


        private void button4Renk_Click(object sender, EventArgs e)
        {
            r = renkkaristir.Next(0, 255);
            g = renkkaristir.Next(0, 255);
            b = renkkaristir.Next(0, 255);

            this.BackColor = Color.FromArgb(r, g, b);

            button1Karsilastir.BackColor = Color.FromArgb(r, g, b);
            button2KontrolEt.BackColor = Color.FromArgb(r, g, b);

            button4Renk.BackColor = Color.FromArgb(r, g, b);

        }

    }
}
