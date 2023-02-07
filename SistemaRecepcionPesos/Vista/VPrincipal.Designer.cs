namespace SistemaRecepcionPesos
{
    partial class VPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VPrincipal));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbAcerca = new System.Windows.Forms.TabPage();
            this.tbUsuarios = new System.Windows.Forms.TabPage();
            this.tbRecepcion = new System.Windows.Forms.TabPage();
            this.tbTickets = new System.Windows.Forms.TabPage();
            this.tbProveedores = new System.Windows.Forms.TabPage();
            this.tbMateriales = new System.Windows.Forms.TabPage();
            this.tbConfiguracion = new System.Windows.Forms.TabPage();
            this.tbSalir = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbAcerca);
            this.materialTabControl1.Controls.Add(this.tbUsuarios);
            this.materialTabControl1.Controls.Add(this.tbRecepcion);
            this.materialTabControl1.Controls.Add(this.tbTickets);
            this.materialTabControl1.Controls.Add(this.tbProveedores);
            this.materialTabControl1.Controls.Add(this.tbMateriales);
            this.materialTabControl1.Controls.Add(this.tbConfiguracion);
            this.materialTabControl1.Controls.Add(this.tbSalir);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1197, 733);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tbAcerca
            // 
            this.tbAcerca.ImageKey = "home.png";
            this.tbAcerca.Location = new System.Drawing.Point(4, 39);
            this.tbAcerca.Name = "tbAcerca";
            this.tbAcerca.Size = new System.Drawing.Size(1189, 690);
            this.tbAcerca.TabIndex = 7;
            this.tbAcerca.Text = "Home";
            this.tbAcerca.UseVisualStyleBackColor = true;
            this.tbAcerca.Enter += new System.EventHandler(this.tbAcerca_Enter);
            // 
            // tbUsuarios
            // 
            this.tbUsuarios.ImageKey = "usuarios2.png";
            this.tbUsuarios.Location = new System.Drawing.Point(4, 39);
            this.tbUsuarios.Name = "tbUsuarios";
            this.tbUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsuarios.Size = new System.Drawing.Size(1189, 690);
            this.tbUsuarios.TabIndex = 1;
            this.tbUsuarios.Text = "Usuarios";
            this.tbUsuarios.UseVisualStyleBackColor = true;
            this.tbUsuarios.Enter += new System.EventHandler(this.tbUsuarios_Enter);
            // 
            // tbRecepcion
            // 
            this.tbRecepcion.BackColor = System.Drawing.Color.White;
            this.tbRecepcion.ImageKey = "recepcion.png";
            this.tbRecepcion.Location = new System.Drawing.Point(4, 39);
            this.tbRecepcion.Name = "tbRecepcion";
            this.tbRecepcion.Size = new System.Drawing.Size(1189, 690);
            this.tbRecepcion.TabIndex = 2;
            this.tbRecepcion.Text = "Recepción de pesos";
            this.tbRecepcion.Enter += new System.EventHandler(this.tbRecepcion_Enter);
            // 
            // tbTickets
            // 
            this.tbTickets.ImageKey = "tickets1.png";
            this.tbTickets.Location = new System.Drawing.Point(4, 39);
            this.tbTickets.Name = "tbTickets";
            this.tbTickets.Size = new System.Drawing.Size(1189, 690);
            this.tbTickets.TabIndex = 6;
            this.tbTickets.Text = "Tickets";
            this.tbTickets.UseVisualStyleBackColor = true;
            this.tbTickets.Enter += new System.EventHandler(this.tbTickets_Enter);
            // 
            // tbProveedores
            // 
            this.tbProveedores.ImageKey = "proveedores.png";
            this.tbProveedores.Location = new System.Drawing.Point(4, 39);
            this.tbProveedores.Name = "tbProveedores";
            this.tbProveedores.Size = new System.Drawing.Size(1189, 690);
            this.tbProveedores.TabIndex = 3;
            this.tbProveedores.Text = "Proveedores";
            this.tbProveedores.UseVisualStyleBackColor = true;
            this.tbProveedores.Enter += new System.EventHandler(this.tbProveedores_Enter);
            // 
            // tbMateriales
            // 
            this.tbMateriales.ImageKey = "materiales.png";
            this.tbMateriales.Location = new System.Drawing.Point(4, 39);
            this.tbMateriales.Name = "tbMateriales";
            this.tbMateriales.Size = new System.Drawing.Size(1189, 690);
            this.tbMateriales.TabIndex = 4;
            this.tbMateriales.Text = "Materiales";
            this.tbMateriales.UseVisualStyleBackColor = true;
            this.tbMateriales.Enter += new System.EventHandler(this.tbMateriales_Enter);
            // 
            // tbConfiguracion
            // 
            this.tbConfiguracion.ImageKey = "configuracion3.png";
            this.tbConfiguracion.Location = new System.Drawing.Point(4, 39);
            this.tbConfiguracion.Name = "tbConfiguracion";
            this.tbConfiguracion.Size = new System.Drawing.Size(1189, 690);
            this.tbConfiguracion.TabIndex = 5;
            this.tbConfiguracion.Text = "Configuración";
            this.tbConfiguracion.UseVisualStyleBackColor = true;
            this.tbConfiguracion.Enter += new System.EventHandler(this.tbConfiguracion_Enter);
            // 
            // tbSalir
            // 
            this.tbSalir.ImageKey = "logout.png";
            this.tbSalir.Location = new System.Drawing.Point(4, 39);
            this.tbSalir.Name = "tbSalir";
            this.tbSalir.Size = new System.Drawing.Size(1189, 690);
            this.tbSalir.TabIndex = 8;
            this.tbSalir.Text = "Salir";
            this.tbSalir.Enter += new System.EventHandler(this.tbSalir_Enter);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "configuracion3.png");
            this.imageList1.Images.SetKeyName(1, "informacion.png");
            this.imageList1.Images.SetKeyName(2, "materiales.png");
            this.imageList1.Images.SetKeyName(3, "proveedores.png");
            this.imageList1.Images.SetKeyName(4, "recepcion.png");
            this.imageList1.Images.SetKeyName(5, "tickets1.png");
            this.imageList1.Images.SetKeyName(6, "usuarios2.png");
            this.imageList1.Images.SetKeyName(7, "home.png");
            this.imageList1.Images.SetKeyName(8, "logout.png");
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerWidth = 210;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VPrincipal";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbUsuarios;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tbRecepcion;
        private System.Windows.Forms.TabPage tbTickets;
        private System.Windows.Forms.TabPage tbProveedores;
        private System.Windows.Forms.TabPage tbMateriales;
        private System.Windows.Forms.TabPage tbConfiguracion;
        private System.Windows.Forms.TabPage tbAcerca;
        private System.Windows.Forms.TabPage tbSalir;
    }
}

