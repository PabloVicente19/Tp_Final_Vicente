using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso
{
    public class Acceso
    {
        private string _cadenaDeConexion = @"Data Source=.\\SQLEXPRESS;Initial Catalog=CATALOGO_DB;";
        private SqlConnection _conexion;
        private SqlCommand _comando;
        private SqlDataReader _lector;
        private SqlTransaction _transaccion;
        
        public Acceso()
        {
            _conexion = new SqlConnection(_cadenaDeConexion);
            _comando = new SqlCommand();
        }
        public SqlDataReader Lector => _lector;

        public void SetearConsulta(string consulta)
        {
            _comando.CommandType = System.Data.CommandType.Text;
            _comando.CommandText = consulta;
        }
        public void SetearParametro(string parametro, object valor) => _comando.Parameters.AddWithValue(parametro, valor);
        public void AbrirConexion() => _conexion.Open();
        public void IniciarTransaccion() => _transaccion = _conexion.BeginTransaction();
        public void ConfirmarTransaccion() => _transaccion.Commit();
        public void RevertirTransaccion() => _transaccion.Rollback();
        public SqlDataReader EjecutarConsulta()
        {
            _comando.Connection = _conexion;
            return _lector = _comando.ExecuteReader();
        }
        public int EjecutarAccion()
        {
            _comando.Connection = _conexion;
            _comando.Transaction = _transaccion;
            return _comando.ExecuteNonQuery();
        }
        public void CerrarConexion()
        {
            if (_conexion != null)
                _conexion.Close();
            if(_lector != null)
                _lector.Close();
        }
    }
}
