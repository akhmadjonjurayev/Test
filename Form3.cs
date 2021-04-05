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
    public partial class Form3 : Form
    {
        string[,] a = new string[5, 7];
        string []b = new string[6];
        int sikl = 5, i = 0;
        char[,] q = new char[5,2];
        bool j = false;
        int min = 0, sek = 0;
        bool t = false;
        public Form3(string []l)
        {
            InitializeComponent();
            this.b = l;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            a[0, 0] = "Quyidagilardan qaysi biri kampyuter tarmoq";
            a[0, 1] = "255.192.0.0";
            a[0, 2] = "255.254.128.0";
            a[0, 3] = "255.255.224.0";
            a[0, 4] = "255.248.0.0";
            a[0, 5] = "B";
            a[0, 6] = "maskasi bo'la olmaydi";
            a[1, 0] = "350241 + 12465 = 363036 tenglikni qanoatlantiruvchi";
            a[1, 1] = "5";
            a[1, 2] = "8";
            a[1, 3] = "9";
            a[1, 4] = "7";
            a[1, 5] = "D";
            a[1, 6] = "sanoq sistemani toping";
            a[2, 0] = "Quyidagi qaysi dasturlash tili Unix operatsion";
            a[2, 1] = "Java";
            a[2, 2] = "C++";
            a[2, 3] = "C#";
            a[2, 4] = "Pyton";
            a[2, 5] = "A";
            a[2, 6] = "sistemasida ishlaydi";
            a[3,0]="Hozirgi kunda qaysi operator Formada";
            a[3, 1] = "for";
            a[3, 2] = "while";
            a[3, 3] = "goto";
            a[3, 4] = "do-while";
            a[3, 5] = "C";
            a[3, 6] = "eng kam qo'llaniladi";
            a[4, 0] = "Qaysi dasturlash tilida polimormizm va";
            a[4, 1] = "C";
            a[4, 2] = "Java";
            a[4, 3] = "C++";
            a[4, 4] = "C#";
            a[4, 5] = "A";
            a[4, 6] = "vorislik mavjud emas";
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            label5.Hide();
            label6.Hide();
            button4.Hide();
            q[0, 0] = 'N';
            q[1, 0] = 'N';
            q[2, 0] = 'N';
            q[3, 0] = 'N';
            q[4, 0] = 'N';
            timer1.Interval = 1000;
            min = Convert.ToInt16(b[3]) * Convert.ToInt16(b[5]);
            //sek = 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                button3.Text = "Next";
                radioButton4.Show();
                radioButton3.Show();
                radioButton2.Show();
                radioButton1.Show();
                label6.Show();
                label5.Show();
                label5.Text = a[i, 0];
                label6.Text = a[i, 6];
                radioButton1.Text = "A) " + a[i, 1];
                radioButton2.Text = "B) " + a[i, 2];
                radioButton3.Text = "C) " + a[i, 3];
                radioButton4.Text = "D) " + a[i, 4];
                i++;
                timer1.Start();
            }
            else
            {
                if (radioButton1.Checked) { q[i - 1,1] = 'A'; radioButton1.Checked = false;
                if (a[i - 1, 5] == "A")
                    q[i - 1, 0] = 'T';
                else
                {
                    q[i - 1, 0] = 'F';
                    q[i - 1, 1] = Convert.ToChar(a[i - 1, 5]);
                }
                    j = true; }
                else if (radioButton2.Checked) {radioButton2.Checked = false;
                if (a[i - 1, 5] == "B")
                    q[i - 1, 0] = 'T';
                else
                {
                    q[i - 1, 0] = 'F';
                    q[i - 1, 1] = Convert.ToChar(a[i - 1, 5]);
                }
                    j = true; }
                else if (radioButton3.Checked) {radioButton3.Checked = false;
                if (a[i - 1, 5] == "C")
                    q[i - 1, 0] = 'T';
                else
                {
                    q[i - 1, 0] = 'F';
                    q[i - 1, 1] = Convert.ToChar(a[i - 1, 5]);
                }
                    j = true; }
                else if (radioButton4.Checked) {radioButton4.Checked = false;
                if (a[i - 1, 5] == "D")
                    q[i - 1, 0] = 'T';
                else
                {
                    q[i - 1, 0] = 'F';
                    q[i - 1, 1] = Convert.ToChar(a[i - 1, 5]);
                }
                    j = true; }
                else { MessageBox.Show("Testni tanglang", "Eror !", MessageBoxButtons.OK, MessageBoxIcon.Stop); j = false; }
                if (i < sikl && j)
                {
                    label5.Text = a[i, 0];
                    label6.Text = a[i, 6];
                    radioButton1.Text = "A) " + a[i, 1];
                    radioButton2.Text = "B) " + a[i, 2];
                    radioButton3.Text = "C) " + a[i, 3];
                    radioButton4.Text = "D) " + a[i, 4];
                    i++;
                }
                else if (i == sikl)
                {
                    button4.Show();
                    button3.Hide();
                    radioButton1.Hide();
                    radioButton2.Hide();
                    radioButton3.Hide();
                    radioButton4.Hide();
                    label5.Hide();
                    label6.Hide();
                    timer1.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(q, b);
            this.Hide();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sek==0)
            {
                if(min==0)
                {
                    button4.Show();
                    button3.Hide();
                    radioButton1.Hide();
                    radioButton2.Hide();
                    radioButton3.Hide();
                    radioButton4.Hide();
                    label5.Hide();
                    label6.Hide();
                    timer1.Stop();
                }
                else
                {
                    min--;
                    sek = 59;
                    label9.Text = Convert.ToString(sek);
                    label7.Text = Convert.ToString(min);
                }
            }
            else
            {
                sek--;
                label9.Text = Convert.ToString(sek);
            }
            if (t)
            {
                label8.Hide();
                t = false;
            }
            else
            {
                label8.Show();
                t = true;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.DarkSeaGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.DarkSeaGreen;
        }
    }
}
