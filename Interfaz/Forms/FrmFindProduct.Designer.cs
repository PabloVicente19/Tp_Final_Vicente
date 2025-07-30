namespace Interfaz.Forms
{
    partial class FrmFindProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlOptionsFilterContainer = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrands = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlBtnContainer = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.pnlOptionsFilterContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlBtnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.pnlOptionsFilterContainer);
            this.pnlContainer.Controls.Add(this.dgvProducts);
            this.pnlContainer.Controls.Add(this.pnlBtnContainer);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(3);
            this.pnlContainer.Size = new System.Drawing.Size(934, 461);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlOptionsFilterContainer
            // 
            this.pnlOptionsFilterContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOptionsFilterContainer.Controls.Add(this.label1);
            this.pnlOptionsFilterContainer.Controls.Add(this.txtFilter);
            this.pnlOptionsFilterContainer.Controls.Add(this.lblCategory);
            this.pnlOptionsFilterContainer.Controls.Add(this.cmbCategory);
            this.pnlOptionsFilterContainer.Controls.Add(this.btnResetFilter);
            this.pnlOptionsFilterContainer.Controls.Add(this.btnFindProduct);
            this.pnlOptionsFilterContainer.Controls.Add(this.lblBrand);
            this.pnlOptionsFilterContainer.Controls.Add(this.cmbBrands);
            this.pnlOptionsFilterContainer.Location = new System.Drawing.Point(6, 6);
            this.pnlOptionsFilterContainer.Name = "pnlOptionsFilterContainer";
            this.pnlOptionsFilterContainer.Size = new System.Drawing.Size(920, 69);
            this.pnlOptionsFilterContainer.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(226, 13);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Categorias";
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(226, 27);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 21);
            this.cmbCategory.TabIndex = 4;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetFilter.Location = new System.Drawing.Point(743, 3);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(170, 23);
            this.btnResetFilter.TabIndex = 3;
            this.btnResetFilter.Text = "Eliminar Filtros";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFindProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindProduct.Location = new System.Drawing.Point(743, 39);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(170, 23);
            this.btnFindProduct.TabIndex = 2;
            this.btnFindProduct.Text = "Buscar Producto";
            this.btnFindProduct.UseVisualStyleBackColor = false;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(3, 11);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(42, 13);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Marcas";
            // 
            // cmbBrands
            // 
            this.cmbBrands.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBrands.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBrands.FormattingEnabled = true;
            this.cmbBrands.Location = new System.Drawing.Point(3, 27);
            this.cmbBrands.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.cmbBrands.Name = "cmbBrands";
            this.cmbBrands.Size = new System.Drawing.Size(200, 21);
            this.cmbBrands.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 81);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(920, 325);
            this.dgvProducts.TabIndex = 1;
            // 
            // pnlBtnContainer
            // 
            this.pnlBtnContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtnContainer.Controls.Add(this.btnCloseForm);
            this.pnlBtnContainer.Location = new System.Drawing.Point(6, 412);
            this.pnlBtnContainer.Name = "pnlBtnContainer";
            this.pnlBtnContainer.Size = new System.Drawing.Size(920, 41);
            this.pnlBtnContainer.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseForm.Location = new System.Drawing.Point(810, 3);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(103, 31);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Text = "Cerrar";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(449, 27);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(200, 20);
            this.txtFilter.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // FrmFindProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContainer);
            this.Name = "FrmFindProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda Avanzada";
            this.Load += new System.EventHandler(this.FrmFindProduct_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlOptionsFilterContainer.ResumeLayout(false);
            this.pnlOptionsFilterContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlBtnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlBtnContainer;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlOptionsFilterContainer;
        private System.Windows.Forms.ComboBox cmbBrands;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
    }
}