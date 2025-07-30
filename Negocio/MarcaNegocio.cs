using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class MarcaNegocio
    {
        private AccesoDeDatos _context;
        public MarcaNegocio()
        {
            _context = new AccesoDeDatos();
        }
        public ICollection<Marca> GetAllBrands()
        {
            ICollection<Marca> brands = new List<Marca>();
            try
            {
                _context.SetearConsulta("SELECT Id,Descripcion FROM MARCAS");
                _context.EjecutarConsulta();
                while (_context.Lector.Read())
                {
                    Marca brand = new Marca();
                    brand.Id = Convert.ToInt32(_context.Lector["Id"]);
                    brand.Descripcion = (string)_context.Lector["Descripcion"];

                    brands.Add(brand);
                }
                return brands;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _context.CerrarConexion();
            }
        }
    }
}
