using ENTITY;
using DAL;
namespace BLL
{
    public class JacobiService
    {
        private DatosEntrada datos;
        private JacobiRepository repository;
        public JacobiService()
        {
            datos = new DatosEntrada();
            repository = new JacobiRepository();
        }

        public DatosEntrada Datos()
        {
            return datos;
        }

        public bool CargarMatrizDD(string ruta)
        {
            try
            {
                DatosEntrada d = repository.CargarMatrizDD(ruta);
                datos.MatrizDD = d.MatrizDD;
                datos.N = d.N;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool CargarSemilla(string ruta)
        {
            try
            {
                double[] semilla = repository.CargarSemillas(ruta);
                datos.Semilla = semilla;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}