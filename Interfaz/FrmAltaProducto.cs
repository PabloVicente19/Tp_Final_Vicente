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
using System.Configuration;
using System.IO;
using Interfaz.Helpers;

namespace Interfaz
{
    public partial class FrmAltaProducto : Form
    {
        private readonly MarcaNegocio _brandService;
        private readonly CategoriaNegocio _categoryService;
        private readonly ProductoNegocio _productService;
        private Producto _product = null;
        private OpenFileDialog _imagen = null;
        public FrmAltaProducto()
        {
            InitializeComponent();
            _brandService = new MarcaNegocio();
            _categoryService = new CategoriaNegocio();
            _productService = new ProductoNegocio();
        }
        public FrmAltaProducto(Producto product) : this()
        {
            _product = product;
            Text = "Modificar Producto";
            lblTitulo.Text = "Modificar Producto";
            btnSubmit.Text = "Modificar";
        }
        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            UIHelper.SetComboBox(cmbCategory, _categoryService.Listar(), "Descripcion", "Id");
            UIHelper.SetComboBox(cmbBrand, _brandService.Listar(), "Descripcion", "Id");
            if (_product != null) LoadProduct();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_product == null)
                _product = SetNewProduct();
            else
                _product = SetUpdateProduct(_product);
            try
            {
                if (!ValidateField()) return;
                if (_product.Id != 0)
                {
                    UpdateProduct(_product);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (_imagen != null && (!txtImage.Text.ToLower().Contains("http")))
                    {
                        File.Copy(_imagen.FileName, ConfigurationManager.AppSettings["images-catalogo"] + _imagen.SafeFileName, true);
                    }
                    AddNewProduct(_product);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtImagen_Leave(object sender, EventArgs e)
        {
            UIHelper.LoadImage(pbImage, txtImage.Text);
        }
        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            _imagen = new OpenFileDialog();
            _imagen.Filter = "jpg|*.jpg|png|*.png";
            if (_imagen.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = _imagen.FileName;
                UIHelper.LoadImage(pbImage, _imagen.FileName);
            }
        }

        // Features
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
            cmbBrand.SelectedItem = _product.Marca;
            cmbCategory.SelectedItem = _product.Categoria;
            txtImage.Text = _product.Imagen;
            txtPrice.Text = _product.Precio.ToString();
            UIHelper.LoadImage(pbImage, _product.Imagen);
        }
        private bool ValidateField()
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
