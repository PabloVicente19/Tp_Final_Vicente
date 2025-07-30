using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class CategoriaNegocio
    {
        private readonly AccesoDeDatos _context;
        public CategoriaNegocio()
        {
            _context = new AccesoDeDatos();
        }
        public ICollection<Categoria> GetAllCategories()
        {
            ICollection<Categoria> categories = new List<Categoria>();
            try
            {
                _context.SetearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                _context.EjecutarConsulta();
                while (_context.Lector.Read())
                {
                    Categoria category = new Categoria();
                    category.Id = Convert.ToInt32(_context.Lector["Id"]);
                    category.Descripcion = (string)_context.Lector["Descripcion"];
                    categories.Add(category);
                }
                return categories;
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
