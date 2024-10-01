namespace CALCULADORA_FODA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == 8)
            {
                timer1.Enabled = false;
                CALCULADORA cALCULADORA = new CALCULADORA();
                cALCULADORA.Show();
            }
                
        }
    }
}
