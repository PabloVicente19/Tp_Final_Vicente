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
using System.Text.RegularExpressions;

namespace Interfaz
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }
        private ProductoNegocio negocio = new ProductoNegocio();
        private Helper helper = new Helper(); // clase que contiene metodos que modifican o crean funcionalidades
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
            
            listaFiltrada = productos.FindAll(obj => obj.Nombre.ToLower().Contains(filtro.ToLower()) || obj.Codigo.ToLower().Contains(filtro.ToLower()) || obj.Marca.Descripcion.ToLower().Contains(filtro.ToLower()));
            
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaFiltrada;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAltaProducto altaProducto = new FrmAltaProducto();
            altaProducto.ShowDialog();

            // Actualizo el dataGrid para mostrar los nuevos productos.
            productos = negocio.Listar();   
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
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

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Producto seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            DialogResult = MessageBox.Show($"¿Desea eliminar {seleccionado.Nombre}?","Eliminar Producto",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                negocio.EliminarProducto(seleccionado);
                MessageBox.Show("Producto Eliminado", "Eliminar Producto");
            }
            productos = negocio.Listar();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;

        }

        private void btnVerProducto_Click(object sender, EventArgs e)
        {
            Producto Seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            FrmProductoDetalle detalle = new FrmProductoDetalle(Seleccionado);
            detalle.ShowDialog();
        }

        private void dgvProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Producto Seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            FrmProductoDetalle detalle = new FrmProductoDetalle(Seleccionado);
            detalle.ShowDialog();
        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            if(panelBusquedaContenedor.Visible == false) 
            {
                panelBusquedaContenedor.Visible = true;
            }
            else
            {
                panelBusquedaContenedor.Visible = false;
            }
        }

        private void cboFiltroCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categorias = new CategoriaNegocio();

            string[] criterioPrecio = { "Mayor a", "Menor a", "Igual a" };

            switch (cboFiltroCampo.SelectedItem.ToString())
            {
                case ("Precio"):
                    cboFiltroCriterio.DataSource = criterioPrecio;
                    break;
                case ("Marca"):
                    cboFiltroCriterio.DataSource = marca.Listar();
                    break;
                case ("Categoria"):
                    cboFiltroCriterio.DataSource = categorias.Listar();
                    break;
                default:
                    break;
            }
        }

        private void cboFiltroCampo_DropDown(object sender, EventArgs e)
        {
            string[] campos = { "Precio", "Marca","Categoria" };

            cboFiltroCampo.DataSource = campos;
        }

        // botones del menuStrip
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaProducto altaProducto = new FrmAltaProducto();
            altaProducto.ShowDialog();

            // Actualizo el dataGrid para mostrar los nuevos productos.
            productos = negocio.Listar();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Producto actualProducto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            FrmAltaProducto modificarProducto = new FrmAltaProducto(actualProducto);
            modificarProducto.ShowDialog();


            productos = negocio.Listar();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            DialogResult = MessageBox.Show($"¿Desea eliminar {seleccionado.Nombre}?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                negocio.EliminarProducto(seleccionado);
                MessageBox.Show("Producto Eliminado", "Eliminar Producto");
            }
            productos = negocio.Listar();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto Seleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            FrmProductoDetalle detalle = new FrmProductoDetalle(Seleccionado);
            detalle.ShowDialog();
        }
    }
}
