namespace Ej1
{
    partial class FormInscripcionCompetidor
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNombreInscribirComp = new System.Windows.Forms.TextBox();
            this.btnInscribirCompetidor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(12, 45);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // tbNombreInscribirComp
            // 
            this.tbNombreInscribirComp.Location = new System.Drawing.Point(81, 41);
            this.tbNombreInscribirComp.Name = "tbNombreInscribirComp";
            this.tbNombreInscribirComp.Size = new System.Drawing.Size(147, 20);
            this.tbNombreInscribirComp.TabIndex = 1;
            // 
            // btnInscribirCompetidor
            // 
            this.btnInscribirCompetidor.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInscribirCompetidor.Location = new System.Drawing.Point(81, 82);
            this.btnInscribirCompetidor.Name = "btnInscribirCompetidor";
            this.btnInscribirCompetidor.Size = new System.Drawing.Size(96, 31);
            this.btnInscribirCompetidor.TabIndex = 2;
            this.btnInscribirCompetidor.Text = "Aceptar";
            this.btnInscribirCompetidor.UseVisualStyleBackColor = true;
            this.btnInscribirCompetidor.Click += new System.EventHandler(this.btnInscribirCompetidor_Click);
            // 
            // FormInscripcionCompetidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 125);
            this.Controls.Add(this.btnInscribirCompetidor);
            this.Controls.Add(this.tbNombreInscribirComp);
            this.Controls.Add(this.lbNombre);
            this.Name = "FormInscripcionCompetidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormInscripcionCompetidor";
            this.Load += new System.EventHandler(this.FormInscripcionCompetidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnInscribirCompetidor;
        public System.Windows.Forms.TextBox tbNombreInscribirComp;
    }
}