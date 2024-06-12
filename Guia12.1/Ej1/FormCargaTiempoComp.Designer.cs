namespace Ej1
{
    partial class FormCargaTiempoComp
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
            this.lbNC = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.lbNumeroComp = new System.Windows.Forms.Label();
            this.tbTHoras = new System.Windows.Forms.TextBox();
            this.tbTMinutos = new System.Windows.Forms.TextBox();
            this.lbDosP = new System.Windows.Forms.Label();
            this.btnAgregarTiempo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNC
            // 
            this.lbNC.AutoSize = true;
            this.lbNC.Location = new System.Drawing.Point(26, 28);
            this.lbNC.Name = "lbNC";
            this.lbNC.Size = new System.Drawing.Size(100, 13);
            this.lbNC.TabIndex = 0;
            this.lbNC.Text = "Número Competidor";
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Location = new System.Drawing.Point(29, 70);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(42, 13);
            this.lbTiempo.TabIndex = 1;
            this.lbTiempo.Text = "Tiempo";
            // 
            // lbNumeroComp
            // 
            this.lbNumeroComp.AutoSize = true;
            this.lbNumeroComp.Location = new System.Drawing.Point(178, 28);
            this.lbNumeroComp.Name = "lbNumeroComp";
            this.lbNumeroComp.Size = new System.Drawing.Size(52, 13);
            this.lbNumeroComp.TabIndex = 2;
            this.lbNumeroComp.Text = "lbNumero";
            // 
            // tbTHoras
            // 
            this.tbTHoras.Location = new System.Drawing.Point(118, 67);
            this.tbTHoras.Name = "tbTHoras";
            this.tbTHoras.Size = new System.Drawing.Size(57, 20);
            this.tbTHoras.TabIndex = 3;
            this.tbTHoras.TextChanged += new System.EventHandler(this.tbTHoras_TextChanged);
            // 
            // tbTMinutos
            // 
            this.tbTMinutos.Location = new System.Drawing.Point(197, 67);
            this.tbTMinutos.Name = "tbTMinutos";
            this.tbTMinutos.Size = new System.Drawing.Size(57, 20);
            this.tbTMinutos.TabIndex = 4;
            // 
            // lbDosP
            // 
            this.lbDosP.AutoSize = true;
            this.lbDosP.Location = new System.Drawing.Point(181, 70);
            this.lbDosP.Name = "lbDosP";
            this.lbDosP.Size = new System.Drawing.Size(10, 13);
            this.lbDosP.TabIndex = 5;
            this.lbDosP.Text = ":";
            // 
            // btnAgregarTiempo
            // 
            this.btnAgregarTiempo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarTiempo.Location = new System.Drawing.Point(95, 119);
            this.btnAgregarTiempo.Name = "btnAgregarTiempo";
            this.btnAgregarTiempo.Size = new System.Drawing.Size(95, 29);
            this.btnAgregarTiempo.TabIndex = 6;
            this.btnAgregarTiempo.Text = "Agregar";
            this.btnAgregarTiempo.UseVisualStyleBackColor = true;
            // 
            // FormCargaTiempoComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 159);
            this.Controls.Add(this.btnAgregarTiempo);
            this.Controls.Add(this.lbDosP);
            this.Controls.Add(this.tbTMinutos);
            this.Controls.Add(this.tbTHoras);
            this.Controls.Add(this.lbNumeroComp);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.lbNC);
            this.Name = "FormCargaTiempoComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCargaTiempoComp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNC;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Label lbDosP;
        private System.Windows.Forms.Button btnAgregarTiempo;
        public System.Windows.Forms.TextBox tbTHoras;
        public System.Windows.Forms.TextBox tbTMinutos;
        public System.Windows.Forms.Label lbNumeroComp;
    }
}