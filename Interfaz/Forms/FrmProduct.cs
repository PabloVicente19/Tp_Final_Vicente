using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Interfaz.Helpers;
using Negocio;

namespace Interfaz.Forms
{
    public partial class FrmProduct : Form
    {
        private readonly ProductoNegocio _productService;
        private readonly MarcaNegocio _brandService;
        private readonly CategoriaNegocio _categoryService;
        private Producto _product;
        private IEnumerable<Categoria> _categories;
        private IEnumerable<Marca> _brands;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductoNegocio();
            _brandService = new MarcaNegocio();
            _categoryService = new CategoriaNegocio();

        }
        public FrmProduct(Producto product) : this()
        {
            _product = product;
            lblTitle.Text = "Modificar Producto";
            btnSubmit.Text = "Modificar";
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            Init();
            if (_product != null) LoadProduct();
        }
        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            if(_product == null)
            {
                _product = SetNewProduct();
                AddNewProduct(_product);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _product = SetUpdateProduct(_product);
                UpdateProduct(_product);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            // Optimizar este método
            //string filePath = string.Empty; 
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Title = "Seleccione una imagen";
            //openFileDialog.Filter= "Image Files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png| All files(*.*)|*.*";
            //if(openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    filePath = openFileDialog.FileName;
            //    txtImage.Text = filePath;
            //    UIHelper.LoadImage(pbImage, filePath);
            //}

            //string targetFolder = @"C:\ImagenesCatalogo\";
            //if(!Directory.Exists(targetFolder))
            //{
            //    Directory.CreateDirectory(targetFolder);
            //}

            //string fileName = Path.GetFileName(filePath);
            //string targetPath = Path.Combine(targetFolder, fileName);
            //if (!File.Exists(targetPath))
            //{
            //    File.Copy(filePath, targetPath, true);
            //}
        }

        // Features
        private void Init()
        {
            _brands = _brandService.GetAllBrands();
            _categories = _categoryService.GetAllCategories();

            _brands = _brands.Prepend(new Marca { Id = 0, Descripcion = "-- Seleccione --" });
            _categories = _categories.Prepend(new Categoria { Id = 0, Descripcion = "-- Seleccione --" });

            UIHelper.SetComboBox(cmbBrand, _brands, "Descripcion", "Id");
            UIHelper.SetComboBox(cmbCategory, _categories, "Descripcion", "Id");
        }
        private Producto SetNewProduct()
        {
            Producto product = new Producto();
            product.Codigo = txtCode.Text;
            product.Nombre = txtName.Text;
            product.Descripcion = txtDescription.Text;
            product.Marca = (Marca)cmbBrand.SelectedItem;
            product.Categoria = (Categoria)cmbCategory.SelectedItem;
            product.Imagen = txtImage.Text;
            product.Precio = decimal.TryParse(txtPrice.Text, out decimal precio) ? precio : 0;
            return product;
        }
        private Producto SetUpdateProduct(Producto product)
        {
            product.Codigo = txtCode.Text;
            product.Nombre = txtName.Text;
            product.Descripcion = txtDescription.Text;
            product.Marca = (Marca)cmbBrand.SelectedItem;
            product.Categoria = (Categoria)cmbCategory.SelectedItem;
            product.Imagen = txtImage.Text;
            product.Precio = decimal.TryParse(txtPrice.Text, out decimal precio) ? precio : 0;
            return product;
        }
        private void LoadProduct()
        {
            txtCode.Text = _product.Codigo;
            txtName.Text = _product.Nombre;
            txtDescription.Text = _product.Descripcion;
            cmbBrand.SelectedValue = _product.Marca.Id;
            cmbCategory.SelectedValue = _product.Categoria.Id;
            txtImage.Text = _product.Imagen;
            txtPrice.Text = _product.Precio.ToString();
            UIHelper.LoadImage(pbImage, _product.Imagen);
        }
        private bool ValidateFields()
        {
            if (!ValidationHelper.IsTextFieldValid(txtCode.Text))
            {
                MessageBox.Show("El campo Codigo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!ValidationHelper.IsTextFieldValid(txtName.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(UIHelper.GetValueOfComboBox(cmbBrand) == 0)
            {
                MessageBox.Show("Debe seleccionar una Marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (UIHelper.GetValueOfComboBox(cmbCategory) == 0)
            {
                MessageBox.Show("Debe seleccionar una Categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!ValidationHelper.IsTextFieldValid(txtPrice.Text) || !decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("El campo Precio es obligatorio y debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void AddNewProduct(Producto product)
        {
            _productService.AddProduct(product);
            MessageBox.Show("¡Producto Agregado!", "Alta de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateProduct(Producto product)
        {
            _productService.UpdateProduct(product);
            MessageBox.Show("¡Producto Modificado!", "Modificación de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
