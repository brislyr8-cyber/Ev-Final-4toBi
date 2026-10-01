namespace Ev_Final_4toBi
{
    partial class Form2
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
            this.textVar1 = new System.Windows.Forms.TextBox();
            this.textVar2 = new System.Windows.Forms.TextBox();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnPotencia = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textVar1
            // 
            this.textVar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textVar1.Location = new System.Drawing.Point(0, 28);
            this.textVar1.Name = "textVar1";
            this.textVar1.Size = new System.Drawing.Size(100, 22);
            this.textVar1.TabIndex = 0;
            // 
            // textVar2
            // 
            this.textVar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textVar2.Location = new System.Drawing.Point(0, 137);
            this.textVar2.Name = "textVar2";
            this.textVar2.Size = new System.Drawing.Size(100, 22);
            this.textVar2.TabIndex = 1;
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.Fuchsia;
            this.BtnProducto.Location = new System.Drawing.Point(111, 220);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnProducto.TabIndex = 2;
            this.BtnProducto.Text = "producto";
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.Color.Green;
            this.BtnSuma.Location = new System.Drawing.Point(259, 220);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 23);
            this.BtnSuma.TabIndex = 3;
            this.BtnSuma.Text = "suma";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnPotencia
            // 
            this.BtnPotencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnPotencia.Location = new System.Drawing.Point(419, 220);
            this.BtnPotencia.Name = "BtnPotencia";
            this.BtnPotencia.Size = new System.Drawing.Size(75, 23);
            this.BtnPotencia.TabIndex = 4;
            this.BtnPotencia.Text = "potencia";
            this.BtnPotencia.UseVisualStyleBackColor = false;
            this.BtnPotencia.Click += new System.EventHandler(this.BtnPotencia_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnDivision.Location = new System.Drawing.Point(588, 220);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(75, 23);
            this.BtnDivision.TabIndex = 5;
            this.BtnDivision.Text = "division";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnPotencia);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.textVar2);
            this.Controls.Add(this.textVar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textVar1;
        private System.Windows.Forms.TextBox textVar2;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnPotencia;
        private System.Windows.Forms.Button BtnDivision;
    }
}