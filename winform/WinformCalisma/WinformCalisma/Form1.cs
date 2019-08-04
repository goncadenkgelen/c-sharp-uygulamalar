using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinformCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem); // sçili olanı silme

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < listBox1.Items.Count; k++)
            {
                listBox2.Items.Add(listBox1.Items[k]);

            }


        }

        private void Button7_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < listBox2.Items.Count; k++)
            {
                listBox1.Items.Add(listBox2.Items[k]);
            }
            listBox2.Items.Clear();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox3.Text) || (string.IsNullOrEmpty(textBox4.Text))))
            {
                if (textBox3.Text == "g" || textBox4.Text == "1")
                {
                    label3.Text = "Giriş Yaptınız";
                    label3.ForeColor = Color.Green;
                    label3.Font = new Font("Arial", 15);
                    label3.Visible = true;
                }

                else
                {
                    label3.Text = "Hatalı Giriş Yaptınız!!!";
                    label3.ForeColor = Color.Red;
                    label3.Font = new Font("Arial", 15);
                    label3.Visible = true;

                }
            }
            else
            {
                MessageBox.Show("Boş Alanları Doldurunuz!");
                label3.Visible = true;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                button9.Enabled = false;

            }

            else
            {
                button9.Enabled = true;
                button9.Text = "Göster";

            }

            textBox4.PasswordChar = '*';


        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!(checkBox1.Checked))
            {
                textBox4.PasswordChar = '*';
                //button9.Text = "Göster";

            }
            else
            {
                textBox4.PasswordChar = '\0';
                
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {

            if (button9.Text == "Gizle")
            {
                textBox4.PasswordChar = '*';
                button9.Text = "Göster";
            }
            else
            {
                textBox4.PasswordChar = '\0';
                button9.Text = "Gizle";
            }

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = true;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button10.Enabled = true;
        }
    }
}
