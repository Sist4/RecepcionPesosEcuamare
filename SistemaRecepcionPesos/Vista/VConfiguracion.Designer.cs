
namespace SistemaRecepcionPesos.Vista
{
    partial class VConfiguracion
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
            this.tbConfiguracion = new MaterialSkin.Controls.MaterialTabControl();
            this.tbBalanzaCamionera = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditarCamionera = new MaterialSkin.Controls.MaterialButton();
            this.btnProbarConexionCamionera = new MaterialSkin.Controls.MaterialButton();
            this.txtMConfiguracionCamionera = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbBalanzaPiso = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditarPiso = new MaterialSkin.Controls.MaterialButton();
            this.btnProbarConexionPiso = new MaterialSkin.Controls.MaterialButton();
            this.txtMConfiguracionPiso = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbSConfiguracion = new MaterialSkin.Controls.MaterialTabSelector();
            this.serialPortCamionera = new System.IO.Ports.SerialPort(this.components);
            this.serialPortPiso = new System.IO.Ports.SerialPort(this.components);
            this.tbConfiguracion.SuspendLayout();
            this.tbBalanzaCamionera.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbBalanzaPiso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbConfiguracion
            // 
            this.tbConfiguracion.Controls.Add(this.tbBalanzaCamionera);
            this.tbConfiguracion.Controls.Add(this.tbBalanzaPiso);
            this.tbConfiguracion.Depth = 0;
            this.tbConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConfiguracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfiguracion.Location = new System.Drawing.Point(0, 49);
            this.tbConfiguracion.Margin = new System.Windows.Forms.Padding(2);
            this.tbConfiguracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbConfiguracion.Multiline = true;
            this.tbConfiguracion.Name = "tbConfiguracion";
            this.tbConfiguracion.SelectedIndex = 0;
            this.tbConfiguracion.Size = new System.Drawing.Size(880, 648);
            this.tbConfiguracion.TabIndex = 4;
            // 
            // tbBalanzaCamionera
            // 
            this.tbBalanzaCamionera.BackColor = System.Drawing.Color.White;
            this.tbBalanzaCamionera.Controls.Add(this.groupBox2);
            this.tbBalanzaCamionera.Location = new System.Drawing.Point(4, 37);
            this.tbBalanzaCamionera.Margin = new System.Windows.Forms.Padding(2);
            this.tbBalanzaCamionera.Name = "tbBalanzaCamionera";
            this.tbBalanzaCamionera.Padding = new System.Windows.Forms.Padding(2);
            this.tbBalanzaCamionera.Size = new System.Drawing.Size(872, 607);
            this.tbBalanzaCamionera.TabIndex = 0;
            this.tbBalanzaCamionera.Text = "Balanza camionera";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditarCamionera);
            this.groupBox2.Controls.Add(this.btnProbarConexionCamionera);
            this.groupBox2.Controls.Add(this.txtMConfiguracionCamionera);
            this.groupBox2.Location = new System.Drawing.Point(33, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(615, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balanza";
            // 
            // btnEditarCamionera
            // 
            this.btnEditarCamionera.AutoSize = false;
            this.btnEditarCamionera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarCamionera.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarCamionera.Depth = 0;
            this.btnEditarCamionera.HighEmphasis = true;
            this.btnEditarCamionera.Icon = null;
            this.btnEditarCamionera.Location = new System.Drawing.Point(26, 238);
            this.btnEditarCamionera.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEditarCamionera.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarCamionera.Name = "btnEditarCamionera";
            this.btnEditarCamionera.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarCamionera.Size = new System.Drawing.Size(119, 36);
            this.btnEditarCamionera.TabIndex = 4;
            this.btnEditarCamionera.Text = "EDITAR CONFIGURACIÓN";
            this.btnEditarCamionera.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarCamionera.UseAccentColor = false;
            this.btnEditarCamionera.UseVisualStyleBackColor = true;
            this.btnEditarCamionera.Click += new System.EventHandler(this.btnEditarCamionera_Click);
            // 
            // btnProbarConexionCamionera
            // 
            this.btnProbarConexionCamionera.AutoSize = false;
            this.btnProbarConexionCamionera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProbarConexionCamionera.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProbarConexionCamionera.Depth = 0;
            this.btnProbarConexionCamionera.HighEmphasis = true;
            this.btnProbarConexionCamionera.Icon = null;
            this.btnProbarConexionCamionera.Location = new System.Drawing.Point(183, 238);
            this.btnProbarConexionCamionera.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnProbarConexionCamionera.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProbarConexionCamionera.Name = "btnProbarConexionCamionera";
            this.btnProbarConexionCamionera.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProbarConexionCamionera.Size = new System.Drawing.Size(119, 36);
            this.btnProbarConexionCamionera.TabIndex = 2;
            this.btnProbarConexionCamionera.Text = "PROBAR CONEXIÓN";
            this.btnProbarConexionCamionera.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProbarConexionCamionera.UseAccentColor = false;
            this.btnProbarConexionCamionera.UseVisualStyleBackColor = true;
            this.btnProbarConexionCamionera.Click += new System.EventHandler(this.btnProbarConexionCamionera_Click);
            // 
            // txtMConfiguracionCamionera
            // 
            this.txtMConfiguracionCamionera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMConfiguracionCamionera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMConfiguracionCamionera.Depth = 0;
            this.txtMConfiguracionCamionera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMConfiguracionCamionera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMConfiguracionCamionera.Location = new System.Drawing.Point(17, 32);
            this.txtMConfiguracionCamionera.Margin = new System.Windows.Forms.Padding(2);
            this.txtMConfiguracionCamionera.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMConfiguracionCamionera.Name = "txtMConfiguracionCamionera";
            this.txtMConfiguracionCamionera.ReadOnly = true;
            this.txtMConfiguracionCamionera.Size = new System.Drawing.Size(376, 199);
            this.txtMConfiguracionCamionera.TabIndex = 3;
            this.txtMConfiguracionCamionera.Text = "Puerto COM: 3\nSerial: 421e3187231823213\nBits por segundo: 9600\nBits de datos: 8\nP" +
    "aridad: Ninguno\nBits de parada: 1\nControl de flujo: Ninguno";
            // 
            // tbBalanzaPiso
            // 
            this.tbBalanzaPiso.Controls.Add(this.groupBox1);
            this.tbBalanzaPiso.Location = new System.Drawing.Point(4, 37);
            this.tbBalanzaPiso.Name = "tbBalanzaPiso";
            this.tbBalanzaPiso.Size = new System.Drawing.Size(872, 607);
            this.tbBalanzaPiso.TabIndex = 1;
            this.tbBalanzaPiso.Text = "Balanza de piso";
            this.tbBalanzaPiso.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditarPiso);
            this.groupBox1.Controls.Add(this.btnProbarConexionPiso);
            this.groupBox1.Controls.Add(this.txtMConfiguracionPiso);
            this.groupBox1.Location = new System.Drawing.Point(31, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(615, 312);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balanza";
            // 
            // btnEditarPiso
            // 
            this.btnEditarPiso.AutoSize = false;
            this.btnEditarPiso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarPiso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarPiso.Depth = 0;
            this.btnEditarPiso.HighEmphasis = true;
            this.btnEditarPiso.Icon = null;
            this.btnEditarPiso.Location = new System.Drawing.Point(26, 250);
            this.btnEditarPiso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEditarPiso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarPiso.Name = "btnEditarPiso";
            this.btnEditarPiso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarPiso.Size = new System.Drawing.Size(119, 36);
            this.btnEditarPiso.TabIndex = 4;
            this.btnEditarPiso.Text = "EDITAR CONFIGURACIÓN";
            this.btnEditarPiso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarPiso.UseAccentColor = false;
            this.btnEditarPiso.UseVisualStyleBackColor = true;
            this.btnEditarPiso.Click += new System.EventHandler(this.btnEditarPiso_Click);
            // 
            // btnProbarConexionPiso
            // 
            this.btnProbarConexionPiso.AutoSize = false;
            this.btnProbarConexionPiso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProbarConexionPiso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProbarConexionPiso.Depth = 0;
            this.btnProbarConexionPiso.HighEmphasis = true;
            this.btnProbarConexionPiso.Icon = null;
            this.btnProbarConexionPiso.Location = new System.Drawing.Point(183, 250);
            this.btnProbarConexionPiso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnProbarConexionPiso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProbarConexionPiso.Name = "btnProbarConexionPiso";
            this.btnProbarConexionPiso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProbarConexionPiso.Size = new System.Drawing.Size(119, 36);
            this.btnProbarConexionPiso.TabIndex = 2;
            this.btnProbarConexionPiso.Text = "PROBAR CONEXIÓN";
            this.btnProbarConexionPiso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProbarConexionPiso.UseAccentColor = false;
            this.btnProbarConexionPiso.UseVisualStyleBackColor = true;
            this.btnProbarConexionPiso.Click += new System.EventHandler(this.btnProbarConexionPiso_Click_1);
            // 
            // txtMConfiguracionPiso
            // 
            this.txtMConfiguracionPiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMConfiguracionPiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMConfiguracionPiso.Depth = 0;
            this.txtMConfiguracionPiso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMConfiguracionPiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMConfiguracionPiso.Location = new System.Drawing.Point(17, 32);
            this.txtMConfiguracionPiso.Margin = new System.Windows.Forms.Padding(2);
            this.txtMConfiguracionPiso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMConfiguracionPiso.Name = "txtMConfiguracionPiso";
            this.txtMConfiguracionPiso.ReadOnly = true;
            this.txtMConfiguracionPiso.Size = new System.Drawing.Size(376, 211);
            this.txtMConfiguracionPiso.TabIndex = 3;
            this.txtMConfiguracionPiso.Text = "Puerto COM: 3\nSerial: 421e3187231823213\nBits por segundo: 9600\nBits de datos: 8\nP" +
    "aridad: Ninguno\nBits de parada: 1\nControl de flujo: Ninguno";
            // 
            // tbSConfiguracion
            // 
            this.tbSConfiguracion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSConfiguracion.BaseTabControl = this.tbConfiguracion;
            this.tbSConfiguracion.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tbSConfiguracion.Depth = 0;
            this.tbSConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSConfiguracion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.tbSConfiguracion.Margin = new System.Windows.Forms.Padding(2);
            this.tbSConfiguracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSConfiguracion.Name = "tbSConfiguracion";
            this.tbSConfiguracion.Size = new System.Drawing.Size(880, 49);
            this.tbSConfiguracion.TabIndex = 3;
            this.tbSConfiguracion.Text = "materialTabSelector1";
            // 
            // VConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 697);
            this.Controls.Add(this.tbConfiguracion);
            this.Controls.Add(this.tbSConfiguracion);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VConfiguracion";
            this.Text = "VConfiguracion";
            this.Load += new System.EventHandler(this.VConfiguracion_Load);
            this.Leave += new System.EventHandler(this.VConfiguracion_Leave);
            this.tbConfiguracion.ResumeLayout(false);
            this.tbBalanzaCamionera.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tbBalanzaPiso.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbConfiguracion;
        private System.Windows.Forms.TabPage tbBalanzaCamionera;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnProbarConexionCamionera;
        private MaterialSkin.Controls.MaterialTabSelector tbSConfiguracion;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtMConfiguracionCamionera;
        private MaterialSkin.Controls.MaterialButton btnEditarCamionera;
        private System.IO.Ports.SerialPort serialPortCamionera;
        private System.IO.Ports.SerialPort serialPortPiso;
        private System.Windows.Forms.TabPage tbBalanzaPiso;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnEditarPiso;
        private MaterialSkin.Controls.MaterialButton btnProbarConexionPiso;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtMConfiguracionPiso;
    }
}