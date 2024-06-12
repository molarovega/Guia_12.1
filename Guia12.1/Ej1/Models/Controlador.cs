using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    public class Controlador
    {

        public string[] Nombres = new string[1000];
        public int[] Tiempo = new int[1000];
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
            int tie;
            string nom;

            for (int act=0; act<Cont-1; act++) 
            {
                for (int sig=act+1; sig<Cont;sig++) 
                {
                    if (Tiempo[act] > Tiempo[sig]) 
                    {
                        nom = Nombres[act];
                        Nombres[act] = Nombres[sig];
                        Nombres[sig] = nom;

                        tie = Tiempo[act];
                        Tiempo[act] = Tiempo[sig];
                        Tiempo[sig] = tie;
                    }
                }
            }
        }

    }
}
