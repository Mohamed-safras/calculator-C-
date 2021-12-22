using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNumber(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            
            Button button = (Button)sender;

            textBox1.Text += button.Text;
        }
    }
}
