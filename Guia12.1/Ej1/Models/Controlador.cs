using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    public class Controlador
    {

        public string[] Nombres;
        public int[] Tiempo;
        public int Cont=0;

        public void AgregarCompetidor(string competidor) 
        {
            Nombres[Cont++] = competidor;
        }

        public void CargarTiempo(int i,int horas, int minutos) 
        {
            Tiempo[i] = horas*60 + minutos;
        }

        public void OrdenarListadoPorTiempo() 
        {

        }

    }
}
