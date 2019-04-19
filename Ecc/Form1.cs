using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ecc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, p;
            double xdeger, ydeger;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            p = Convert.ToInt32(textBox3.Text);

            for (int x = 0; x <= p - 1; x++)
            {
                for (int y = 0; y <= p - 1; y++)
                {
                    xdeger = Math.Pow(x, 3) + a * x + b;
                    xdeger = xdeger % p;
                    ydeger = Math.Pow(y, 2);
                    ydeger = ydeger % p;

                    if (ydeger == xdeger)
                    {
                        listBox1.Items.Add("  (" + Convert.ToInt32(x) + "," + Convert.ToInt32(y) + ") \n");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int p, m;
            int P1x, P1y, P2x, P2y;
            double Qx, Qy;

            p = Convert.ToInt32(textBox3.Text);
            P1x = Convert.ToInt32(textBox4.Text);
            P1y = Convert.ToInt32(textBox5.Text);
            P2x = Convert.ToInt32(textBox6.Text);
            P2y = Convert.ToInt32(textBox7.Text);

            m = (P2y - P1y) / (P2x - P1x);
            Qx = Math.Pow(m, 2) - P1x - P2x;
            do{
                Qx = Qx + p;
            } while (Qx < 0);
            Qx = Qx % p;
            Qy = -m * (Qx - P1x) - P1y;
            do{
                Qy = Qy + p;
            } while (Qy < 0);
            Qy = Qy % p;

            textBox8.Text = Convert.ToString(Qx);
            textBox9.Text = Convert.ToString(Qy);

            MessageBox.Show("P1(" + P1x + ", " + P1y + ") + P2(" + P2x + ", " + P2y + ") = Q(" + Qx + ", " + Qy + ")", "İki farklı noktanın toplamı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, p, m;
            double m1, m2;
            int Px, Py;
            double Qx, Qy;

            a = Convert.ToInt32(textBox1.Text);
            p = Convert.ToInt32(textBox3.Text);
            Px = Convert.ToInt32(textBox15.Text);
            Py = Convert.ToInt32(textBox14.Text);

            m1 = ((Math.Pow(Px, 2) * 3) + a);
            m1 = m1 % p;
            m2 = (2 * Py);
            m2 = m2 % p;
            m = Convert.ToInt32(m1 / m2);
            Qx = Math.Pow(m, 2) - Px - Px;
            do
            {
                Qx = Qx + p;
            } while (Qx < 0);
            Qx = Qx % p;
            Qy = -m * (Qx - Px) - Py;
            do
            {
                Qy = Qy + p;
            } while (Qy < 0);
            Qy = Qy % p;

            textBox10.Text = Convert.ToString(Qx);
            textBox11.Text = Convert.ToString(Qy);

            MessageBox.Show("P(" + Px + ", " + Py + ") + P(" + Px + ", " + Py + ") = Q(" + Qx + ", " + Qy + ")", "Bir noktanın kendisi ile toplamı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
