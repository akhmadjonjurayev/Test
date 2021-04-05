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
    public partial class Form4 : Form
    {
        char [,]a=new char[5,2];
        string []l = new string[6];
        int togri_javob = 0;
        public Form4(char [,]b, string []k)
        {
            InitializeComponent();
            this.a = b;
            this.l = k;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Highlight;
            button2.ForeColor = Color.Black;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label5.Text = chiqarish(a[0, 0], a[0, 1], 1);
            label6.Text = chiqarish(a[1, 0], a[1, 1], 2);
            label7.Text = chiqarish(a[2, 0], a[2, 1], 3);
            label8.Text = chiqarish(a[3, 0], a[3, 1], 4);
            label9.Text = chiqarish(a[4, 0], a[4, 1], 5);
            if (l[4][0] == 'm') label10.Text = "O'quvchi ";
            else if (l[4][0] == 'l' || l[4][0] == 'k') label10.Text = "Abuturient ";
            else label10.Text = "Talaba ";
            label10.Text += l[0] + " " + l[1];
            for (int i = 0; i < Convert.ToInt16(l[3]); i++)
                if (a[i,0] == 'T') togri_javob++;
            label11.Text = "Test natijalaridan " + Convert.ToString(togri_javob * 20) + "% ko'rsatkichga ega bo'ldi";//5 ta savolga bo'g'liq
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        string chiqarish(char w,char c, int i)
        {
            if (w == 'N') return Convert.ToString(i) + " - test to'ldirilmagan";
            else if (w == 'T') return Convert.ToString(i) + " - test javobi to'g'ri";
            else return Convert.ToString(i) + " - javob noto'g'ri " + Convert.ToString(c) + " javob to'g'ri";
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush b = new SolidBrush(Color.Blue);
            g.FillPie(b, 275, 250, 100, 100, 0, togri_javob * 360 / 5);
            Brush b_2 = new SolidBrush(Color.Black);
            g.FillPie(b_2, 275, 250, 100, 100, togri_javob * 360 / 5, 360 - togri_javob * 360 / 5);
            Brush b_3 = new SolidBrush(Color.White);
            g.FillEllipse(b_3, 300, 275, 50, 50);
        }
    }
}
