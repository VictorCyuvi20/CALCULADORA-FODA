﻿using System;
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
    public partial class CELSIUSEFAHRENHEINT : Form
    {

        public CELSIUSEFAHRENHEINT()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(CONVERTERCELSIUS.Text);
            double resultado = celsius * 1.8 + 32;
            CONVERTERFAHRENHEIT.Text = resultado.ToString();
        }

        private void LIMPADOR_Click(object sender, EventArgs e)
        {
            CONVERTERCELSIUS.Clear();
            CONVERTERFAHRENHEIT.Clear();
        }
    }
}
