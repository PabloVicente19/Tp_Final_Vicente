using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public interface IRepositorio<Tentidad> where Tentidad : class
    {
        IEnumerable<Tentidad> Listar();
        Tentidad ObtenerPorId(int id);
        void Agregar(Tentidad tentidad);
        void Modificar(Tentidad tentidad);
        void Eliminar(int id);
    }
}
