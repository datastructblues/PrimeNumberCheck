using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                if (IsPrime(number))
                {
                    label1.Text = "Asal sayidir";
                }
                else
                {
                    label1.Text = "Asal sayi degildir";
                }
            }
        }
        private bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            for (int counter = 2; counter <= number - 1; counter++)
            {
                if (number % counter == 0)
                {
                    return false;    
                }
            }
            return true;

        }

    }
}
    
    

