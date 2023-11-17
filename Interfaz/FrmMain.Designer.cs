namespace Interfaz
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.btnVerProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelBusquedaContenedor = new System.Windows.Forms.Panel();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboFiltroCriterio = new System.Windows.Forms.ComboBox();
            this.cboFiltroCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelListaProductos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pboProducto = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelBusquedaContenedor.SuspendLayout();
            this.panelListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.verProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 19);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            this.modificarProductoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verProductosToolStripMenuItem.Text = "Ver Productos";
            this.verProductosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verProductosToolStripMenuItem.Click += new System.EventHandler(this.verProductosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btnBusquedaAvanzada);
            this.panel1.Controls.Add(this.btnVerProducto);
            this.panel1.Controls.Add(this.btnEliminarProducto);
            this.panel1.Controls.Add(this.btnModificarProducto);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAgregarProducto);
            this.panel1.Location = new System.Drawing.Point(5, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Image = ((System.Drawing.Image)(resources.GetObject("btnBusquedaAvanzada.Image")));
            this.btnBusquedaAvanzada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(510, 5);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(90, 90);
            this.btnBusquedaAvanzada.TabIndex = 4;
            this.btnBusquedaAvanzada.Text = "Buscar";
            this.btnBusquedaAvanzada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // btnVerProducto
            // 
            this.btnVerProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnVerProducto.Image")));
            this.btnVerProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerProducto.Location = new System.Drawing.Point(399, 5);
            this.btnVerProducto.Name = "btnVerProducto";
            this.btnVerProducto.Padding = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.btnVerProducto.Size = new System.Drawing.Size(90, 90);
            this.btnVerProducto.TabIndex = 3;
            this.btnVerProducto.Text = "Ver Producto";
            this.btnVerProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerProducto.UseVisualStyleBackColor = true;
            this.btnVerProducto.Click += new System.EventHandler(this.btnVerProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.Image")));
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarProducto.Location = new System.Drawing.Point(288, 5);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.btnEliminarProducto.Size = new System.Drawing.Size(90, 90);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarProducto.Image")));
            this.btnModificarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarProducto.Location = new System.Drawing.Point(177, 5);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.btnModificarProducto.Size = new System.Drawing.Size(90, 90);
            this.btnModificarProducto.TabIndex = 1;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(621, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.btnSalir.Size = new System.Drawing.Size(90, 90);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProducto.Location = new System.Drawing.Point(66, 5);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.btnAgregarProducto.Size = new System.Drawing.Size(90, 90);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContenedor.Controls.Add(this.panelBusquedaContenedor);
            this.panelContenedor.Controls.Add(this.panelListaProductos);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.menuStrip1);
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(5);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(784, 657);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelBusquedaContenedor
            // 
            this.panelBusquedaContenedor.Controls.Add(this.btnBusqueda);
            this.panelBusquedaContenedor.Controls.Add(this.txtFiltro);
            this.panelBusquedaContenedor.Controls.Add(this.cboFiltroCriterio);
            this.panelBusquedaContenedor.Controls.Add(this.cboFiltroCampo);
            this.panelBusquedaContenedor.Controls.Add(this.lblFiltro);
            this.panelBusquedaContenedor.Controls.Add(this.lblCriterio);
            this.panelBusquedaContenedor.Controls.Add(this.lblCampo);
            this.panelBusquedaContenedor.Controls.Add(this.label2);
            this.panelBusquedaContenedor.Location = new System.Drawing.Point(5, 135);
            this.panelBusquedaContenedor.Name = "panelBusquedaContenedor";
            this.panelBusquedaContenedor.Size = new System.Drawing.Size(776, 87);
            this.panelBusquedaContenedor.TabIndex = 3;
            this.panelBusquedaContenedor.Visible = false;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(675, 51);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 3;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(512, 51);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(112, 25);
            this.txtFiltro.TabIndex = 2;
            // 
            // cboFiltroCriterio
            // 
            this.cboFiltroCriterio.FormattingEnabled = true;
            this.cboFiltroCriterio.Location = new System.Drawing.Point(267, 51);
            this.cboFiltroCriterio.Name = "cboFiltroCriterio";
            this.cboFiltroCriterio.Size = new System.Drawing.Size(121, 25);
            this.cboFiltroCriterio.TabIndex = 1;
            // 
            // cboFiltroCampo
            // 
            this.cboFiltroCampo.FormattingEnabled = true;
            this.cboFiltroCampo.Location = new System.Drawing.Point(24, 51);
            this.cboFiltroCampo.Name = "cboFiltroCampo";
            this.cboFiltroCampo.Size = new System.Drawing.Size(121, 25);
            this.cboFiltroCampo.TabIndex = 0;
            this.cboFiltroCampo.DropDown += new System.EventHandler(this.cboFiltroCampo_DropDown);
            this.cboFiltroCampo.SelectedIndexChanged += new System.EventHandler(this.cboFiltroCampo_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.ForeColor = System.Drawing.Color.White;
            this.lblFiltro.Location = new System.Drawing.Point(549, 30);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(39, 17);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Filtro";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.ForeColor = System.Drawing.Color.White;
            this.lblCriterio.Location = new System.Drawing.Point(300, 30);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(55, 17);
            this.lblCriterio.TabIndex = 2;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.ForeColor = System.Drawing.Color.White;
            this.lblCampo.Location = new System.Drawing.Point(54, 30);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(60, 17);
            this.lblCampo.TabIndex = 1;
            this.lblCampo.Text = "Campos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Busqueda Avanzada";
            // 
            // panelListaProductos
            // 
            this.panelListaProductos.Controls.Add(this.label1);
            this.panelListaProductos.Controls.Add(this.txtBuscar);
            this.panelListaProductos.Controls.Add(this.dgvProductos);
            this.panelListaProductos.Controls.Add(this.pboProducto);
            this.panelListaProductos.Location = new System.Drawing.Point(3, 228);
            this.panelListaProductos.Name = "panelListaProductos";
            this.panelListaProductos.Size = new System.Drawing.Size(778, 426);
            this.panelListaProductos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Producto";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(9, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(134, 25);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(2, 54);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(546, 369);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_CellMouseDoubleClick);
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // pboProducto
            // 
            this.pboProducto.Location = new System.Drawing.Point(554, 54);
            this.pboProducto.Name = "pboProducto";
            this.pboProducto.Size = new System.Drawing.Size(220, 369);
            this.pboProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboProducto.TabIndex = 1;
            this.pboProducto.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(784, 657);
            this.Controls.Add(this.panelContenedor);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelBusquedaContenedor.ResumeLayout(false);
            this.panelBusquedaContenedor.PerformLayout();
            this.panelListaProductos.ResumeLayout(false);
            this.panelListaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelListaProductos;
        private System.Windows.Forms.PictureBox pboProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Button btnVerProducto;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosToolStripMenuItem;
        private System.Windows.Forms.Panel panelBusquedaContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboFiltroCriterio;
        private System.Windows.Forms.ComboBox cboFiltroCampo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
    }
}

