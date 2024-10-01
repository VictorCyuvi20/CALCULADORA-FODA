namespace CALCULADORA_FODA
{
    partial class CELSIUSEFAHRENHEINT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CONVERTERCELSIUS = new TextBox();
            button1 = new Button();
            label1 = new Label();
            CONVERTERFAHRENHEIT = new TextBox();
            label2 = new Label();
            LIMPADOR = new Button();
            SuspendLayout();
            // 
            // CONVERTERCELSIUS
            // 
            CONVERTERCELSIUS.Location = new Point(12, 35);
            CONVERTERCELSIUS.Multiline = true;
            CONVERTERCELSIUS.Name = "CONVERTERCELSIUS";
            CONVERTERCELSIUS.Size = new Size(372, 77);
            CONVERTERCELSIUS.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(409, 35);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(173, 77);
            button1.TabIndex = 1;
            button1.Text = "CALCULAR ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 2;
            label1.Text = "TEMPERATURA EM CELSIUS";
            // 
            // CONVERTERFAHRENHEIT
            // 
            CONVERTERFAHRENHEIT.Location = new Point(105, 217);
            CONVERTERFAHRENHEIT.Multiline = true;
            CONVERTERFAHRENHEIT.Name = "CONVERTERFAHRENHEIT";
            CONVERTERFAHRENHEIT.Size = new Size(372, 77);
            CONVERTERFAHRENHEIT.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(204, 191);
            label2.Name = "label2";
            label2.Size = new Size(180, 23);
            label2.TabIndex = 4;
            label2.Text = "TEMPERATURA EM FAHRENHEIT";
            // 
            // LIMPADOR
            // 
            LIMPADOR.Location = new Point(507, 311);
            LIMPADOR.Name = "LIMPADOR";
            LIMPADOR.Size = new Size(75, 23);
            LIMPADOR.TabIndex = 5;
            LIMPADOR.Text = "LIMPAR";
            LIMPADOR.UseVisualStyleBackColor = true;
            LIMPADOR.Click += LIMPADOR_Click;
            // 
            // CELSIUSEFAHRENHEINT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 346);
            Controls.Add(LIMPADOR);
            Controls.Add(label2);
            Controls.Add(CONVERTERFAHRENHEIT);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(CONVERTERCELSIUS);
            Name = "CELSIUSEFAHRENHEINT";
            Text = "CELSIUSEFAHRENHEINT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CONVERTERCELSIUS;
        private Button button1;
        private Label label1;
        private TextBox CONVERTERFAHRENHEIT;
        private Label label2;
        private Button LIMPADOR;
    }
}