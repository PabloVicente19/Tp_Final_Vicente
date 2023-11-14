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
        private AccesoDeDatos datos;
        public List<Categoria> Listar()
        {
            datos = new AccesoDeDatos();
            List<Categoria> categorias = new List<Categoria>();
            try
            {
                datos.SetearConsulta("SELECT Id,Descripcion FROM CATEGORIAS");
                datos.EjecutarConsulta();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = Convert.ToInt32(datos.Lector["Id"]);
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    categorias.Add(aux);
                }
                return categorias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
