using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaz.Helpers;
using Dominio;
using Negocio;

namespace Interfaz.Forms
{
    public partial class FrmFindProduct : Form
    {
        private readonly ProductoNegocio _productService;
        private readonly MarcaNegocio _brandService;
        private IEnumerable<Producto> _products;
        private bool _isBrandSelected = true; // Evita que se dispare el evento al cargar el formulario
        public FrmFindProduct()
        {
            InitializeComponent();
            _productService = new ProductoNegocio();
            _brandService = new MarcaNegocio();
        }

        private void FrmFindProduct_Load(object sender, EventArgs e)
        {
            Init();
            _isBrandSelected = false;
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBrandSelected) return;
        }
        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            var selectedBrand = int.TryParse(cmbBrands.SelectedValue?.ToString(), out int brandId) ? brandId : (int?)null;

        }

        // Features
        private void LoadDataGrid(DataGridView dgv, IEnumerable<Producto> products)
        {
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn(){ Name = "Code", HeaderText= "Codigo", DataPropertyName = "Codigo"},
                new DataGridViewTextBoxColumn(){ Name = "Name", HeaderText= "Nombre", DataPropertyName = "Nombre"},
                new DataGridViewTextBoxColumn(){ Name = "Brand", HeaderText= "Marca", DataPropertyName = "Marca"},
                new DataGridViewTextBoxColumn(){ Name = "Category", HeaderText= "Categoria", DataPropertyName = "Categoria"},
                new DataGridViewTextBoxColumn(){ Name = "Price", HeaderText= "Precio", DataPropertyName = "Precio"},
            };
            var columnsToSet = UIHelper.SetColumsInDataGrid(columns);
            UIHelper.SetDataGridView(dgvProducts, columnsToSet, _products);
        }
        private void Init()
        {
            _products = _productService.Listar();
            LoadDataGrid(dgvProducts, _products);
            UIHelper.SetComboBox(cmbBrands, _brandService.Listar(), "Descripcion", "Id");
        }

    }
}
