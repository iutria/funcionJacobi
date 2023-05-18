using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionJacobi
{
    public class Principal
    {
        int cifras = 4;
        public Principal()
        {
            float x10 = 0;
            float x20 = 0;
            float x30 = 0;
            string seguir = "s";
            double i = 0;
            while(i<11)
            {
                float x1 = (13 - ((2 * x20) + (-3 * x30))) / 8;
                float x2 = (13 - ((2 * x10) + (-4 * x30))) / 7;
                float x3 = (17 - ((3 * x10) + (5 * x20))) / (-9);
                if (Math.Round(x1, 4) == 1 && Math.Round(x2, cifras) == 1 && Math.Round(x3, 4) == -1)
                {
                    seguir = "n";
                }
                Console.WriteLine("Error: " + ((x1 - x10) / x1));
                Console.WriteLine("Error: " + ((x10 - x1) / x10));
                x10 = x1;
                x20 = x2;
                x30 = x3;
                i++;

                

                Console.WriteLine("iteracion: " + i);
                Console.WriteLine("esto es x1: " + Math.Round(x1, cifras));
                Console.WriteLine("esto es x2: " + Math.Round(x2, cifras));
                Console.WriteLine("esto es x3: " + Math.Round(x3, cifras));
            }
        }
    }
}
