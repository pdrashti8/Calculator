using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr1_Calculator
{
    public partial class Form1 : Form
    {
        double a, b, ans;
        int x;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtAns.Text += "2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtAns.Text += ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtAns.Text += "1";
        }

        private void lblAns_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtAns.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtAns.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtAns.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtAns.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtAns.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtAns.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtAns.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtAns.Text += "0";
        }

        private void btnDot_Click_1(object sender, EventArgs e)
        {
            txtAns.Text += ".";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtAns.Text);
            txtAns.Clear();

            x = 2;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtAns.Text);
            txtAns.Clear();

            x = 3;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtAns.Text);
            txtAns.Clear();

            x = 4;
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(txtAns.Text);
            switch (x)
            {
                case 1:
                    ans = a + b;
                    txtAns.Text = Convert.ToString(ans);
                    break;
                case 2:
                    ans = a - b;
                    txtAns.Text = Convert.ToString(ans);
                    break;
                case 3:
                    ans = a * b;
                    txtAns.Text = Convert.ToString(ans);
                    break;
                case 4:
                    ans = a / b;
                    txtAns.Text = Convert.ToString(ans);
                    break;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtAns.Text);
            txtAns.Clear();
            x = 1;
        }
    }
}
