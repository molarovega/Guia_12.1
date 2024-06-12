namespace Ej1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarCompetidor = new System.Windows.Forms.Button();
            this.btnAgregarTiempoComp = new System.Windows.Forms.Button();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCompetidor
            // 
            this.btnAgregarCompetidor.Location = new System.Drawing.Point(52, 29);
            this.btnAgregarCompetidor.Name = "btnAgregarCompetidor";
            this.btnAgregarCompetidor.Size = new System.Drawing.Size(208, 53);
            this.btnAgregarCompetidor.TabIndex = 0;
            this.btnAgregarCompetidor.Text = "Agregar Competidor";
            this.btnAgregarCompetidor.UseVisualStyleBackColor = true;
            this.btnAgregarCompetidor.Click += new System.EventHandler(this.btnAgregarCompetidor_Click);
            // 
            // btnAgregarTiempoComp
            // 
            this.btnAgregarTiempoComp.Location = new System.Drawing.Point(53, 106);
            this.btnAgregarTiempoComp.Name = "btnAgregarTiempoComp";
            this.btnAgregarTiempoComp.Size = new System.Drawing.Size(207, 54);
            this.btnAgregarTiempoComp.TabIndex = 1;
            this.btnAgregarTiempoComp.Text = "Agregar Tiempos de Competidores";
            this.btnAgregarTiempoComp.UseVisualStyleBackColor = true;
            this.btnAgregarTiempoComp.Click += new System.EventHandler(this.btnAgregarTiempoComp_Click);
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(53, 190);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(206, 51);
            this.btnVerResultados.TabIndex = 2;
            this.btnVerResultados.Text = "Ver Resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 266);
            this.Controls.Add(this.btnVerResultados);
            this.Controls.Add(this.btnAgregarTiempoComp);
            this.Controls.Add(this.btnAgregarCompetidor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCompetidor;
        private System.Windows.Forms.Button btnAgregarTiempoComp;
        private System.Windows.Forms.Button btnVerResultados;
    }
}

