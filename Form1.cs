using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static char op = '.';
        static string val1 = "", val2 = "";
        static bool operar = false;

        private void button7_Click(object sender, EventArgs e)
        {
            if (operar)
                pantalla.Text = "";

            pantalla.Text += "0";
            operar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double raiz = Math.Sqrt(Convert.ToDouble(pantalla.Text));
            pantalla.Text = raiz.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pantalla.Text = "";
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (operar)
                pantalla.Text = "";

            pantalla.Text += "1";
            operar = false;
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (operar)
                pantalla.Text = "";

            pantalla.Text += "2";
            operar = false;
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (operar)
                pantalla.Text = "";

            pantalla.Text += "3";
            operar = false;
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (operar)
                pantalla.Text = "";

            pantalla.Text += "4";
            operar = false;
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (operar)
                pantalla.Text = "";

            pantalla.Text += "5";
            operar = false;
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (operar)
                pantalla.Text = "";

            pantalla.Text += "6";
            operar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operar)
                pantalla.Text = "";

            pantalla.Text += "7";
            operar = false;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (operar)
                pantalla.Text = "";

            pantalla.Text += "8";
            operar = false;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (operar)
                pantalla.Text = "";

            pantalla.Text += "9";
            operar = false;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            val1 = pantalla.Text;
            op = '+';
            operar = true;
            
        }

        private void less_Click(object sender, EventArgs e)
        {
            val1 = pantalla.Text;
            op = '-';
            operar = true;
        }

        private void product_Click(object sender, EventArgs e)
        {
            val1 = pantalla.Text;
            op = 'x';
            operar = true;
        }

        private void div_Click(object sender, EventArgs e)
        {
            val1 = pantalla.Text;
            op = '/';
            operar = true;
        }

        private void sign_Click(object sender, EventArgs e)
        {
            int inv = Convert.ToInt32(pantalla.Text) * -1;
            pantalla.Text = inv.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            pantalla.Text = "";
            op = '.';
            val1 = "";
            val2 = "";
            operar = false;
        }

        private void percent_Click(object sender, EventArgs e)
        {
            decimal porcent = Convert.ToDecimal(pantalla.Text)/100;
            pantalla.Text = porcent.ToString();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Decimal result = 0;
            switch (op)
            {
                case '+':
                    result = (Convert.ToDecimal(val1)) + (Convert.ToDecimal(pantalla.Text));
                    pantalla.Text = result.ToString();
                    break;
                case '-':
                    result = (Convert.ToDecimal(val1)) - (Convert.ToDecimal(pantalla.Text));
                    pantalla.Text = result.ToString();
                    break;
                case 'x':
                    result = (Convert.ToDecimal(val1)) * (Convert.ToDecimal(pantalla.Text));
                    pantalla.Text = result.ToString();
                    break;
                case '/':
                    result = (Convert.ToDecimal(val1)) / (Convert.ToDecimal(pantalla.Text));
                    pantalla.Text = result.ToString();
                    break;
            }

            op = '.';
            val1 = "";
            operar = true;
        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
