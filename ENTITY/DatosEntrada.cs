namespace ENTITY
{
    public class DatosEntrada
    {
        public float[,] MatrizDD { get; set; }
        public int  N { get; set; }
        public double[] Semilla { get; set; }

        public int Iteraciones { get; set; }
        public DatosEntrada() { }
        public DatosEntrada(float[,] matrizDD, int n)
        {
            MatrizDD = matrizDD;
            N = n;
        }
        public DatosEntrada(float[,] matrizDD, int n,double[] semilla)
        {
            MatrizDD = matrizDD;
            N = n;
            Semilla = semilla;
        }

        public float[] ObtenerResultadoError(string tipo,float error, int CifrasSignificativas)
        {
            float[] X = new float[N];
            int s = 0;
            Iteraciones = 0;
            while (s == 0)
            {
                for (int i = 0; i < N; i++)
                {
                    float suma = 0;
                    for (int j = 0; j < N; j++)
                    {
                        if (i != j)
                        {
                            suma += MatrizDD[i, j] * float.Parse(Semilla[j].ToString());
                        }
                    }
                    X[i] = (MatrizDD[i, N] - suma) / MatrizDD[i, i];
                    if (Math.Round(X[i], CifrasSignificativas) == error)
                    {
                        s = 1;
                    }
                    Semilla[i] = Math.Round(X[i], CifrasSignificativas);
                }
                Iteraciones++;
            }
            return X;
        }
        public float[] ObtenerResultadoIteraciones(int iteraciones,int CifrasSignificativas)
        {
            float[] X = new float[N];
            Iteraciones = 0;
            while (Iteraciones < iteraciones)
            {
                for (int i = 0; i < N; i++)
                {
                    float suma = 0;
                    for (int j = 0; j < N; j++)
                    {
                        if (i != j)
                        {
                            suma += MatrizDD[i, j] * float.Parse(Semilla[j].ToString());
                        }
                    }
                    X[i] = (MatrizDD[i, N] - suma) / MatrizDD[i, i];
                    Semilla[i] = Math.Round(X[i], CifrasSignificativas);
                }
                Iteraciones++;
            }
            return X;
        }

        public string Funcion()
        {
            string f = "";
            for (int i = 0; i < N; i++)
            {
                string suma = "";
                for (int j = 0; j < N; j++)
                {
                    if (i != j)
                    {
                        suma = suma + "("+MatrizDD[i, j] + " * " + Semilla[j] + ") + ";
                    }
                }
                f = f + "X"+i+" = (" + MatrizDD[i, N] + " - ( " + suma.Substring(0, suma.Length - 2) + ") /" +  MatrizDD[i, i] + "\n";
            }
            return f;
        }
        public string SemillaString()
        {
            string s = "";
            for (int i = 0; i < Semilla.Length; i++)
            {
                s = s + "X" + (i + 1) + " = " + Semilla[i] + " ; ";
            }
            return s;
        }

    }
}