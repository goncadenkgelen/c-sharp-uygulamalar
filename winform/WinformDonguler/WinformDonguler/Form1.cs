using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDonguler
{
    

    public partial class Form1 : Form
    {
        static int[] sayilarDizi = new int[] { 5, 10, 25, 30 };
        static List<int> sayilarListe = new List<int>(sayilarDizi);
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Sayılar = {5, 10, 25, 30}";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for(int i = 0; i < sayilarListe.Count; i++)
            {
                listBox1.Items.Add(sayilarListe[i]);
                toplam += sayilarListe[i];
            }
            listBox1.Items.Add("Toplamı: " +toplam);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayac = 0;

            while(sayilarDizi.Length > sayac)
            {
                listBox2.Items.Add(sayilarDizi[sayac]);
                toplam += sayilarDizi[sayac];
                sayac++;
            }
            listBox2.Items.Add("Toplamı: " +toplam);

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int toplam = 0;
            do
            {
                listBox3.Items.Add(sayilarDizi[sayac]);
                toplam += sayilarDizi[sayac];
                sayac++;
            }

            while (sayilarDizi.Length > sayac);
            listBox3.Items.Add("Toplamı: " + toplam);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (var item in sayilarListe)
            {
                listBox4.Items.Add(item);
                toplam += item;

            }
            listBox4.Items.Add("Toplamı: " + toplam);

        }
    }
}
