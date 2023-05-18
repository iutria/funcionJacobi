using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionJacobi
{
    public class Jacobi
    {
        float[,] MD =
        {
            { 8, 2, -3, 13 },
            { 2, 7, -4, 13 },
            { 3, 5, -9, 17 }
        };

        int a = 3;
        int n = 3;

        float[] Semilla = { 0, 0, 0 };

        float[] X;

        public Jacobi()
        {
            X = new float[a];
            int s = 0;
            int iteraciones = 0;
            while (s == 0)
            {
                for (int i = 0; i < a; i++)
                {
                    float suma = 0;
                    for (int j = 0; j < a; j++)
                    {
                        if (i != j)
                        {
                            suma += MD[i, j] * Semilla[j];
                        }
                    }
                    X[i] = (MD[i, a] - suma) / MD[i, i];
                    if (Math.Round(X[0], 4) == 1 && Math.Round(X[1], 4) == 1 && Math.Round(X[2], 4) == -1)
                    {
                        s = 1;
                    }
                    Semilla[i] = X[i];
                }
                iteraciones++;
            }
            foreach(float f in X)
            {
                Console.WriteLine(Math.Round(f, 4));
            }
            
            //Console.WriteLine(Math.Round(X[1], 4));
            //Console.WriteLine(Math.Round(X[2], 4));
            Console.WriteLine(iteraciones);

        }


    }
}
