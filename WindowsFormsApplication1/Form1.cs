using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ans;
            double num1Parse;
            double num2Parse;
            bool success1 = double.TryParse(num1txt.Text, out num1Parse);
            if (success1)
            {
                
            }
            else
            {
                Console.WriteLine("Incorrect values entered");
            }
            bool success2 = double.TryParse(num2txt.Text, out num2Parse);
            if (success2)
            {

            }
            else
            {
                Console.WriteLine("You fucking idiot");
            }
            ans = num1Parse + num2Parse + num1Parse;
            ansTxt.Text = ans.ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            double ans;
            ans = (double.Parse(num1txt.Text)) - (double.Parse(num2txt.Text));
            ansTxt.Text = ans.ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            double ans;
            ans = (double.Parse(num1txt.Text)) * (double.Parse(num2txt.Text));
            ansTxt.Text = ans.ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            double ans;
            ans = (double.Parse(num1txt.Text)) / (double.Parse(num2txt.Text));
            ansTxt.Text = ans.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num2txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
