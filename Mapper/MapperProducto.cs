using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MapperProducto : IRepositorio<Articulo>
    {
        private readonly Acceso.Acceso _datos;
        public MapperProducto(Acceso.Acceso datos) { _datos = datos; }
        public void Agregar(Articulo tentidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Articulo> Listar()
        {
            throw new NotImplementedException();
        }

        public void Modificar(Articulo tentidad)
        {
            throw new NotImplementedException();
        }

        public Articulo ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
