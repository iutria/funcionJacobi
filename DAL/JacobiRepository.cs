using ENTITY;
namespace DAL
{
    public class JacobiRepository
    {
        public DatosEntrada CargarMatrizDD(string ruta)
        {
            List<string> Lineas = obtenerLieasArchivo(ruta);
            if (Lineas == null)
            {
                throw new Exception();
            }
            int n = ContarConstantes(Lineas[0]);
            if (n == 0)
            {
                throw new Exception();
            }
            else if (n != Lineas.Count - 1)
            {
                throw new Exception();
            }
            float[,] matrizDD = ObtenerMatrizDD(Lineas,n);
            DatosEntrada entrada = new DatosEntrada(matrizDD,n);
            return entrada;
        }
        public double[] CargarSemillas(string ruta)
        {
            List<string> Lineas = obtenerLieasArchivo(ruta);
            if (Lineas == null)
            {
                throw new Exception();
            }
            string[] linea = Lineas[0].Split(';');
            double[] semilla = new double[linea.Length];
            for (int i = 0; i < linea.Length; i++)
            {
                semilla[i] = double.Parse(linea[i]);
            }
            return semilla;
        }

        private float[,] ObtenerMatrizDD(List<string> lineas,int n)
        {
            float[,] matrizDD = new float[n,n+1];
            for(int i = 1; i < lineas.Count; i++)
            {
                string[] line = lineas[i].Split(';');
                for(int j = 0; j < line.Length; j++)
                {
                    matrizDD[i-1,j] = float.Parse(line[j]);
                }
            }
            return matrizDD;
        }
        private int ContarConstantes(string cabecera)
        {
            int a = 0;
            string[] entradas = cabecera.Split(';');
            foreach (string s in entradas)
            {
                if (s == "a")
                {
                    a++;
                }
            }
            return a;
        }
        private List<string> obtenerLieasArchivo(string ruta)
        {
            List<string> lineas = new List<string>();
            
            StreamReader lector;
            try
            {
                lector = new StreamReader(ruta);
                string linea = string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    lineas.Add(linea);
                }
                lector.Close();
            }
            catch (Exception e)
            {
                return null;
            }
            return lineas;
        }
    }
}