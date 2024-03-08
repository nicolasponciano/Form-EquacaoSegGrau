namespace TP_03_PROJETO_03
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
            btnCalcular = new Button();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtX2 = new TextBox();
            txtX1 = new TextBox();
            txtDelta = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(584, 82);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(98, 54);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(107, 98);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(267, 98);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 2;
            // 
            // txtC
            // 
            txtC.Location = new Point(408, 98);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(221, 100);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 4;
            label1.Text = "X² +";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(373, 100);
            label2.Name = "label2";
            label2.Size = new Size(34, 21);
            label2.TabIndex = 5;
            label2.Text = "X +";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(514, 98);
            label3.Name = "label3";
            label3.Size = new Size(34, 21);
            label3.TabIndex = 6;
            label3.Text = "= 0";
            // 
            // txtX2
            // 
            txtX2.Location = new Point(206, 281);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(100, 23);
            txtX2.TabIndex = 7;
            // 
            // txtX1
            // 
            txtX1.Location = new Point(206, 242);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(100, 23);
            txtX1.TabIndex = 8;
            // 
            // txtDelta
            // 
            txtDelta.Location = new Point(206, 203);
            txtDelta.Name = "txtDelta";
            txtDelta.Size = new Size(100, 23);
            txtDelta.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(321, 203);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 10;
            label4.Text = "Delta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(327, 244);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 11;
            label5.Text = "X1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(327, 283);
            label6.Name = "label6";
            label6.Size = new Size(28, 21);
            label6.TabIndex = 12;
            label6.Text = "X2";
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(491, 217);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(101, 71);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDelta);
            Controls.Add(txtX1);
            Controls.Add(txtX2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtX2;
        private TextBox txtX1;
        private TextBox txtDelta;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnLimpar;
    }
}