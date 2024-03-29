﻿using Dominio;
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

namespace Interfaz
{
    public partial class FrmAltaProducto : Form
    {
        private Producto producto = null;
        private OpenFileDialog imagen = null;
        public FrmAltaProducto()
        {
            InitializeComponent();
        }
        public FrmAltaProducto(Producto unProducto)
        {
            InitializeComponent();
            this.producto = unProducto;
            Text = "Modificar Producto";
            lblTitulo.Text = "Modificar Producto";
        }
        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            cboCategoria.DataSource = categoria.Listar();
            cboMarca.DataSource = marca.Listar();

            // si producto no es null, es porque se apreto el boton modificar
            if (producto != null)
            {
                txtCodigo.Text = producto.Codigo;
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                cboMarca.Text = producto.Marca.Descripcion;
                cboCategoria.Text = producto.Categoria.Descripcion;
                txtImagen.Text = producto.Imagen;
                txtPrecio.Text = producto.Precio.ToString();
                Helper.CargarImagen(pboImagen,txtImagen.Text);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();

            if (producto == null)
                producto = new Producto();
            try
            {
                producto.Codigo = txtCodigo.Text;
                if (Helper.ValidarTextBox(txtNombre, lblNombre.Text))
                    producto.Nombre = txtNombre.Text;
                else
                    return;
                if (Helper.ValidarTextBox(txtPrecio,lblPrecio.Text))
                    producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                else
                    return;
                
                producto.Descripcion = txtDescripcion.Text;
                producto.Marca = (Marca)cboMarca.SelectedItem;
                producto.Categoria = (Categoria)cboCategoria.SelectedItem;

                producto.Imagen = txtImagen.Text;

                if (producto.Id != 0)
                {
                    productoNegocio.ModificarProducto(producto);
                    MessageBox.Show("¡Producto Modificado!", "Alta de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    if(imagen != null && (!txtImagen.Text.ToLower().Contains("http")))
                    {
                      File.Copy(imagen.FileName, ConfigurationManager.AppSettings["images-catalogo"] + imagen.SafeFileName,true);
                    }
                    productoNegocio.AgregarProducto(producto);
                    MessageBox.Show("¡Agregado Correctamente!","Alta de producto",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }   
        private void txtImagen_Leave(object sender, EventArgs e)
        {
            Helper.CargarImagen(pboImagen, txtImagen.Text);
        }
        private void BtnAgregarImagen_Click(object sender, EventArgs e)
        {
            imagen = new OpenFileDialog();
            imagen.Filter = "jpg|*.jpg|png|*.png";
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = imagen.FileName;
                Helper.CargarImagen(pboImagen, imagen.FileName);
            }
        }
    }
}
