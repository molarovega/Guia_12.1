using Ej1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ej1
{
    public partial class Form1 : Form
    {

        Controlador contro = new Controlador();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarCompetidor_Click(object sender, EventArgs e)
        {
            FormInscripcionCompetidor Inscribir = new FormInscripcionCompetidor();
            if (Inscribir.ShowDialog() == DialogResult.OK)
            {
                contro.AgregarCompetidor(Inscribir.tbNombreInscribirComp.Text);
            }

        }

        private void btnAgregarTiempoComp_Click(object sender, EventArgs e)
        {
            FormCargaTiempoComp CTiempo = new FormCargaTiempoComp();

            for (int i=0; i<contro.Cont;i++) 
            {
                CTiempo.ShowDialog();
                contro.CargarTiempo(i, Convert.ToInt32(CTiempo.tbTHoras.Text), Convert.ToInt32(CTiempo.tbTMinutos.Text));


            }

            

        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {

        }
    }
}
