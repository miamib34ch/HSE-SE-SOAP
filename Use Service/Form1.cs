using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Use_Service.ServiceReference1;

namespace Use_Service
{
    public partial class Form1 : Form
    {
        Service1Client a = new Service1Client();
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double w))
            {
                if (textBox1.Text == "" || textBox1.Text == " ")
                {
                    textBox1.Text = "0";
                    label2.Text = $"Из фаренгейт в цельсии: {a.FahrenheitToCelsius(double.Parse(textBox1.Text))}";
                }
                else
                {
                    label2.Text = $"Из фаренгейт в цельсии: {a.FahrenheitToCelsius(double.Parse(textBox1.Text))}";
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не число!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double w))
            {
                if (textBox1.Text == "" || textBox1.Text == " ")
                {
                    textBox1.Text = "0";
                    label2.Text = $"Из цельсий в фаренгейты: {a.CelsiusToFahrenheit(double.Parse(textBox1.Text))}";
                }
                else
                {
                    label2.Text = $"Из цельсий в фаренгейты: {a.CelsiusToFahrenheit(double.Parse(textBox1.Text))}";
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не число!");
            }
        }
    }
}
