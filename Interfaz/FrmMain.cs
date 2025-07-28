using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Interfaz.Helpers;

namespace Interfaz
{
    public partial class frmMain : Form
    {
        private readonly ProductoNegocio _productService;
        private List<Producto> _products;
        public frmMain()
        {
            InitializeComponent();
            _productService = new ProductoNegocio();

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _products = _productService.Listar();
            LoadDataGridView(dgvProducts, _products);
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAltaProducto frmProduct = new FrmAltaProducto();
            frmProduct.ShowDialog();
            if (frmProduct.DialogResult == DialogResult.OK) Init();
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Producto product = (Producto)dgvProducts.CurrentRow.DataBoundItem;
            FrmAltaProducto frmProduct = new FrmAltaProducto(product);
            frmProduct.ShowDialog();
            if (frmProduct.DialogResult == DialogResult.OK) Init();
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Producto seleccionado = (Producto)dgvProducts.CurrentRow.DataBoundItem;
            DialogResult = MessageBox.Show($"¿Desea eliminar {seleccionado.Nombre}?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                _productService.EliminarProducto(seleccionado);
                MessageBox.Show("Producto Eliminado", "Eliminar Producto");
            }
            _products = _productService.Listar();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = _products;

        }
        private void btnVerProducto_Click(object sender, EventArgs e)
        {
            Producto Seleccionado = (Producto)dgvProducts.CurrentRow.DataBoundItem;
            FrmProductoDetalle detalle = new FrmProductoDetalle(Seleccionado);
            detalle.ShowDialog();
        }
        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            if (panelBusquedaContenedor.Visible == false)
            {
                panelBusquedaContenedor.Visible = true;
            }
            else
            {
                panelBusquedaContenedor.Visible = false;
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string productName = txtFilter.Text;
            var filteredList = _productService.FilterByName(_products, productName);
            dgvProducts.DataSource = filteredList.ToList();
        }
        private void dgvProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Producto Seleccionado = (Producto)dgvProducts.CurrentRow.DataBoundItem;
            FrmProductoDetalle detalle = new FrmProductoDetalle(Seleccionado);
            detalle.ShowDialog();
        }
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.CurrentRow != null)
                {
                    Producto seleccionado = (Producto)dgvProducts.CurrentRow.DataBoundItem;
                    UIHelper.LoadImage(pboProducto, seleccionado.Imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    txtFiltro.Visible = true;
                    lblFiltro.Visible = true;
                    break;
                case ("Marca"):
                    cboFiltroCriterio.DataSource = marca.Listar();
                    txtFiltro.Visible = false;
                    lblFiltro.Visible = false;

                    break;
                case ("Categoria"):
                    cboFiltroCriterio.DataSource = categorias.Listar();
                    txtFiltro.Visible = false;
                    lblFiltro.Visible = false;

                    break;
                default:
                    break;
            }
        }
        private void cboFiltroCampo_DropDown(object sender, EventArgs e)
        {
            string[] campos = { "Precio", "Marca", "Categoria" };

            cboFiltroCampo.DataSource = campos;
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {

                // Si no selecciona ningun campo lanza la advertencia
                if (cboFiltroCampo.SelectedItem == null)
                {
                    MessageBox.Show("Debe Ingresar un Campo");
                    return;
                }

                // Si selecciono la categoria precio pero se hace click sin ingresar un valor en el txt lanza la advertencia
                if (cboFiltroCampo.SelectedItem == "Precio" && txtFiltro.Text == "")
                {
                    MessageBox.Show("Debe ingrear un valor");
                    return;
                }


                // si pasa las validaciones se guardan los datos en las variables.
                string campo = cboFiltroCampo.SelectedItem.ToString();
                string criterio = cboFiltroCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;

                List<Producto> productoFiltrado = _productService.BuscarProducto(campo, criterio, filtro);
                dgvProducts.DataSource = productoFiltrado;

                if (productoFiltrado.Count == 0)
                {
                    MessageBox.Show("¡No existe el Producto!", "Busqueda Avanzada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFiltro.Text = "";
                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = _productService.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
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
            Init();
        }
        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Producto actualProducto = (Producto)dgvProducts.CurrentRow.DataBoundItem;
            FrmAltaProducto modificarProducto = new FrmAltaProducto(actualProducto);
            modificarProducto.ShowDialog();
            Init();
        }
        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto seleccionado = (Producto)dgvProducts.CurrentRow.DataBoundItem;
            DialogResult = MessageBox.Show($"¿Desea eliminar {seleccionado.Nombre}?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                _productService.EliminarProducto(seleccionado);
                MessageBox.Show("Producto Eliminado", "Eliminar Producto");
                Init();
            }
        }
        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto Seleccionado = (Producto)dgvProducts.CurrentRow.DataBoundItem;
            FrmProductoDetalle detalle = new FrmProductoDetalle(Seleccionado);
            detalle.ShowDialog();
        }

        // Features
        private DataGridViewTextBoxColumn[] SetColumnsInDataGridView()
        {
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn(){ Name = "Code", HeaderText= "Codigo", DataPropertyName = "Codigo"},
                new DataGridViewTextBoxColumn(){ Name = "Name", HeaderText= "Nombre", DataPropertyName = "Nombre"},
                new DataGridViewTextBoxColumn(){ Name = "Brand", HeaderText= "Marca", DataPropertyName = "Marca"},
                new DataGridViewTextBoxColumn(){ Name = "Category", HeaderText= "Categoria", DataPropertyName = "Categoria"},
                new DataGridViewTextBoxColumn(){ Name = "Price", HeaderText= "Precio", DataPropertyName = "Precio"},
            };
            return columns;
        }
        private void LoadDataGridView(DataGridView dgv, List<Producto> products)
        {
            dgv.AutoGenerateColumns = false;
            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.AddRange(SetColumnsInDataGridView());
            }
            dgv.DataSource = products;
            dgv.ClearSelection();
        }
        private void Init()
        {
            _products = _productService.Listar();
            LoadDataGridView(dgvProducts, _products);
        }
    }
}
