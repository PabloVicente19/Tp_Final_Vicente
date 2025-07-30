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
        private readonly CategoriaNegocio _categoryService;
        private IEnumerable<Producto> _products;
        private IEnumerable<Marca> _brands;
        private IEnumerable<Categoria> _categories;
        private bool _isBrandSelected = true; // Evita que se dispare el evento al cargar el formulario
        public FrmFindProduct()
        {
            InitializeComponent();
            _productService = new ProductoNegocio();
            _brandService = new MarcaNegocio();
            _categoryService = new CategoriaNegocio();
        }

        private void FrmFindProduct_Load(object sender, EventArgs e)
        {
            try
            {
                Init();
                _isBrandSelected = false;
            }
            catch (Exception ex)
            {
                UIHelper.ShowMessage("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int? selectedBrand = UIHelper.GetValueOfComboBox(cmbBrands);
                int? selectedCategory = UIHelper.GetValueOfComboBox(cmbCategory);
                string productName = UIHelper.GetValueOfTextBox(txtFilter);

                if (selectedBrand == 0) selectedBrand = null; // Si es 0, no filtrar por marca
                if (selectedCategory == 0) selectedCategory = null; // Si es 0, no filtrar por categoria


                // Implementar el filtro del textbox para filtrat por codifo y noombre
                var filteredList = _productService.FilterProducs(_products, selectedBrand, selectedCategory, productName);

                if(!filteredList.Any())
                {
                    UIHelper.ShowMessage("No se encontraron productos con los criterios de búsqueda especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid(dgvProducts, _products); // Cargar todos los productos si no se encuentra ninguno
                    return;
                }
                LoadDataGrid(dgvProducts, filteredList);
            }
            catch (Exception ex)
            {
                UIHelper.ShowMessage("Error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDataGrid(dgvProducts, _products);
            }
            catch (Exception ex)
            {
                UIHelper.ShowMessage("Error al reiniciar el filtro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                new DataGridViewTextBoxColumn(){ Name = "Description", HeaderText= "Descripcion", DataPropertyName = "Descripcion"},
            };
            var columnsToSet = UIHelper.SetColumsInDataGrid(columns);
            UIHelper.SetDataGridView(dgvProducts, columnsToSet, products);
        }
        private void Init()
        {
            _products = _productService.Listar();
            _brands = _brandService.Listar();
            _categories = _categoryService.Listar();

            _brands = _brands.Prepend(new Marca { Id = 0, Descripcion = "-- Seleccione --" });
            _categories = _categories.Prepend(new Categoria { Id = 0, Descripcion = "-- Seleccione --" });
            LoadDataGrid(dgvProducts, _products);
            UIHelper.SetComboBox(cmbBrands, _brands, "Descripcion", "Id");
            UIHelper.SetComboBox(cmbCategory, _categories, "Descripcion", "Id");

        }
    }
}
