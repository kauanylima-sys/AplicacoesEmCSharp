namespace HelloWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            calcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 18.25F, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(249, 28);
            label2.Name = "label2";
            label2.Size = new Size(197, 30);
            label2.TabIndex = 1;
            label2.Text = "SISTEMA IMC";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18.25F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(126, 156);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 2;
            label1.Text = "ALTURA: ";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 18.25F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(126, 101);
            label3.Name = "label3";
            label3.Size = new Size(95, 30);
            label3.TabIndex = 3;
            label3.Text = "PESO:";
            label3.Click += label3_Click;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Georgia", 15.75F);
            txtPeso.Location = new Point(249, 100);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(302, 31);
            txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Georgia", 15.75F);
            txtAltura.Location = new Point(283, 155);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(268, 31);
            txtAltura.TabIndex = 5;
            // 
            // calcular
            // 
            calcular.BackColor = Color.Teal;
            calcular.Font = new Font("Georgia", 14F, FontStyle.Bold);
            calcular.ForeColor = SystemColors.ButtonHighlight;
            calcular.Location = new Point(271, 221);
            calcular.Name = "calcular";
            calcular.Size = new Size(140, 35);
            calcular.TabIndex = 6;
            calcular.Text = "CALCULAR";
            calcular.UseVisualStyleBackColor = false;
            calcular.Click += calcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Georgia", 18.25F, FontStyle.Bold);
            lblResultado.ForeColor = Color.Teal;
            lblResultado.Location = new Point(126, 291);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(192, 30);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "RESULTADO:";
            lblResultado.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(704, 375);
            Controls.Add(lblResultado);
            Controls.Add(calcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button calcular;
        private Label lblResultado;
    }
}
