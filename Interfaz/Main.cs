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
using static System.Net.WebRequestMethods;

namespace Interfaz
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private ProductoNegocio negocio = new ProductoNegocio();
        private Helper helper = new Helper();
        private List<Producto> productos;
        private void frmMain_Load(object sender, EventArgs e)
        {
            productos = negocio.Listar();
            dgvProductos.DataSource = productos;
            helper.CargarImagen(pboProducto, productos[0].Imagen);
            helper.OcultarCamposEnDgb(dgvProductos, "Id");
            helper.OcultarCamposEnDgb(dgvProductos, "Descripcion");
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Desea Salir?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes) 
            {
                this.Close();
            }
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAltaProducto altaProducto = new FrmAltaProducto();
            altaProducto.ShowDialog();

            // cuando cierra el formulario actualiza la datagrid
            productos = negocio.Listar();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvProductos.CurrentRow != null)
                {
                    Producto seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                    helper.OcultarCamposEnDgb(dgvProductos, "Id");
                    helper.OcultarCamposEnDgb(dgvProductos, "Descripcion");
                    helper.CargarImagen(pboProducto, seleccionado.Imagen);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaFiltrada;
            string filtro = txtBuscar.Text;
            
            listaFiltrada = productos.FindAll(obj => obj.Nombre.ToLower().Contains(filtro.ToLower()) || obj.Codigo.ToLower().Contains(filtro.ToLower()));
            
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaFiltrada;
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Producto actualProducto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            FrmAltaProducto modificarProducto = new FrmAltaProducto(actualProducto);
            modificarProducto.ShowDialog();


            productos = negocio.Listar();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }
    }
}
