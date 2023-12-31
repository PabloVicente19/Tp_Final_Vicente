﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class MarcaNegocio
    {
        private AccesoDeDatos datos;
       public List<Marca> Listar()
        {
            datos = new AccesoDeDatos();
            List<Marca> marcas = new List<Marca>();
            try
            {
                datos.SetearConsulta("SELECT Id,Descripcion FROM MARCAS");
                datos.EjecutarConsulta();
                while(datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = Convert.ToInt32(datos.Lector["Id"]);
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    marcas.Add(aux);
                }
                return marcas;
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
