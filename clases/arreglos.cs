using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PMRI.clases
{
    internal class arreglos
    {      
        public void ejercicio3()
        {
            int[] desord = new int[10] {80,79,78,77,76,75,74,73,72,71};

            for (int i=0; i<10; i++)
            {
                //Console.WriteLine(desord[i]);

                if (desord[i] == 75) 
                {
                    Console.WriteLine($"La posicion encontrada fue: {desord[i]}");
                }
                else
                    Console.WriteLine("Valor no encontrado");
            }
        }
        public void tabla()
        {
            int[] tabla = new int[10];  

        }
    }
}
