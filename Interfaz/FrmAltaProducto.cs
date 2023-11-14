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
        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            cboCategoria.DataSource = categoria.Listar();
            cboMarca.DataSource = marca.Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (producto == null)
                producto = new Producto();
            try
            {
                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Marca = (Marca)cboMarca.SelectedItem;
                producto.Categoria = (Categoria)cboCategoria.SelectedItem;
                producto.Precio = Convert.ToInt32(txtPrecio.Text);
                producto.Imagen = txtImagen.Text;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }   


        // evento del texbox precio .
        private void EscribirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            Helper.CargarImagen(pboImagen, txtImagen.Text);
        }
    }
}
