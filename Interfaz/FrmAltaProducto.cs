using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmAltaProducto : Form
    {
        private Producto producto = null;
        private Helper Helper = new Helper();


        public FrmAltaProducto()
        {
            InitializeComponent();
        }
        public FrmAltaProducto(Producto unProducto)
        {
            InitializeComponent();
            this.producto = unProducto;
            Text = "Modificar Producto";
        }
        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            cboCategoria.DataSource = categoria.Listar();
            cboMarca.DataSource = marca.Listar();

            // si producto no es null, es porque se apreto el boton modificar
            if (producto != null)
            {
                txtCodigo.Text = producto.Codigo;
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                cboMarca.Text = producto.Marca.Descripcion;
                cboCategoria.Text = producto.Categoria.Descripcion;
                txtImagen.Text = producto.Imagen;
                txtPrecio.Text = producto.Precio.ToString();
                Helper.CargarImagen(pboImagen,txtImagen.Text);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();

            if (producto == null)
                producto = new Producto();
            try
            {
                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Marca = (Marca)cboMarca.SelectedItem;
                producto.Categoria = (Categoria)cboCategoria.SelectedItem;
                producto.Precio = Convert.ToDouble(txtPrecio.Text);
                producto.Imagen = txtImagen.Text;
                if (producto.Id != null)
                {
                    productoNegocio.ModificarProducto(producto);
                    this.Close();
                }
                else
                {
                    productoNegocio.AgregarProducto(producto);
                }
                MessageBox.Show("¡Agregado Correctamente!","Alta de producto",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }   


        // evento del texbox precio .
        private void EscribirSoloNumeros(object sender, KeyPressEventArgs e)
        {

        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            Helper.CargarImagen(pboImagen, txtImagen.Text);
        }

    }
}
