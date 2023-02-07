
namespace SistemaRecepcionPesos.Vista
{
    partial class VProveedores
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
            this.components = new System.ComponentModel.Container();
            MaterialSkin.Controls.MaterialDivider materialDivider1;
            this.tbProveedores = new MaterialSkin.Controls.MaterialTabControl();
            this.tbProveedor = new System.Windows.Forms.TabPage();
            this.lstProveedores = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuProveedores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardarEditado = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRUC = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbSProveedores = new MaterialSkin.Controls.MaterialTabSelector();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tbProveedores.SuspendLayout();
            this.tbProveedor.SuspendLayout();
            this.mnuProveedores.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialDivider1.Depth = 0;
            materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            materialDivider1.Location = new System.Drawing.Point(2, 450);
            materialDivider1.Margin = new System.Windows.Forms.Padding(2);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new System.Drawing.Size(1188, 19);
            materialDivider1.TabIndex = 15;
            materialDivider1.Text = "materialDivider1";
            // 
            // tbProveedores
            // 
            this.tbProveedores.Controls.Add(this.tbProveedor);
            this.tbProveedores.Depth = 0;
            this.tbProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProveedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProveedores.Location = new System.Drawing.Point(0, 39);
            this.tbProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.tbProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbProveedores.Multiline = true;
            this.tbProveedores.Name = "tbProveedores";
            this.tbProveedores.SelectedIndex = 0;
            this.tbProveedores.Size = new System.Drawing.Size(1200, 749);
            this.tbProveedores.TabIndex = 4;
            // 
            // tbProveedor
            // 
            this.tbProveedor.BackColor = System.Drawing.Color.White;
            this.tbProveedor.Controls.Add(this.lstProveedores);
            this.tbProveedor.Controls.Add(materialDivider1);
            this.tbProveedor.Controls.Add(this.groupBox2);
            this.tbProveedor.Location = new System.Drawing.Point(4, 30);
            this.tbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.tbProveedor.Name = "tbProveedor";
            this.tbProveedor.Padding = new System.Windows.Forms.Padding(2);
            this.tbProveedor.Size = new System.Drawing.Size(1192, 715);
            this.tbProveedor.TabIndex = 0;
            this.tbProveedor.Text = "Proveedores";
            this.tbProveedor.Enter += new System.EventHandler(this.tbProveedor_Enter);
            // 
            // lstProveedores
            // 
            this.lstProveedores.AutoSizeTable = false;
            this.lstProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstProveedores.ContextMenuStrip = this.mnuProveedores;
            this.lstProveedores.Depth = 0;
            this.lstProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProveedores.FullRowSelect = true;
            this.lstProveedores.HideSelection = false;
            this.lstProveedores.Location = new System.Drawing.Point(2, 469);
            this.lstProveedores.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstProveedores.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstProveedores.MouseState = MaterialSkin.MouseState.OUT;
            this.lstProveedores.Name = "lstProveedores";
            this.lstProveedores.OwnerDraw = true;
            this.lstProveedores.Size = new System.Drawing.Size(1188, 244);
            this.lstProveedores.TabIndex = 16;
            this.lstProveedores.UseCompatibleStateImageBehavior = false;
            this.lstProveedores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "RUC";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dirección";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Teléfono";
            this.columnHeader5.Width = 150;
            // 
            // mnuProveedores
            // 
            this.mnuProveedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuProveedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.toolStripSeparator1,
            this.eliminarToolStripMenuItem});
            this.mnuProveedores.Name = "mnuProveedores";
            this.mnuProveedores.Size = new System.Drawing.Size(118, 54);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardarEditado);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.txtRUC);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1188, 448);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnGuardarEditado
            // 
            this.btnGuardarEditado.AutoSize = false;
            this.btnGuardarEditado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarEditado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarEditado.Depth = 0;
            this.btnGuardarEditado.HighEmphasis = true;
            this.btnGuardarEditado.Icon = null;
            this.btnGuardarEditado.Location = new System.Drawing.Point(422, 392);
            this.btnGuardarEditado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardarEditado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarEditado.Name = "btnGuardarEditado";
            this.btnGuardarEditado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardarEditado.Size = new System.Drawing.Size(148, 36);
            this.btnGuardarEditado.TabIndex = 22;
            this.btnGuardarEditado.Text = "Guardar Editado";
            this.btnGuardarEditado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarEditado.UseAccentColor = false;
            this.btnGuardarEditado.UseVisualStyleBackColor = true;
            this.btnGuardarEditado.Click += new System.EventHandler(this.btnGuardarEditado_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(218, 392);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(148, 36);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar Nuevo";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = false;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(21, 392);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Size = new System.Drawing.Size(148, 36);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(143, 308);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(222, 50);
            this.txtTelefono.TabIndex = 19;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(23, 339);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(68, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(143, 240);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(393, 50);
            this.txtDireccion.TabIndex = 17;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(23, 271);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(71, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Dirección:";
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(143, 166);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(307, 50);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(23, 197);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Nombre:";
            // 
            // txtRUC
            // 
            this.txtRUC.AnimateReadOnly = false;
            this.txtRUC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRUC.Depth = 0;
            this.txtRUC.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRUC.LeadingIcon = null;
            this.txtRUC.Location = new System.Drawing.Point(143, 93);
            this.txtRUC.MaxLength = 13;
            this.txtRUC.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRUC.Multiline = false;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(222, 50);
            this.txtRUC.TabIndex = 13;
            this.txtRUC.Text = "";
            this.txtRUC.TrailingIcon = null;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(23, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(35, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "RUC:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(143, 27);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(222, 50);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 58);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Código:";
            // 
            // tbSProveedores
            // 
            this.tbSProveedores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSProveedores.BaseTabControl = this.tbProveedores;
            this.tbSProveedores.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tbSProveedores.Depth = 0;
            this.tbSProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSProveedores.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSProveedores.Location = new System.Drawing.Point(0, 0);
            this.tbSProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.tbSProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSProveedores.Name = "tbSProveedores";
            this.tbSProveedores.Size = new System.Drawing.Size(1200, 39);
            this.tbSProveedores.TabIndex = 3;
            this.tbSProveedores.Text = "materialTabSelector1";
            // 
            // VProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.tbProveedores);
            this.Controls.Add(this.tbSProveedores);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VProveedores";
            this.Text = "VProveedores";
            this.Load += new System.EventHandler(this.VProveedores_Load);
            this.tbProveedores.ResumeLayout(false);
            this.tbProveedor.ResumeLayout(false);
            this.mnuProveedores.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbProveedores;
        private System.Windows.Forms.TabPage tbProveedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTabSelector tbSProveedores;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtRUC;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialListView lstProveedores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip mnuProveedores;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton btnGuardarEditado;
    }
}