using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class ProductoNegocio
    {
        private AccesoDeDatos datos;

       public List<Producto> Listar()
       {
            datos = new AccesoDeDatos();
            List<Producto> productos = new List<Producto>();
            try
            {
                datos.SetearConsulta("select AR.Id Id,Codigo,Nombre,AR.Descripcion Descripcion,MAR.Descripcion Marca,CAT.Descripcion Categoria,ImagenUrl,IdMarca,IdCategoria,Precio from ARTICULOS AR, CATEGORIAS CAT ,MARCAS MAR where AR.IdCategoria = CAT.Id and AR.IdMarca = MAR.Id");
                datos.EjecutarConsulta();

                while(datos.Lector.Read())
                {
                    Producto aux  = new Producto();
                    aux.Id = Convert.ToInt32(datos.Lector["Id"]);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = Convert.ToInt32(datos.Lector["IdMarca"]);
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = Convert.ToInt32(datos.Lector["IdCategoria"]);
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = Convert.ToDouble(datos.Lector["Precio"]);

                    productos.Add(aux);
                }
                return productos;
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
        public void AgregarProducto(Producto unProducto)
        {
            datos = new AccesoDeDatos();
            try
            {
                datos.SetearConsulta("INSERT INTO ARTICULOS VALUES(@Codigo,@Nombre,@Descripcion,@Marca,@Categoria,@Img,@Precio)");
                datos.SetearParametro("@Codigo", unProducto.Codigo);
                datos.SetearParametro("@Nombre", unProducto.Nombre);
                datos.SetearParametro("@Descripcion", unProducto.Descripcion);
                datos.SetearParametro("@Marca", unProducto.Marca.Id);
                datos.SetearParametro("@Categoria", unProducto.Categoria.Id);
                datos.SetearParametro("@Img", unProducto.Imagen);
                datos.SetearParametro("@Precio", unProducto.Precio);
                
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void ModificarProducto(Producto unProducto)
        {
            datos = new AccesoDeDatos();
            try
            {
                datos.SetearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo ,Nombre = @Nombre,Descripcion = @Descripcion,IdMarca = @IdMarca,IdCategoria = @IdCategoria, ImagenUrl = @Img,Precio = @Precio where Id = @id");
                datos.SetearParametro("@Id",unProducto.Id);
                datos.SetearParametro("Codigo", unProducto.Codigo);
                datos.SetearParametro("Nombre",unProducto.Nombre);
                datos.SetearParametro("Descripcion", unProducto.Descripcion);
                datos.SetearParametro("IdMarca", unProducto.Marca.Id);
                datos.SetearParametro("IdCategoria", unProducto.Categoria.Id);
                datos.SetearParametro("Img", unProducto.Imagen);
                datos.SetearParametro("Precio", unProducto.Precio);

                datos.EjecutarAccion();
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
