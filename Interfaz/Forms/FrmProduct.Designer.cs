namespace Interfaz.Forms
{
    partial class FrmProduct
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.pnlBtnsContainer = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.BtnCloseForm = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbData.SuspendLayout();
            this.pnlBtnsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(684, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registo Producto";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pbImage);
            this.pnlContainer.Controls.Add(this.gbData);
            this.pnlContainer.Controls.Add(this.pnlBtnsContainer);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 41);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(684, 520);
            this.pnlContainer.TabIndex = 1;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(484, 10);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(188, 186);
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // gbData
            // 
            this.gbData.BackColor = System.Drawing.SystemColors.Control;
            this.gbData.Controls.Add(this.txtPrice);
            this.gbData.Controls.Add(this.lblPrice);
            this.gbData.Controls.Add(this.txtDescription);
            this.gbData.Controls.Add(this.lblDescription);
            this.gbData.Controls.Add(this.btnAddCategory);
            this.gbData.Controls.Add(this.btnAddBrand);
            this.gbData.Controls.Add(this.btnAddImage);
            this.gbData.Controls.Add(this.txtImage);
            this.gbData.Controls.Add(this.lblImage);
            this.gbData.Controls.Add(this.cmbCategory);
            this.gbData.Controls.Add(this.lblCategory);
            this.gbData.Controls.Add(this.lblMarca);
            this.gbData.Controls.Add(this.cmbBrand);
            this.gbData.Controls.Add(this.lblNombre);
            this.gbData.Controls.Add(this.txtName);
            this.gbData.Controls.Add(this.lblCode);
            this.gbData.Controls.Add(this.txtCode);
            this.gbData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbData.Location = new System.Drawing.Point(19, 10);
            this.gbData.Margin = new System.Windows.Forms.Padding(10);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(452, 447);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            this.gbData.Text = "Datos del Producto";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(54, 412);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(79, 20);
            this.txtPrice.TabIndex = 16;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 414);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Precio:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 288);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(440, 101);
            this.txtDescription.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 272);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Descripción";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddCategory.Location = new System.Drawing.Point(371, 157);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 29);
            this.btnAddCategory.TabIndex = 12;
            this.btnAddCategory.Text = "Agregar";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrand.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddBrand.Location = new System.Drawing.Point(371, 100);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(75, 29);
            this.btnAddBrand.TabIndex = 11;
            this.btnAddBrand.Text = "Agregar";
            this.btnAddBrand.UseVisualStyleBackColor = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddImage.Location = new System.Drawing.Point(371, 218);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 29);
            this.btnAddImage.TabIndex = 10;
            this.btnAddImage.Text = "Agregar";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(6, 219);
            this.txtImage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(344, 20);
            this.txtImage.TabIndex = 9;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(6, 203);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(42, 13);
            this.lblImage.TabIndex = 8;
            this.lblImage.Text = "Imagen";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(6, 162);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(344, 21);
            this.cmbCategory.TabIndex = 7;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 146);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Categoría";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 89);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(6, 105);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(344, 21);
            this.cmbBrand.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(266, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(266, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 28);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Código";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(6, 44);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(180, 20);
            this.txtCode.TabIndex = 0;
            // 
            // pnlBtnsContainer
            // 
            this.pnlBtnsContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBtnsContainer.Controls.Add(this.btnSubmit);
            this.pnlBtnsContainer.Controls.Add(this.BtnCloseForm);
            this.pnlBtnsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtnsContainer.Location = new System.Drawing.Point(0, 470);
            this.pnlBtnsContainer.Name = "pnlBtnsContainer";
            this.pnlBtnsContainer.Size = new System.Drawing.Size(684, 50);
            this.pnlBtnsContainer.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(570, 11);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 25);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Agregar";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // BtnCloseForm
            // 
            this.BtnCloseForm.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCloseForm.FlatAppearance.BorderSize = 0;
            this.BtnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCloseForm.Location = new System.Drawing.Point(10, 11);
            this.BtnCloseForm.Name = "BtnCloseForm";
            this.BtnCloseForm.Size = new System.Drawing.Size(100, 25);
            this.BtnCloseForm.TabIndex = 0;
            this.BtnCloseForm.Text = "Cerrar";
            this.BtnCloseForm.UseVisualStyleBackColor = false;
            this.BtnCloseForm.Click += new System.EventHandler(this.BtnCloseForm_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario Producto";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.pnlBtnsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlBtnsContainer;
        private System.Windows.Forms.Button BtnCloseForm;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pbImage;
    }
}