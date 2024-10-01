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
            visor.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            visor.Clear();
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

        private void button16_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "6";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(visor.Text);
            operacao = "divisão";
            visor.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(visor.Text);
            operacao = "multiplicação";
            visor.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(visor.Text);
            operacao = "subtração";
            visor.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(visor.Text);
            operacao = "adição";
            visor.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.operacao == "adição")
            {
                float resultado = valor1 + Convert.ToSingle(visor.Text);
                visor.Text = resultado.ToString();
            }
            if (this.operacao == "subtração")
            {
                float resultado = valor1 - Convert.ToSingle(visor.Text);
                visor.Text = resultado.ToString();
            }
            if (this.operacao == "multiplicação")
            {
                float resultado = valor1 * Convert.ToSingle(visor.Text);
                visor.Text = resultado.ToString();
            }
            if (this.operacao == "divisão")
            {
                float resultado = valor1 / Convert.ToSingle(visor.Text);
                visor.Text = resultado.ToString();
            }
            if (this.operacao == "")
            {
                visor.Text = "ERRO";
            }
        }

        private void cONVERSORFAHRENHEITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CELSIUSEFAHRENHEINT conversor = new CELSIUSEFAHRENHEINT();
            conversor.Show();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
