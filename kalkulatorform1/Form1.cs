using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorform1
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((Hasil.Text == "0")||(operation_pressed))
                Hasil.Clear();

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
            operation_pressed = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Hasil.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(Hasil.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            operation_pressed = false;
            switch(operation)
            {
                case "+":
                    Hasil.Text = (value + double.Parse(Hasil.Text)).ToString();
                    break;

                case "-":
                    Hasil.Text = (value - double.Parse(Hasil.Text)).ToString();
                    break;

                case "*":
                    Hasil.Text = (value * double.Parse(Hasil.Text)).ToString();
                    break;

                case "/":
                    Hasil.Text = (value / double.Parse(Hasil.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Hasil.Clear();
            value = 0;
        }

        private void equation_Click(object sender, EventArgs e)
        {

        }

        private void Hasil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
