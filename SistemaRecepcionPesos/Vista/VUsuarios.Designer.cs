namespace SistemaRecepcionPesos
{
    partial class VUsuarios
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbSUsuarios = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbUsuarios = new MaterialSkin.Controls.MaterialTabControl();
            this.tbNuevo = new System.Windows.Forms.TabPage();
            this.lstUsuarios = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.cmbRol = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardarEditado = new MaterialSkin.Controls.MaterialButton();
            this.mnuUsuarios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tbUsuarios.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mnuUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialTabControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1102, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(48, 98);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(200, 100);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 74);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbSUsuarios
            // 
            this.tbSUsuarios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSUsuarios.BaseTabControl = this.tbUsuarios;
            this.tbSUsuarios.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tbSUsuarios.Depth = 0;
            this.tbSUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSUsuarios.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tbSUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.tbSUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSUsuarios.Name = "tbSUsuarios";
            this.tbSUsuarios.Size = new System.Drawing.Size(900, 39);
            this.tbSUsuarios.TabIndex = 1;
            this.tbSUsuarios.Text = "materialTabSelector1";
            // 
            // tbUsuarios
            // 
            this.tbUsuarios.Controls.Add(this.tbNuevo);
            this.tbUsuarios.Depth = 0;
            this.tbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuarios.Location = new System.Drawing.Point(0, 39);
            this.tbUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbUsuarios.Multiline = true;
            this.tbUsuarios.Name = "tbUsuarios";
            this.tbUsuarios.SelectedIndex = 0;
            this.tbUsuarios.Size = new System.Drawing.Size(900, 856);
            this.tbUsuarios.TabIndex = 2;
            // 
            // tbNuevo
            // 
            this.tbNuevo.BackColor = System.Drawing.Color.White;
            this.tbNuevo.Controls.Add(this.lstUsuarios);
            this.tbNuevo.Controls.Add(this.materialDivider1);
            this.tbNuevo.Controls.Add(this.groupBox2);
            this.tbNuevo.Location = new System.Drawing.Point(4, 37);
            this.tbNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.tbNuevo.Name = "tbNuevo";
            this.tbNuevo.Padding = new System.Windows.Forms.Padding(2);
            this.tbNuevo.Size = new System.Drawing.Size(892, 815);
            this.tbNuevo.TabIndex = 0;
            this.tbNuevo.Text = "Usuarios";
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.AutoSizeTable = false;
            this.lstUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstUsuarios.ContextMenuStrip = this.mnuUsuarios;
            this.lstUsuarios.Depth = 0;
            this.lstUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsuarios.FullRowSelect = true;
            this.lstUsuarios.HideSelection = false;
            this.lstUsuarios.Location = new System.Drawing.Point(2, 415);
            this.lstUsuarios.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstUsuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstUsuarios.MouseState = MaterialSkin.MouseState.OUT;
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.OwnerDraw = true;
            this.lstUsuarios.Size = new System.Drawing.Size(888, 398);
            this.lstUsuarios.TabIndex = 11;
            this.lstUsuarios.UseCompatibleStateImageBehavior = false;
            this.lstUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Usuario";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombres";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rol";
            this.columnHeader4.Width = 200;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(2, 401);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(888, 14);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardarEditado);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.cmbRol);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(888, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(219, 331);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(148, 36);
            this.btnGuardar.TabIndex = 17;
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
            this.btnLimpiar.Location = new System.Drawing.Point(22, 331);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Size = new System.Drawing.Size(148, 36);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.AutoResize = false;
            this.cmbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRol.Depth = 0;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRol.DropDownHeight = 174;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.DropDownWidth = 121;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.IntegralHeight = false;
            this.cmbRol.ItemHeight = 43;
            this.cmbRol.Items.AddRange(new object[] {
            "Operador",
            "Administrador"});
            this.cmbRol.Location = new System.Drawing.Point(140, 242);
            this.cmbRol.MaxDropDownItems = 4;
            this.cmbRol.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(222, 49);
            this.cmbRol.StartIndex = 0;
            this.cmbRol.TabIndex = 15;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(20, 256);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(28, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Rol:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AnimateReadOnly = false;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseña.LeadingIcon = null;
            this.txtContraseña.Location = new System.Drawing.Point(140, 168);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Password = true;
            this.txtContraseña.Size = new System.Drawing.Size(222, 50);
            this.txtContraseña.TabIndex = 13;
            this.txtContraseña.Text = "";
            this.txtContraseña.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(20, 199);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(86, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(140, 96);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 50);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(20, 128);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Nombre:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(140, 29);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(222, 50);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(20, 60);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Usuario:";
            // 
            // btnGuardarEditado
            // 
            this.btnGuardarEditado.AutoSize = false;
            this.btnGuardarEditado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarEditado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarEditado.Depth = 0;
            this.btnGuardarEditado.HighEmphasis = true;
            this.btnGuardarEditado.Icon = null;
            this.btnGuardarEditado.Location = new System.Drawing.Point(417, 331);
            this.btnGuardarEditado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardarEditado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarEditado.Name = "btnGuardarEditado";
            this.btnGuardarEditado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardarEditado.Size = new System.Drawing.Size(148, 36);
            this.btnGuardarEditado.TabIndex = 18;
            this.btnGuardarEditado.Text = "Guardar Editado";
            this.btnGuardarEditado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarEditado.UseAccentColor = false;
            this.btnGuardarEditado.UseVisualStyleBackColor = true;
            this.btnGuardarEditado.Click += new System.EventHandler(this.btnGuardarEditado_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opEditar,
            this.toolStripSeparator1,
            this.opEliminar});
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(211, 86);
            // 
            // opEditar
            // 
            this.opEditar.Name = "opEditar";
            this.opEditar.Size = new System.Drawing.Size(210, 24);
            this.opEditar.Text = "Editar";
            this.opEditar.Click += new System.EventHandler(this.opEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // opEliminar
            // 
            this.opEliminar.Name = "opEliminar";
            this.opEliminar.Size = new System.Drawing.Size(210, 24);
            this.opEliminar.Text = "Eliminar";
            this.opEliminar.Click += new System.EventHandler(this.opEliminar_Click);
            // 
            // VUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(900, 895);
            this.Controls.Add(this.tbUsuarios);
            this.Controls.Add(this.tbSUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VUsuarios";
            this.Load += new System.EventHandler(this.VUsuarios_Load);
            this.tabPage2.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tbUsuarios.ResumeLayout(false);
            this.tbNuevo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mnuUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector tbSUsuarios;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabControl tbUsuarios;
        private System.Windows.Forms.TabPage tbNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialComboBox cmbRol;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtContraseña;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialListView lstUsuarios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialButton btnGuardarEditado;
        private System.Windows.Forms.ContextMenuStrip mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem opEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opEliminar;
    }
}