using BLL;
using ENTITY;
namespace GUI
{
    public partial class Form1 : Form
    {
        private bool semillaCargada;
        private bool matrizDDCargada;
        private JacobiService service;
        public Form1()
        {
            semillaCargada = false;
            matrizDDCargada = false;
            service = new JacobiService();
            InitializeComponent();

            dgvResultado.Columns.Add("X", "X");
            dgvResultado.Columns.Add("Valor", "Valor");
        }

        private void seleccionarMatrizDominanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = CargarArchivo();
            if(ruta != "")
            {
                bool r = service.CargarMatrizDD(ruta);
                if (r)
                {
                    MessageBox.Show("Se cargo correctamente");
                    matrizDDCargada = true;
                    if (matrizDDCargada && semillaCargada)
                    {
                        lblFuncion.Text = "Funcion:\n" + service.Datos().Funcion();
                    }
                }
                else
                {
                    matrizDDCargada = false;
                    MessageBox.Show("Ocurrio un error al cargar el archivo");
                }
            }
        }

        private string CargarArchivo()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,


                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;
                return ruta;
            }
            else
            {
                return "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoIteracion.Text == "Por Numero de iteraciones")
            {
                cmbTipoError.Enabled = false;
            }
            else
            {
                cmbTipoError.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (matrizDDCargada && semillaCargada)
            {
                if(service.Datos().N != service.Datos().Semilla.Length)
                {
                    MessageBox.Show("hay un error en los datos cargados, puede que haya mas semillas que constantes");
                }
                else
                {
                    int n = int.Parse(txtEntrada.Text);
                    int c = int.Parse(txtCifras.Text);
                    if (cmbTipoIteracion.Text == "Por Numero de iteraciones")
                    {
                        CargarTablaIteraciones(n, c);
                    }
                    else
                    {
                        CargarTablaError(n, c);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aun no cargas los archivos");
            }
        }

        private void CargarTablaIteraciones(int n, int c)
        {
            dgvResultado.Rows.Clear();
            lblSemilla.Text = service.Datos().SemillaString();
            double[] nuevaSemilla = new double[service.Datos().N];
            for (int i = 0; i < service.Datos().Semilla.Length; i++)
            {
                nuevaSemilla[i] = service.Datos().Semilla[i];
            }
            DatosEntrada d = new DatosEntrada(service.Datos().MatrizDD, service.Datos().N,nuevaSemilla);
            float[] X = d.ObtenerResultadoIteraciones(n,c);
            for (int i = 0; i < X.Length; i++)
            {
                dgvResultado.Rows.Add("X"+i, Math.Round(X[i], 1));
            }   
        }
        private void CargarTablaError(int n, int c)
        {
            dgvResultado.Rows.Clear();
            lblSemilla.Text = service.Datos().SemillaString();
            double[] nuevaSemilla = new double[service.Datos().N];
            for (int i = 0; i < service.Datos().Semilla.Length; i++)
            {
                nuevaSemilla[i] = service.Datos().Semilla[i];
            }
            DatosEntrada d = new DatosEntrada(service.Datos().MatrizDD, service.Datos().N, nuevaSemilla);
            float[] X = d.ObtenerResultadoError("",n, c);
            lblIteraciones.Text = d.Iteraciones.ToString();
            for (int i = 0; i < X.Length; i++)
            {
                dgvResultado.Rows.Add("X" + i, Math.Round(X[i], 1));
            }
        }

        private void seleccionarValoresSemillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = CargarArchivo();
            if (ruta != "")
            {
                bool r = service.CargarSemilla(ruta);
                if (r)
                {
                    MessageBox.Show("Se cargo correctamente");
                    semillaCargada = true;
                    lblSemilla.Text = "Semillas Cargadas: " + service.Datos().SemillaString();
                    if (matrizDDCargada && semillaCargada)
                    {
                        lblFuncion.Text = "Funcion:\n"+service.Datos().Funcion();
                    }
                }
                else
                {
                    semillaCargada = false;
                    MessageBox.Show("Ocurrio un error al cargar el archivo");                    
                }
            }
        }
    }
}