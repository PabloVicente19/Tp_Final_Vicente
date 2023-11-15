using Dominio;
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
    public partial class FrmProductoDetalle : Form
    {
        Producto producto = null;
        public FrmProductoDetalle()
        {
            InitializeComponent();
        }
        public FrmProductoDetalle(Producto unProducto)
        {
            InitializeComponent();
            this.producto = unProducto;
            
        }
        private void FrmProductoDetalle_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = producto.Codigo;
            lblNombre.Text = producto.Nombre;
            lblCategoria.Text = producto.Categoria.Descripcion;
            lblMarca.Text = producto.Marca.Descripcion;
            lblDescripcion.Text = producto.Descripcion;
            lblPrecio.Text = "$: " + producto.Precio.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
