
namespace SistemaRecepcionPesos.Vista
{
    partial class VMateriales
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
            this.tbMateriales = new MaterialSkin.Controls.MaterialTabControl();
            this.tbMaterial = new System.Windows.Forms.TabPage();
            this.lstMateriales = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuMateriales = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardarEditado = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardarNuevo = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbSMateriales = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbMateriales.SuspendLayout();
            this.tbMaterial.SuspendLayout();
            this.mnuMateriales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMateriales
            // 
            this.tbMateriales.Controls.Add(this.tbMaterial);
            this.tbMateriales.Depth = 0;
            this.tbMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMateriales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMateriales.Location = new System.Drawing.Point(0, 39);
            this.tbMateriales.Margin = new System.Windows.Forms.Padding(2);
            this.tbMateriales.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbMateriales.Multiline = true;
            this.tbMateriales.Name = "tbMateriales";
            this.tbMateriales.SelectedIndex = 0;
            this.tbMateriales.Size = new System.Drawing.Size(1200, 761);
            this.tbMateriales.TabIndex = 4;
            this.tbMateriales.Enter += new System.EventHandler(this.tbMateriales_Enter);
            // 
            // tbMaterial
            // 
            this.tbMaterial.BackColor = System.Drawing.Color.White;
            this.tbMaterial.Controls.Add(this.lstMateriales);
            this.tbMaterial.Controls.Add(this.materialDivider1);
            this.tbMaterial.Controls.Add(this.groupBox2);
            this.tbMaterial.Location = new System.Drawing.Point(4, 37);
            this.tbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Padding = new System.Windows.Forms.Padding(2);
            this.tbMaterial.Size = new System.Drawing.Size(1192, 720);
            this.tbMaterial.TabIndex = 0;
            this.tbMaterial.Text = "Materiales";
            this.tbMaterial.Enter += new System.EventHandler(this.tbMaterial_Enter);
            // 
            // lstMateriales
            // 
            this.lstMateriales.AutoSizeTable = false;
            this.lstMateriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMateriales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstMateriales.ContextMenuStrip = this.mnuMateriales;
            this.lstMateriales.Depth = 0;
            this.lstMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMateriales.FullRowSelect = true;
            this.lstMateriales.HideSelection = false;
            this.lstMateriales.Location = new System.Drawing.Point(2, 201);
            this.lstMateriales.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstMateriales.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstMateriales.MouseState = MaterialSkin.MouseState.OUT;
            this.lstMateriales.Name = "lstMateriales";
            this.lstMateriales.OwnerDraw = true;
            this.lstMateriales.Size = new System.Drawing.Size(1188, 517);
            this.lstMateriales.TabIndex = 5;
            this.lstMateriales.UseCompatibleStateImageBehavior = false;
            this.lstMateriales.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 300;
            // 
            // mnuMateriales
            // 
            this.mnuMateriales.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMateriales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.toolStripSeparator1,
            this.eliminarToolStripMenuItem});
            this.mnuMateriales.Name = "mnuMateriales";
            this.mnuMateriales.Size = new System.Drawing.Size(211, 86);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(2, 182);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(2);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1188, 19);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardarEditado);
            this.groupBox2.Controls.Add(this.btnGuardarNuevo);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1188, 180);
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
            this.btnGuardarEditado.Location = new System.Drawing.Point(412, 110);
            this.btnGuardarEditado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardarEditado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarEditado.Name = "btnGuardarEditado";
            this.btnGuardarEditado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardarEditado.Size = new System.Drawing.Size(148, 36);
            this.btnGuardarEditado.TabIndex = 6;
            this.btnGuardarEditado.Text = "Guardar Editado";
            this.btnGuardarEditado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarEditado.UseAccentColor = false;
            this.btnGuardarEditado.UseVisualStyleBackColor = true;
            this.btnGuardarEditado.Click += new System.EventHandler(this.btnGuardarEditado_Click);
            // 
            // btnGuardarNuevo
            // 
            this.btnGuardarNuevo.AutoSize = false;
            this.btnGuardarNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarNuevo.Depth = 0;
            this.btnGuardarNuevo.HighEmphasis = true;
            this.btnGuardarNuevo.Icon = null;
            this.btnGuardarNuevo.Location = new System.Drawing.Point(214, 110);
            this.btnGuardarNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardarNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarNuevo.Name = "btnGuardarNuevo";
            this.btnGuardarNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardarNuevo.Size = new System.Drawing.Size(148, 36);
            this.btnGuardarNuevo.TabIndex = 5;
            this.btnGuardarNuevo.Text = "Guardar Nuevo";
            this.btnGuardarNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarNuevo.UseAccentColor = false;
            this.btnGuardarNuevo.UseVisualStyleBackColor = true;
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = false;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(17, 110);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Size = new System.Drawing.Size(148, 36);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(135, 27);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 50);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 58);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Nombre:";
            // 
            // tbSMateriales
            // 
            this.tbSMateriales.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSMateriales.BaseTabControl = this.tbMateriales;
            this.tbSMateriales.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tbSMateriales.Depth = 0;
            this.tbSMateriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSMateriales.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSMateriales.Location = new System.Drawing.Point(0, 0);
            this.tbSMateriales.Margin = new System.Windows.Forms.Padding(2);
            this.tbSMateriales.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSMateriales.Name = "tbSMateriales";
            this.tbSMateriales.Size = new System.Drawing.Size(1200, 39);
            this.tbSMateriales.TabIndex = 3;
            // 
            // VMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tbMateriales);
            this.Controls.Add(this.tbSMateriales);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VMateriales";
            this.Text = "VMateriales";
            this.Load += new System.EventHandler(this.VMateriales_Load);
            this.tbMateriales.ResumeLayout(false);
            this.tbMaterial.ResumeLayout(false);
            this.mnuMateriales.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbMateriales;
        private System.Windows.Forms.TabPage tbMaterial;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTabSelector tbSMateriales;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnGuardarNuevo;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialListView lstMateriales;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip mnuMateriales;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton btnGuardarEditado;
    }
}