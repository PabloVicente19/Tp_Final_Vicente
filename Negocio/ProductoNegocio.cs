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
        private readonly AccesoDeDatos datos;
        public ProductoNegocio()
        {
            datos = new AccesoDeDatos();
        }
        public List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                datos.SetearConsulta("select AR.Id Id,Codigo,Nombre,AR.Descripcion Descripcion,MAR.Descripcion Marca,CAT.Descripcion Categoria,ImagenUrl,IdMarca,IdCategoria,Precio from ARTICULOS AR, CATEGORIAS CAT ,MARCAS MAR where AR.IdCategoria = CAT.Id and AR.IdMarca = MAR.Id");
                datos.EjecutarConsulta();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
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
                    aux.Precio = Math.Round(Convert.ToDecimal(datos.Lector["Precio"]), 2);

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
        public List<Producto> BuscarProducto(string campo, string criterio, string descripcion)
        {
            List<Producto> filtrado = new List<Producto>();
            try
            {

                string filtrar = String.Empty;

                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            filtrar = "Precio > " + descripcion;
                            break;
                        case "Menor a":
                            filtrar = "Precio < " + descripcion;
                            break;
                        case "Igual a":
                            filtrar = "Precio = " + descripcion;
                            break;
                        default:
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    filtrar = "MAR.Descripcion = '" + criterio + "'";
                }
                else if (campo == "Categoria")
                {
                    filtrar = "CAT.Descripcion = '" + criterio + "'";
                }



                datos.SetearConsulta($"select AR.Id Id,Codigo,Nombre,AR.Descripcion Descripcion,MAR.Descripcion Marca,CAT.Descripcion Categoria,ImagenUrl,IdMarca,IdCategoria,Precio from ARTICULOS AR, CATEGORIAS CAT ,MARCAS MAR where AR.IdCategoria = CAT.Id and AR.IdMarca = MAR.Id and {filtrar}");
                datos.EjecutarConsulta();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
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
                    aux.Precio = Math.Round(Convert.ToDecimal(datos.Lector["Precio"]), 2);

                    filtrado.Add(aux);
                }
                return filtrado;

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
        public IEnumerable<Producto> FilterByName(IEnumerable<Producto> products, string name)
        {
            var result = products
                .Where(prod =>
                {
                    var productName = prod.Nombre.ToLower();
                    var words = name.Split();
                    return words.All(word => productName.Contains(word.ToLower()));
                });
            return result;
        }
        public void AddProduct(Producto product)
        {
            try
            {
                datos.SetearConsulta("INSERT INTO ARTICULOS VALUES(@Codigo,@Nombre,@Descripcion,@Marca,@Categoria,@Img,@Precio)");
                datos.SetearParametro("@Codigo", product.Codigo);
                datos.SetearParametro("@Nombre", product.Nombre);
                datos.SetearParametro("@Descripcion", product.Descripcion);
                datos.SetearParametro("@Marca", product.Marca.Id);
                datos.SetearParametro("@Categoria", product.Categoria.Id);
                datos.SetearParametro("@Img", product.Imagen);
                datos.SetearParametro("@Precio", product.Precio);

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
        public void UpdateProduct(Producto product)
        {
            try
            {
                datos.SetearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo ,Nombre = @Nombre,Descripcion = @Descripcion,IdMarca = @IdMarca,IdCategoria = @IdCategoria, ImagenUrl = @Img,Precio = @Precio where Id = @id");
                datos.SetearParametro("@Id", product.Id);
                datos.SetearParametro("Codigo", product.Codigo);
                datos.SetearParametro("Nombre", product.Nombre);
                datos.SetearParametro("Descripcion", product.Descripcion);
                datos.SetearParametro("IdMarca", product.Marca.Id);
                datos.SetearParametro("IdCategoria", product.Categoria.Id);
                datos.SetearParametro("Img", product.Imagen);
                datos.SetearParametro("Precio", product.Precio);

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
        public void RemoveProduct(Producto product)
        {
            try
            {
                datos.SetearConsulta("delete from ARTICULOS where id = @Id");
                datos.SetearParametro("@Id", product.Id);
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
        public IEnumerable<Producto> FilterProducs(IEnumerable<Producto> data, int? brandId = null, int? categoryId = null, string name = null)
        {
            var filteredList = data;

            if (brandId.HasValue)
                filteredList = filteredList.Where(product => product.Marca.Id == brandId.Value);
            if (categoryId.HasValue)
                filteredList = filteredList.Where(product => product.Categoria.Id == categoryId.Value);
            if(name != null)
                filteredList = FilterByName(filteredList, name);
            return filteredList;
        }
    }
}
