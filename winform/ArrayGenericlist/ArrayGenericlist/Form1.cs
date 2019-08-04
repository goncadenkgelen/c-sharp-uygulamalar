using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayGenericlist
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;

            listBox1.SelectionMode = SelectionMode.MultiSimple;
            textBox1.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int k = 0;
            int i = 0, j = 0;
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            string[] seciliIsimler = new string[listBox1.SelectedItems.Count];
            string[] seciliOlmayanIsimler = new string[listBox1.Items.Count];

            while (k <= listBox1.Items.Count - 1)
            {
                if (listBox1.SelectedItems.Contains(listBox1.Items[k]))
                {
                    seciliIsimler[i] = listBox1.Items[k].ToString();
                    listBox2.Items.Add(seciliIsimler[i]);
                    i++;
                }
                else
                {
                    seciliOlmayanIsimler[j] = listBox1.Items[k].ToString();
                    listBox3.Items.Add(seciliOlmayanIsimler[j]);
                    j++;
                }
                k++;
            }

            label3.Visible = true;
            label4.Visible = true;

            label3.Text = listBox2.Items.Count.ToString();
            label4.Text = listBox3.Items.Count.ToString();

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                if (listBox1.SelectedItems.Contains(listBox1.Items[i]))
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[i]);
                }
            }

            label3.Visible = true;
            label4.Visible = true;

            label3.Text = listBox2.Items.Count.ToString();
            label4.Text = listBox3.Items.Count.ToString();
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
