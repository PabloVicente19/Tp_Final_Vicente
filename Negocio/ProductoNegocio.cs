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
        private readonly AccesoDeDatos _context;
        public ProductoNegocio()
        {
            _context = new AccesoDeDatos();
        }
        public ICollection<Producto> GetAllProducts()
        {
            ICollection<Producto> products = new List<Producto>();
            try
            {
                _context.SetearConsulta("select AR.Id Id,Codigo,Nombre,AR.Descripcion Descripcion,MAR.Descripcion Marca,CAT.Descripcion Categoria,ImagenUrl,IdMarca,IdCategoria,Precio from ARTICULOS AR, CATEGORIAS CAT ,MARCAS MAR where AR.IdCategoria = CAT.Id and AR.IdMarca = MAR.Id");
                _context.EjecutarConsulta();
                while (_context.Lector.Read())
                {
                    Producto product = new Producto();
                    product.Id = Convert.ToInt32(_context.Lector["Id"]);
                    product.Codigo = (string)_context.Lector["Codigo"];
                    product.Nombre = (string)_context.Lector["Nombre"];
                    product.Descripcion = (string)_context.Lector["Descripcion"];
                    product.Marca = new Marca();
                    product.Marca.Id = Convert.ToInt32(_context.Lector["IdMarca"]);
                    product.Marca.Descripcion = (string)_context.Lector["Marca"];
                    product.Categoria = new Categoria();
                    product.Categoria.Id = Convert.ToInt32(_context.Lector["IdCategoria"]);
                    product.Categoria.Descripcion = (string)_context.Lector["Categoria"];
                    product.Imagen = (string)_context.Lector["ImagenUrl"];
                    product.Precio = Math.Round(Convert.ToDecimal(_context.Lector["Precio"]), 2);

                    products.Add(product);
                }
                return products;
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



                _context.SetearConsulta($"select AR.Id Id,Codigo,Nombre,AR.Descripcion Descripcion,MAR.Descripcion Marca,CAT.Descripcion Categoria,ImagenUrl,IdMarca,IdCategoria,Precio from ARTICULOS AR, CATEGORIAS CAT ,MARCAS MAR where AR.IdCategoria = CAT.Id and AR.IdMarca = MAR.Id and {filtrar}");
                _context.EjecutarConsulta();

                while (_context.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = Convert.ToInt32(_context.Lector["Id"]);
                    aux.Codigo = (string)_context.Lector["Codigo"];
                    aux.Nombre = (string)_context.Lector["Nombre"];
                    aux.Descripcion = (string)_context.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = Convert.ToInt32(_context.Lector["IdMarca"]);
                    aux.Marca.Descripcion = (string)_context.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = Convert.ToInt32(_context.Lector["IdCategoria"]);
                    aux.Categoria.Descripcion = (string)_context.Lector["Categoria"];
                    aux.Imagen = (string)_context.Lector["ImagenUrl"];
                    aux.Precio = Math.Round(Convert.ToDecimal(_context.Lector["Precio"]), 2);

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
                _context.CerrarConexion();
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
                _context.SetearConsulta("INSERT INTO ARTICULOS VALUES(@Codigo,@Nombre,@Descripcion,@Marca,@Categoria,@Img,@Precio)");
                _context.SetearParametro("@Codigo", product.Codigo);
                _context.SetearParametro("@Nombre", product.Nombre);
                _context.SetearParametro("@Descripcion", product.Descripcion);
                _context.SetearParametro("@Marca", product.Marca.Id);
                _context.SetearParametro("@Categoria", product.Categoria.Id);
                _context.SetearParametro("@Img", product.Imagen);
                _context.SetearParametro("@Precio", product.Precio);

                _context.EjecutarAccion();
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
            finally
            {
                _context.CerrarConexion();
            }
        }
        public void UpdateProduct(Producto product)
        {
            try
            {
                _context.SetearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo ,Nombre = @Nombre,Descripcion = @Descripcion,IdMarca = @IdMarca,IdCategoria = @IdCategoria, ImagenUrl = @Img,Precio = @Precio where Id = @id");
                _context.SetearParametro("@Id", product.Id);
                _context.SetearParametro("Codigo", product.Codigo);
                _context.SetearParametro("Nombre", product.Nombre);
                _context.SetearParametro("Descripcion", product.Descripcion);
                _context.SetearParametro("IdMarca", product.Marca.Id);
                _context.SetearParametro("IdCategoria", product.Categoria.Id);
                _context.SetearParametro("Img", product.Imagen);
                _context.SetearParametro("Precio", product.Precio);

                _context.EjecutarAccion();
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
        public void RemoveProduct(Producto product)
        {
            try
            {
                _context.SetearConsulta("delete from ARTICULOS where id = @Id");
                _context.SetearParametro("@Id", product.Id);
                _context.EjecutarAccion();
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
