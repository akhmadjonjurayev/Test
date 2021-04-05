using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Markazi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Informatika");
            comboBox1.Items.Add("Matematika");
            comboBox1.Items.Add("Fizika");
            comboBox1.Items.Add("Ingiliz tili");
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("15");
            comboBox2.Items.Add("20");
            comboBox2.Items.Add("30");
            comboBox2.Items.Add("36");
            comboBox3.Items.Add("maktab darajasi");
            comboBox3.Items.Add("kollej darajasi");
            comboBox3.Items.Add("litsey darajasi");
            comboBox3.Items.Add("unversitet darajasi");
            comboBox4.Items.Add("1");
            comboBox4.Items.Add("2");
            comboBox4.Items.Add("3");
            comboBox4.Items.Add("4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "SirName";
                textBox1.ForeColor = Color.MediumSeaGreen;
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "SirName")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Name";
                textBox2.ForeColor = Color.MediumSeaGreen;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="SirName" && textBox2.Text!="Name" && comboBox1.Text!="" && comboBox2.Text!="" && comboBox3.Text!="" && comboBox4.Text!="")
            {
                if (comboBox1.Text == "Informatika" && comboBox2.Text == "5" && comboBox3.Text == "unversitet darajasi")
                {
                    string[] a = new string[6];
                    a[0] = textBox1.Text; a[1] = textBox2.Text; a[2] = comboBox1.Text;
                    a[3] = comboBox2.Text; a[4] = comboBox3.Text; a[5] = comboBox4.Text;
                    Form3 f = new Form3(a);
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Kechirasiz siz tanlagan yo'nalish bo'yicha testlar bazada mavjud emas !", "Eror !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    comboBox4.Text = "";
                    comboBox3.Text = "";
                    comboBox2.Text = "";
                    comboBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Kiritilgan ma'lumotlar Yetarli emas !", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor= Color.Red;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = SystemColors.ActiveCaption;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            button2.BackColor = SystemColors.ActiveCaption;
        }
    }
}
