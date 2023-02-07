
namespace SistemaRecepcionPesos.Vista
{
    partial class VNuevoConfiguracion
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.txtSerial = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPort = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.txtSerial);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.cmbPort);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(20, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(466, 260);
            this.groupBox2.TabIndex = 2;
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
            this.btnGuardar.Location = new System.Drawing.Point(51, 199);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(119, 36);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.AnimateReadOnly = false;
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerial.Depth = 0;
            this.txtSerial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSerial.LeadingIcon = null;
            this.txtSerial.Location = new System.Drawing.Point(140, 80);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerial.MaxLength = 50;
            this.txtSerial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSerial.Multiline = false;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(180, 50);
            this.txtSerial.TabIndex = 6;
            this.txtSerial.Text = "";
            this.txtSerial.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(39, 106);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(45, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Serial:";
            // 
            // cmbPort
            // 
            this.cmbPort.AutoResize = false;
            this.cmbPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPort.Depth = 0;
            this.cmbPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPort.DropDownHeight = 174;
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.DropDownWidth = 121;
            this.cmbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.IntegralHeight = false;
            this.cmbPort.ItemHeight = 43;
            this.cmbPort.Location = new System.Drawing.Point(140, 26);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPort.MaxDropDownItems = 4;
            this.cmbPort.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(107, 49);
            this.cmbPort.StartIndex = 0;
            this.cmbPort.TabIndex = 4;
            this.cmbPort.Click += new System.EventHandler(this.cmbPort_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(37, 50);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Puerto COM";
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSize = false;
            this.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.HighEmphasis = true;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(266, 199);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(119, 36);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VNuevoConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 305);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VNuevoConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VNuevoConfiguracion";
            this.Load += new System.EventHandler(this.VNuevoConfiguracion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox txtSerial;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmbPort;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
    }
}