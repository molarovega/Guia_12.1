namespace Ej1
{
    partial class FormVerResultados
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
            this.gbxResultados = new System.Windows.Forms.GroupBox();
            this.lbxResultados = new System.Windows.Forms.ListBox();
            this.btnCerrarResultados = new System.Windows.Forms.Button();
            this.gbxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxResultados
            // 
            this.gbxResultados.Controls.Add(this.lbxResultados);
            this.gbxResultados.Location = new System.Drawing.Point(18, 18);
            this.gbxResultados.Name = "gbxResultados";
            this.gbxResultados.Size = new System.Drawing.Size(385, 177);
            this.gbxResultados.TabIndex = 0;
            this.gbxResultados.TabStop = false;
            this.gbxResultados.Text = "Resultados";
            // 
            // lbxResultados
            // 
            this.lbxResultados.FormattingEnabled = true;
            this.lbxResultados.Location = new System.Drawing.Point(16, 31);
            this.lbxResultados.Name = "lbxResultados";
            this.lbxResultados.Size = new System.Drawing.Size(355, 134);
            this.lbxResultados.TabIndex = 0;
            // 
            // btnCerrarResultados
            // 
            this.btnCerrarResultados.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCerrarResultados.Location = new System.Drawing.Point(165, 201);
            this.btnCerrarResultados.Name = "btnCerrarResultados";
            this.btnCerrarResultados.Size = new System.Drawing.Size(90, 32);
            this.btnCerrarResultados.TabIndex = 1;
            this.btnCerrarResultados.Text = "Cerrar";
            this.btnCerrarResultados.UseVisualStyleBackColor = true;
            this.btnCerrarResultados.Click += new System.EventHandler(this.btnCerrarResultados_Click);
            // 
            // FormVerResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 239);
            this.Controls.Add(this.btnCerrarResultados);
            this.Controls.Add(this.gbxResultados);
            this.Name = "FormVerResultados";
            this.Text = "FormVerResultados";
            this.Load += new System.EventHandler(this.FormVerResultados_Load);
            this.gbxResultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxResultados;
        private System.Windows.Forms.Button btnCerrarResultados;
        public System.Windows.Forms.ListBox lbxResultados;
    }
}