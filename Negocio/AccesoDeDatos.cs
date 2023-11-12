using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AccesoDeDatos
    {
        private SqlConnection _Conexion;
        private SqlCommand _Comando;
        private SqlDataReader _Lector;
    
        public AccesoDeDatos()
        {
            _Conexion = new SqlConnection("");
            _Comando = new SqlCommand();
        }
        public SqlDataReader Lector
        {
            get { return _Lector; }
        }
        public void SetearConsulta(string consulta)
        {
            _Comando.CommandType = System.Data.CommandType.Text;
            _Comando.CommandText = consulta;
        }
        public void EjecutarConsulta()
        {
            _Comando.Connection = _Conexion;
            try
            {
                _Conexion.Open();
                _Lector = _Comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void CerrarConexion()
        {
            if (_Lector == null)
                _Lector.Close();
            _Conexion.Close();
        }
        public void SetearParametro(string parametro, object valor)
        {
            
        }
    }
}
