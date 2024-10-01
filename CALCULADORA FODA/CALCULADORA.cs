using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_FODA
{
    public partial class CALCULADORA : Form
    {


        float valor1 = 0;
        string operacao = "";

        public CALCULADORA()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            visor.Text = visor.Text + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "4";
        }
    }
}
