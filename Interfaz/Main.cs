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
using Dominio;

namespace Interfaz
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private ProductoNegocio negocio = new ProductoNegocio();
        private List<Producto> productos;
        private void frmMain_Load(object sender, EventArgs e)
        {
            productos = negocio.Listar();
            dgvProductos.DataSource = productos;
            CargarImagen(productos[0].Imagen);
            OcultarCamposEnDgv("Id");
            OcultarCamposEnDgv("Descripcion");
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Desea Salir?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes) 
            {
                this.Close();
            }
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.Imagen);
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAltaProducto altaProducto = new FrmAltaProducto();
            altaProducto.ShowDialog();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaFiltrada;
            string filtro = txtBuscar.Text;
            
            listaFiltrada = productos.FindAll(obj => obj.Nombre.ToLower().Contains(filtro.ToLower()) || obj.Codigo.ToLower().Contains(filtro.ToLower()));
            
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaFiltrada;
        }

        // METODOS QUE MODIFICAN FUNCIONALIDADES
        private void OcultarCamposEnDgv(string campo)
        {
            dgvProductos.Columns[campo].Visible = false;
        }
        private void CargarImagen(string imagen)
        {
            try
            {
               pboProducto.Load(imagen);
            }
            catch (Exception ex)
            {
                pboProducto.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

    }
}
