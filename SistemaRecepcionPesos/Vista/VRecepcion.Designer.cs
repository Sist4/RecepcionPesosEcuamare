namespace SistemaRecepcionPesos
{
    partial class VRecepcion
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
            this.tbUsuarios = new MaterialSkin.Controls.MaterialTabControl();
            this.tbEntrada = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGuardarEntrada = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiarEntrada = new MaterialSkin.Controls.MaterialButton();
            this.btnObtenerPesoEntrada = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPesoEntrada = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNTicket = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGuia = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbFormaEntrega = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbMaterial = new MaterialSkin.Controls.MaterialComboBox();
            this.txtVehiculo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtConductor = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMProveedor = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtCodigoProveedor = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbSalida = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnGuardarSalida = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiarSalida = new MaterialSkin.Controls.MaterialButton();
            this.btnObtenerPesoSalida = new MaterialSkin.Controls.MaterialButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPesoBrutoSalida = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPesoEntradaSalida = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPesoSalida = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtMTicketSalida = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.cmbTicketSalida = new MaterialSkin.Controls.MaterialComboBox();
            this.tbImpurezas = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnGuardarImpurezas = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiarImpurezas = new MaterialSkin.Controls.MaterialButton();
            this.btnoObtenerPesoImpurezas = new MaterialSkin.Controls.MaterialButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPesoNetoImpurezas = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPesoImpurezas = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPesoNoConformeImpurezas = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPesoBrutoImpurezas = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbMuestra = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMTicketImpurezas = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.cmbTicketImpurezas = new MaterialSkin.Controls.MaterialComboBox();
            this.tbSUsuarios = new MaterialSkin.Controls.MaterialTabSelector();
            this.serialPortCamionera = new System.IO.Ports.SerialPort(this.components);
            this.serialPortPiso = new System.IO.Ports.SerialPort(this.components);
            this.tbUsuarios.SuspendLayout();
            this.tbEntrada.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbSalida.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tbImpurezas.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsuarios
            // 
            this.tbUsuarios.Controls.Add(this.tbEntrada);
            this.tbUsuarios.Controls.Add(this.tbSalida);
            this.tbUsuarios.Controls.Add(this.tbImpurezas);
            this.tbUsuarios.Depth = 0;
            this.tbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuarios.Location = new System.Drawing.Point(0, 38);
            this.tbUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbUsuarios.Multiline = true;
            this.tbUsuarios.Name = "tbUsuarios";
            this.tbUsuarios.SelectedIndex = 0;
            this.tbUsuarios.Size = new System.Drawing.Size(1600, 932);
            this.tbUsuarios.TabIndex = 4;
            // 
            // tbEntrada
            // 
            this.tbEntrada.AutoScroll = true;
            this.tbEntrada.BackColor = System.Drawing.Color.White;
            this.tbEntrada.Controls.Add(this.groupBox4);
            this.tbEntrada.Controls.Add(this.groupBox3);
            this.tbEntrada.Controls.Add(this.lblNTicket);
            this.tbEntrada.Controls.Add(this.label5);
            this.tbEntrada.Controls.Add(this.groupBox2);
            this.tbEntrada.Controls.Add(this.groupBox1);
            this.tbEntrada.Location = new System.Drawing.Point(4, 37);
            this.tbEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEntrada.Size = new System.Drawing.Size(1592, 891);
            this.tbEntrada.TabIndex = 0;
            this.tbEntrada.Text = "Entrada";
            this.tbEntrada.Enter += new System.EventHandler(this.tbEntrada_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGuardarEntrada);
            this.groupBox4.Controls.Add(this.btnLimpiarEntrada);
            this.groupBox4.Controls.Add(this.btnObtenerPesoEntrada);
            this.groupBox4.Location = new System.Drawing.Point(280, 811);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(903, 135);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // btnGuardarEntrada
            // 
            this.btnGuardarEntrada.AutoSize = false;
            this.btnGuardarEntrada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarEntrada.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarEntrada.Depth = 0;
            this.btnGuardarEntrada.HighEmphasis = true;
            this.btnGuardarEntrada.Icon = null;
            this.btnGuardarEntrada.Location = new System.Drawing.Point(609, 60);
            this.btnGuardarEntrada.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnGuardarEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarEntrada.Name = "btnGuardarEntrada";
            this.btnGuardarEntrada.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardarEntrada.Size = new System.Drawing.Size(219, 44);
            this.btnGuardarEntrada.TabIndex = 2;
            this.btnGuardarEntrada.Text = "Guardar";
            this.btnGuardarEntrada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarEntrada.UseAccentColor = false;
            this.btnGuardarEntrada.UseVisualStyleBackColor = true;
            this.btnGuardarEntrada.Click += new System.EventHandler(this.btnGuardarEntrada_Click);
            // 
            // btnLimpiarEntrada
            // 
            this.btnLimpiarEntrada.AutoSize = false;
            this.btnLimpiarEntrada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiarEntrada.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiarEntrada.Depth = 0;
            this.btnLimpiarEntrada.HighEmphasis = true;
            this.btnLimpiarEntrada.Icon = null;
            this.btnLimpiarEntrada.Location = new System.Drawing.Point(341, 60);
            this.btnLimpiarEntrada.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLimpiarEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiarEntrada.Name = "btnLimpiarEntrada";
            this.btnLimpiarEntrada.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiarEntrada.Size = new System.Drawing.Size(219, 44);
            this.btnLimpiarEntrada.TabIndex = 1;
            this.btnLimpiarEntrada.Text = "Limpiar";
            this.btnLimpiarEntrada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiarEntrada.UseAccentColor = false;
            this.btnLimpiarEntrada.UseVisualStyleBackColor = true;
            this.btnLimpiarEntrada.Click += new System.EventHandler(this.btnLimpiarEntrada_Click);
            // 
            // btnObtenerPesoEntrada
            // 
            this.btnObtenerPesoEntrada.AutoSize = false;
            this.btnObtenerPesoEntrada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnObtenerPesoEntrada.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnObtenerPesoEntrada.Depth = 0;
            this.btnObtenerPesoEntrada.HighEmphasis = true;
            this.btnObtenerPesoEntrada.Icon = null;
            this.btnObtenerPesoEntrada.Location = new System.Drawing.Point(76, 60);
            this.btnObtenerPesoEntrada.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnObtenerPesoEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnObtenerPesoEntrada.Name = "btnObtenerPesoEntrada";
            this.btnObtenerPesoEntrada.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnObtenerPesoEntrada.Size = new System.Drawing.Size(219, 44);
            this.btnObtenerPesoEntrada.TabIndex = 0;
            this.btnObtenerPesoEntrada.Text = "Obtener peso";
            this.btnObtenerPesoEntrada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnObtenerPesoEntrada.UseAccentColor = false;
            this.btnObtenerPesoEntrada.UseVisualStyleBackColor = true;
            this.btnObtenerPesoEntrada.Click += new System.EventHandler(this.btnObtenerPesoEntrada_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPesoEntrada);
            this.groupBox3.Controls.Add(this.materialLabel11);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(51, 660);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1343, 123);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesaje";
            // 
            // txtPesoEntrada
            // 
            this.txtPesoEntrada.AnimateReadOnly = false;
            this.txtPesoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoEntrada.Depth = 0;
            this.txtPesoEntrada.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesoEntrada.LeadingIcon = null;
            this.txtPesoEntrada.Location = new System.Drawing.Point(257, 41);
            this.txtPesoEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesoEntrada.MaxLength = 50;
            this.txtPesoEntrada.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoEntrada.Multiline = false;
            this.txtPesoEntrada.Name = "txtPesoEntrada";
            this.txtPesoEntrada.ReadOnly = true;
            this.txtPesoEntrada.Size = new System.Drawing.Size(157, 50);
            this.txtPesoEntrada.TabIndex = 6;
            this.txtPesoEntrada.Text = "";
            this.txtPesoEntrada.TrailingIcon = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(21, 68);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(119, 19);
            this.materialLabel11.TabIndex = 5;
            this.materialLabel11.Text = "Peso de entrada:";
            // 
            // lblNTicket
            // 
            this.lblNTicket.AutoSize = true;
            this.lblNTicket.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTicket.Location = new System.Drawing.Point(184, 15);
            this.lblNTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNTicket.Name = "lblNTicket";
            this.lblNTicket.Size = new System.Drawing.Size(149, 41);
            this.lblNTicket.TabIndex = 3;
            this.lblNTicket.Text = "2023-001";
            this.lblNTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 41);
            this.label5.TabIndex = 2;
            this.label5.Text = "TICKET #";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGuia);
            this.groupBox2.Controls.Add(this.cmbFormaEntrega);
            this.groupBox2.Controls.Add(this.cmbMaterial);
            this.groupBox2.Controls.Add(this.txtVehiculo);
            this.groupBox2.Controls.Add(this.txtConductor);
            this.groupBox2.Controls.Add(this.materialLabel10);
            this.groupBox2.Controls.Add(this.materialLabel9);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(51, 318);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1345, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transportista";
            // 
            // txtGuia
            // 
            this.txtGuia.AnimateReadOnly = false;
            this.txtGuia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGuia.Depth = 0;
            this.txtGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuia.HideSelection = true;
            this.txtGuia.LeadingIcon = null;
            this.txtGuia.Location = new System.Drawing.Point(903, 124);
            this.txtGuia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGuia.MaxLength = 20;
            this.txtGuia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.PasswordChar = '\0';
            this.txtGuia.PrefixSuffixText = null;
            this.txtGuia.ReadOnly = false;
            this.txtGuia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGuia.SelectedText = "";
            this.txtGuia.SelectionLength = 0;
            this.txtGuia.SelectionStart = 0;
            this.txtGuia.ShortcutsEnabled = true;
            this.txtGuia.Size = new System.Drawing.Size(280, 48);
            this.txtGuia.TabIndex = 9;
            this.txtGuia.TabStop = false;
            this.txtGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGuia.TrailingIcon = null;
            this.txtGuia.UseSystemPasswordChar = false;
            // 
            // cmbFormaEntrega
            // 
            this.cmbFormaEntrega.AutoResize = false;
            this.cmbFormaEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbFormaEntrega.Depth = 0;
            this.cmbFormaEntrega.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbFormaEntrega.DropDownHeight = 174;
            this.cmbFormaEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaEntrega.DropDownWidth = 121;
            this.cmbFormaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbFormaEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbFormaEntrega.FormattingEnabled = true;
            this.cmbFormaEntrega.IntegralHeight = false;
            this.cmbFormaEntrega.ItemHeight = 43;
            this.cmbFormaEntrega.Items.AddRange(new object[] {
            "Granel",
            "Pacas"});
            this.cmbFormaEntrega.Location = new System.Drawing.Point(257, 214);
            this.cmbFormaEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFormaEntrega.MaxDropDownItems = 4;
            this.cmbFormaEntrega.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbFormaEntrega.Name = "cmbFormaEntrega";
            this.cmbFormaEntrega.Size = new System.Drawing.Size(376, 49);
            this.cmbFormaEntrega.StartIndex = 0;
            this.cmbFormaEntrega.TabIndex = 8;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.AutoResize = false;
            this.cmbMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMaterial.Depth = 0;
            this.cmbMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMaterial.DropDownHeight = 174;
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.DropDownWidth = 121;
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.IntegralHeight = false;
            this.cmbMaterial.ItemHeight = 43;
            this.cmbMaterial.Location = new System.Drawing.Point(257, 124);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMaterial.MaxDropDownItems = 4;
            this.cmbMaterial.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(376, 49);
            this.cmbMaterial.StartIndex = 0;
            this.cmbMaterial.TabIndex = 7;
            this.cmbMaterial.Click += new System.EventHandler(this.cmbMaterial_Click);
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.AnimateReadOnly = false;
            this.txtVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVehiculo.Depth = 0;
            this.txtVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVehiculo.HideSelection = true;
            this.txtVehiculo.LeadingIcon = null;
            this.txtVehiculo.Location = new System.Drawing.Point(903, 39);
            this.txtVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVehiculo.MaxLength = 10;
            this.txtVehiculo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.PasswordChar = '\0';
            this.txtVehiculo.PrefixSuffixText = null;
            this.txtVehiculo.ReadOnly = false;
            this.txtVehiculo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVehiculo.SelectedText = "";
            this.txtVehiculo.SelectionLength = 0;
            this.txtVehiculo.SelectionStart = 0;
            this.txtVehiculo.ShortcutsEnabled = true;
            this.txtVehiculo.Size = new System.Drawing.Size(280, 48);
            this.txtVehiculo.TabIndex = 6;
            this.txtVehiculo.TabStop = false;
            this.txtVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVehiculo.TrailingIcon = null;
            this.txtVehiculo.UseSystemPasswordChar = false;
            // 
            // txtConductor
            // 
            this.txtConductor.AnimateReadOnly = false;
            this.txtConductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConductor.Depth = 0;
            this.txtConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConductor.HideSelection = true;
            this.txtConductor.LeadingIcon = null;
            this.txtConductor.Location = new System.Drawing.Point(257, 39);
            this.txtConductor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConductor.MaxLength = 32767;
            this.txtConductor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.PasswordChar = '\0';
            this.txtConductor.PrefixSuffixText = null;
            this.txtConductor.ReadOnly = false;
            this.txtConductor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConductor.SelectedText = "";
            this.txtConductor.SelectionLength = 0;
            this.txtConductor.SelectionStart = 0;
            this.txtConductor.ShortcutsEnabled = true;
            this.txtConductor.Size = new System.Drawing.Size(377, 48);
            this.txtConductor.TabIndex = 5;
            this.txtConductor.TabStop = false;
            this.txtConductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConductor.TrailingIcon = null;
            this.txtConductor.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(20, 234);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(129, 19);
            this.materialLabel10.TabIndex = 4;
            this.materialLabel10.Text = "Forma de entrega:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(696, 146);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(84, 19);
            this.materialLabel9.TabIndex = 3;
            this.materialLabel9.Text = "N# de Guía:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(24, 146);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(63, 19);
            this.materialLabel8.TabIndex = 2;
            this.materialLabel8.Text = "Material:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(696, 59);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(133, 19);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "Placa del vehículo:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(20, 59);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(161, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Nombre del conductor:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtMProveedor);
            this.groupBox1.Controls.Add(this.txtCodigoProveedor);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1343, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // txtMProveedor
            // 
            this.txtMProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMProveedor.Depth = 0;
            this.txtMProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMProveedor.Location = new System.Drawing.Point(357, 31);
            this.txtMProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMProveedor.Name = "txtMProveedor";
            this.txtMProveedor.Size = new System.Drawing.Size(955, 144);
            this.txtMProveedor.TabIndex = 9;
            this.txtMProveedor.TabStop = false;
            this.txtMProveedor.Text = "";
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.AnimateReadOnly = false;
            this.txtCodigoProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodigoProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigoProveedor.Depth = 0;
            this.txtCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoProveedor.HideSelection = true;
            this.txtCodigoProveedor.Hint = "Codigo del proveedor";
            this.txtCodigoProveedor.LeadingIcon = null;
            this.txtCodigoProveedor.Location = new System.Drawing.Point(23, 89);
            this.txtCodigoProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoProveedor.MaxLength = 32767;
            this.txtCodigoProveedor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.PasswordChar = '\0';
            this.txtCodigoProveedor.PrefixSuffixText = null;
            this.txtCodigoProveedor.ReadOnly = false;
            this.txtCodigoProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigoProveedor.SelectedText = "";
            this.txtCodigoProveedor.SelectionLength = 0;
            this.txtCodigoProveedor.SelectionStart = 0;
            this.txtCodigoProveedor.ShortcutsEnabled = true;
            this.txtCodigoProveedor.Size = new System.Drawing.Size(315, 48);
            this.txtCodigoProveedor.TabIndex = 1;
            this.txtCodigoProveedor.TabStop = false;
            this.txtCodigoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoProveedor.TrailingIcon = null;
            this.txtCodigoProveedor.UseSystemPasswordChar = false;
            this.txtCodigoProveedor.TextChanged += new System.EventHandler(this.txtCodigoProveedor_TextChanged);
            // 
            // tbSalida
            // 
            this.tbSalida.BackColor = System.Drawing.Color.White;
            this.tbSalida.Controls.Add(this.groupBox10);
            this.tbSalida.Controls.Add(this.groupBox9);
            this.tbSalida.Controls.Add(this.groupBox8);
            this.tbSalida.Location = new System.Drawing.Point(4, 37);
            this.tbSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSalida.Name = "tbSalida";
            this.tbSalida.Size = new System.Drawing.Size(1592, 891);
            this.tbSalida.TabIndex = 2;
            this.tbSalida.Text = "Salida";
            this.tbSalida.Enter += new System.EventHandler(this.tbSalida_Enter);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnGuardarSalida);
            this.groupBox10.Controls.Add(this.btnLimpiarSalida);
            this.groupBox10.Controls.Add(this.btnObtenerPesoSalida);
            this.groupBox10.Location = new System.Drawing.Point(224, 613);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Size = new System.Drawing.Size(903, 135);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            // 
            // btnGuardarSalida
            // 
            this.btnGuardarSalida.AutoSize = false;
            this.btnGuardarSalida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarSalida.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarSalida.Depth = 0;
            this.btnGuardarSalida.HighEmphasis = true;
            this.btnGuardarSalida.Icon = null;
            this.btnGuardarSalida.Location = new System.Drawing.Point(609, 60);
            this.btnGuardarSalida.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnGuardarSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarSalida.Name = "btnGuardarSalida";
            this.btnGuardarSalida.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardarSalida.Size = new System.Drawing.Size(219, 44);
            this.btnGuardarSalida.TabIndex = 2;
            this.btnGuardarSalida.Text = "Guardar";
            this.btnGuardarSalida.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarSalida.UseAccentColor = false;
            this.btnGuardarSalida.UseVisualStyleBackColor = true;
            this.btnGuardarSalida.Click += new System.EventHandler(this.btnGuardarSalida_Click);
            // 
            // btnLimpiarSalida
            // 
            this.btnLimpiarSalida.AutoSize = false;
            this.btnLimpiarSalida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiarSalida.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiarSalida.Depth = 0;
            this.btnLimpiarSalida.HighEmphasis = true;
            this.btnLimpiarSalida.Icon = null;
            this.btnLimpiarSalida.Location = new System.Drawing.Point(341, 60);
            this.btnLimpiarSalida.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLimpiarSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiarSalida.Name = "btnLimpiarSalida";
            this.btnLimpiarSalida.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiarSalida.Size = new System.Drawing.Size(219, 44);
            this.btnLimpiarSalida.TabIndex = 1;
            this.btnLimpiarSalida.Text = "Limpiar";
            this.btnLimpiarSalida.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiarSalida.UseAccentColor = false;
            this.btnLimpiarSalida.UseVisualStyleBackColor = true;
            this.btnLimpiarSalida.Click += new System.EventHandler(this.btnLimpiarSalida_Click);
            // 
            // btnObtenerPesoSalida
            // 
            this.btnObtenerPesoSalida.AutoSize = false;
            this.btnObtenerPesoSalida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnObtenerPesoSalida.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnObtenerPesoSalida.Depth = 0;
            this.btnObtenerPesoSalida.HighEmphasis = true;
            this.btnObtenerPesoSalida.Icon = null;
            this.btnObtenerPesoSalida.Location = new System.Drawing.Point(76, 60);
            this.btnObtenerPesoSalida.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnObtenerPesoSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnObtenerPesoSalida.Name = "btnObtenerPesoSalida";
            this.btnObtenerPesoSalida.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnObtenerPesoSalida.Size = new System.Drawing.Size(219, 44);
            this.btnObtenerPesoSalida.TabIndex = 0;
            this.btnObtenerPesoSalida.Text = "Obtener peso";
            this.btnObtenerPesoSalida.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnObtenerPesoSalida.UseAccentColor = false;
            this.btnObtenerPesoSalida.UseVisualStyleBackColor = true;
            this.btnObtenerPesoSalida.Click += new System.EventHandler(this.btnObtenerPesoSalida_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.materialLabel3);
            this.groupBox9.Controls.Add(this.txtPesoBrutoSalida);
            this.groupBox9.Controls.Add(this.txtPesoEntradaSalida);
            this.groupBox9.Controls.Add(this.txtPesoSalida);
            this.groupBox9.Controls.Add(this.materialLabel26);
            this.groupBox9.Controls.Add(this.materialLabel25);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(28, 297);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(1343, 288);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Pesaje";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(40, 226);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Peso bruto:";
            // 
            // txtPesoBrutoSalida
            // 
            this.txtPesoBrutoSalida.AnimateReadOnly = false;
            this.txtPesoBrutoSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoBrutoSalida.Depth = 0;
            this.txtPesoBrutoSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtPesoBrutoSalida.LeadingIcon = null;
            this.txtPesoBrutoSalida.Location = new System.Drawing.Point(299, 194);
            this.txtPesoBrutoSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesoBrutoSalida.MaxLength = 50;
            this.txtPesoBrutoSalida.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoBrutoSalida.Multiline = false;
            this.txtPesoBrutoSalida.Name = "txtPesoBrutoSalida";
            this.txtPesoBrutoSalida.ReadOnly = true;
            this.txtPesoBrutoSalida.Size = new System.Drawing.Size(133, 50);
            this.txtPesoBrutoSalida.TabIndex = 12;
            this.txtPesoBrutoSalida.Text = "0";
            this.txtPesoBrutoSalida.TrailingIcon = null;
            // 
            // txtPesoEntradaSalida
            // 
            this.txtPesoEntradaSalida.AnimateReadOnly = false;
            this.txtPesoEntradaSalida.BackColor = System.Drawing.Color.White;
            this.txtPesoEntradaSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoEntradaSalida.Depth = 0;
            this.txtPesoEntradaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtPesoEntradaSalida.LeadingIcon = null;
            this.txtPesoEntradaSalida.Location = new System.Drawing.Point(299, 46);
            this.txtPesoEntradaSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesoEntradaSalida.MaxLength = 50;
            this.txtPesoEntradaSalida.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoEntradaSalida.Multiline = false;
            this.txtPesoEntradaSalida.Name = "txtPesoEntradaSalida";
            this.txtPesoEntradaSalida.ReadOnly = true;
            this.txtPesoEntradaSalida.Size = new System.Drawing.Size(133, 50);
            this.txtPesoEntradaSalida.TabIndex = 11;
            this.txtPesoEntradaSalida.Text = "0";
            this.txtPesoEntradaSalida.TrailingIcon = null;
            // 
            // txtPesoSalida
            // 
            this.txtPesoSalida.AnimateReadOnly = false;
            this.txtPesoSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoSalida.Depth = 0;
            this.txtPesoSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtPesoSalida.LeadingIcon = null;
            this.txtPesoSalida.Location = new System.Drawing.Point(299, 119);
            this.txtPesoSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesoSalida.MaxLength = 50;
            this.txtPesoSalida.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoSalida.Multiline = false;
            this.txtPesoSalida.Name = "txtPesoSalida";
            this.txtPesoSalida.ReadOnly = true;
            this.txtPesoSalida.Size = new System.Drawing.Size(133, 50);
            this.txtPesoSalida.TabIndex = 10;
            this.txtPesoSalida.Text = "0";
            this.txtPesoSalida.TrailingIcon = null;
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.Location = new System.Drawing.Point(40, 78);
            this.materialLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(119, 19);
            this.materialLabel26.TabIndex = 7;
            this.materialLabel26.Text = "Peso de entrada:";
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.Location = new System.Drawing.Point(40, 150);
            this.materialLabel25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(108, 19);
            this.materialLabel25.TabIndex = 6;
            this.materialLabel25.Text = "Peso de salida:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtMTicketSalida);
            this.groupBox8.Controls.Add(this.cmbTicketSalida);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(28, 28);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(1343, 238);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ticket";
            // 
            // txtMTicketSalida
            // 
            this.txtMTicketSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMTicketSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMTicketSalida.Depth = 0;
            this.txtMTicketSalida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMTicketSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMTicketSalida.Location = new System.Drawing.Point(383, 26);
            this.txtMTicketSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMTicketSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMTicketSalida.Name = "txtMTicketSalida";
            this.txtMTicketSalida.ReadOnly = true;
            this.txtMTicketSalida.Size = new System.Drawing.Size(935, 165);
            this.txtMTicketSalida.TabIndex = 7;
            this.txtMTicketSalida.TabStop = false;
            this.txtMTicketSalida.Text = "";
            // 
            // cmbTicketSalida
            // 
            this.cmbTicketSalida.AutoResize = false;
            this.cmbTicketSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTicketSalida.Depth = 0;
            this.cmbTicketSalida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTicketSalida.DropDownHeight = 174;
            this.cmbTicketSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketSalida.DropDownWidth = 121;
            this.cmbTicketSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTicketSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTicketSalida.FormattingEnabled = true;
            this.cmbTicketSalida.Hint = "Número de ticket";
            this.cmbTicketSalida.IntegralHeight = false;
            this.cmbTicketSalida.ItemHeight = 43;
            this.cmbTicketSalida.Location = new System.Drawing.Point(43, 81);
            this.cmbTicketSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTicketSalida.MaxDropDownItems = 4;
            this.cmbTicketSalida.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTicketSalida.Name = "cmbTicketSalida";
            this.cmbTicketSalida.Size = new System.Drawing.Size(308, 49);
            this.cmbTicketSalida.StartIndex = 0;
            this.cmbTicketSalida.TabIndex = 6;
            this.cmbTicketSalida.SelectedIndexChanged += new System.EventHandler(this.cmbTicketSalida_SelectedIndexChanged);
            this.cmbTicketSalida.Click += new System.EventHandler(this.cmbTicketSalida_Click);
            // 
            // tbImpurezas
            // 
            this.tbImpurezas.BackColor = System.Drawing.Color.White;
            this.tbImpurezas.Controls.Add(this.groupBox7);
            this.tbImpurezas.Controls.Add(this.groupBox6);
            this.tbImpurezas.Controls.Add(this.groupBox5);
            this.tbImpurezas.Location = new System.Drawing.Point(4, 37);
            this.tbImpurezas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbImpurezas.Name = "tbImpurezas";
            this.tbImpurezas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbImpurezas.Size = new System.Drawing.Size(1592, 891);
            this.tbImpurezas.TabIndex = 1;
            this.tbImpurezas.Text = "Impurezas";
            this.tbImpurezas.Enter += new System.EventHandler(this.tbImpurezas_Enter);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnGuardarImpurezas);
            this.groupBox7.Controls.Add(this.btnLimpiarImpurezas);
            this.groupBox7.Controls.Add(this.btnoObtenerPesoImpurezas);
            this.groupBox7.Location = new System.Drawing.Point(223, 633);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(903, 135);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // btnGuardarImpurezas
            // 
            this.btnGuardarImpurezas.AutoSize = false;
            this.btnGuardarImpurezas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarImpurezas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarImpurezas.Depth = 0;
            this.btnGuardarImpurezas.HighEmphasis = true;
            this.btnGuardarImpurezas.Icon = null;
            this.btnGuardarImpurezas.Location = new System.Drawing.Point(609, 60);
            this.btnGuardarImpurezas.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnGuardarImpurezas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarImpurezas.Name = "btnGuardarImpurezas";
            this.btnGuardarImpurezas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardarImpurezas.Size = new System.Drawing.Size(219, 44);
            this.btnGuardarImpurezas.TabIndex = 2;
            this.btnGuardarImpurezas.Text = "Guardar";
            this.btnGuardarImpurezas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarImpurezas.UseAccentColor = false;
            this.btnGuardarImpurezas.UseVisualStyleBackColor = true;
            this.btnGuardarImpurezas.Click += new System.EventHandler(this.btnGuardarImpurezas_Click);
            // 
            // btnLimpiarImpurezas
            // 
            this.btnLimpiarImpurezas.AutoSize = false;
            this.btnLimpiarImpurezas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiarImpurezas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiarImpurezas.Depth = 0;
            this.btnLimpiarImpurezas.HighEmphasis = true;
            this.btnLimpiarImpurezas.Icon = null;
            this.btnLimpiarImpurezas.Location = new System.Drawing.Point(341, 60);
            this.btnLimpiarImpurezas.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLimpiarImpurezas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiarImpurezas.Name = "btnLimpiarImpurezas";
            this.btnLimpiarImpurezas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiarImpurezas.Size = new System.Drawing.Size(219, 44);
            this.btnLimpiarImpurezas.TabIndex = 1;
            this.btnLimpiarImpurezas.Text = "Limpiar";
            this.btnLimpiarImpurezas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiarImpurezas.UseAccentColor = false;
            this.btnLimpiarImpurezas.UseVisualStyleBackColor = true;
            this.btnLimpiarImpurezas.Click += new System.EventHandler(this.btnLimpiarImpurezas_Click);
            // 
            // btnoObtenerPesoImpurezas
            // 
            this.btnoObtenerPesoImpurezas.AutoSize = false;
            this.btnoObtenerPesoImpurezas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnoObtenerPesoImpurezas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnoObtenerPesoImpurezas.Depth = 0;
            this.btnoObtenerPesoImpurezas.HighEmphasis = true;
            this.btnoObtenerPesoImpurezas.Icon = null;
            this.btnoObtenerPesoImpurezas.Location = new System.Drawing.Point(76, 60);
            this.btnoObtenerPesoImpurezas.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnoObtenerPesoImpurezas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnoObtenerPesoImpurezas.Name = "btnoObtenerPesoImpurezas";
            this.btnoObtenerPesoImpurezas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnoObtenerPesoImpurezas.Size = new System.Drawing.Size(219, 44);
            this.btnoObtenerPesoImpurezas.TabIndex = 0;
            this.btnoObtenerPesoImpurezas.Text = "Obtener peso";
            this.btnoObtenerPesoImpurezas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnoObtenerPesoImpurezas.UseAccentColor = false;
            this.btnoObtenerPesoImpurezas.UseVisualStyleBackColor = true;
            this.btnoObtenerPesoImpurezas.Click += new System.EventHandler(this.btnoObtenerPesoImpurezas_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPesoNetoImpurezas);
            this.groupBox6.Controls.Add(this.materialLabel2);
            this.groupBox6.Controls.Add(this.txtPesoImpurezas);
            this.groupBox6.Controls.Add(this.materialLabel1);
            this.groupBox6.Controls.Add(this.txtPesoNoConformeImpurezas);
            this.groupBox6.Controls.Add(this.txtPesoBrutoImpurezas);
            this.groupBox6.Controls.Add(this.cmbMuestra);
            this.groupBox6.Controls.Add(this.materialLabel19);
            this.groupBox6.Controls.Add(this.materialLabel18);
            this.groupBox6.Controls.Add(this.materialLabel17);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(28, 303);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(1343, 298);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pesaje";
            // 
            // txtPesoNetoImpurezas
            // 
            this.txtPesoNetoImpurezas.AnimateReadOnly = false;
            this.txtPesoNetoImpurezas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoNetoImpurezas.Depth = 0;
            this.txtPesoNetoImpurezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtPesoNetoImpurezas.LeadingIcon = null;
            this.txtPesoNetoImpurezas.Location = new System.Drawing.Point(248, 218);
            this.txtPesoNetoImpurezas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesoNetoImpurezas.MaxLength = 50;
            this.txtPesoNetoImpurezas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoNetoImpurezas.Multiline = false;
            this.txtPesoNetoImpurezas.Name = "txtPesoNetoImpurezas";
            this.txtPesoNetoImpurezas.ReadOnly = true;
            this.txtPesoNetoImpurezas.Size = new System.Drawing.Size(133, 50);
            this.txtPesoNetoImpurezas.TabIndex = 9;
            this.txtPesoNetoImpurezas.Text = "0";
            this.txtPesoNetoImpurezas.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(40, 233);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Peso neto:";
            // 
            // txtPesoImpurezas
            // 
            this.txtPesoImpurezas.AnimateReadOnly = false;
            this.txtPesoImpurezas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoImpurezas.Depth = 0;
            this.txtPesoImpurezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtPesoImpurezas.LeadingIcon = null;
            this.txtPesoImpurezas.Location = new System.Drawing.Point(827, 49);
            this.txtPesoImpurezas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesoImpurezas.MaxLength = 50;
            this.txtPesoImpurezas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoImpurezas.Multiline = false;
            this.txtPesoImpurezas.Name = "txtPesoImpurezas";
            this.txtPesoImpurezas.ReadOnly = true;
            this.txtPesoImpurezas.Size = new System.Drawing.Size(133, 50);
            this.txtPesoImpurezas.TabIndex = 7;
            this.txtPesoImpurezas.Text = "0";
            this.txtPesoImpurezas.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(616, 73);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Peso de impurezas:";
            // 
            // txtPesoNoConformeImpurezas
            // 
            this.txtPesoNoConformeImpurezas.AnimateReadOnly = false;
            this.txtPesoNoConformeImpurezas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoNoConformeImpurezas.Depth = 0;
            this.txtPesoNoConformeImpurezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtPesoNoConformeImpurezas.LeadingIcon = null;
            this.txtPesoNoConformeImpurezas.Location = new System.Drawing.Point(248, 132);
            this.txtPesoNoConformeImpurezas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesoNoConformeImpurezas.MaxLength = 50;
            this.txtPesoNoConformeImpurezas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoNoConformeImpurezas.Multiline = false;
            this.txtPesoNoConformeImpurezas.Name = "txtPesoNoConformeImpurezas";
            this.txtPesoNoConformeImpurezas.ReadOnly = true;
            this.txtPesoNoConformeImpurezas.Size = new System.Drawing.Size(133, 50);
            this.txtPesoNoConformeImpurezas.TabIndex = 5;
            this.txtPesoNoConformeImpurezas.Text = "0";
            this.txtPesoNoConformeImpurezas.TrailingIcon = null;
            // 
            // txtPesoBrutoImpurezas
            // 
            this.txtPesoBrutoImpurezas.AnimateReadOnly = false;
            this.txtPesoBrutoImpurezas.BackColor = System.Drawing.Color.White;
            this.txtPesoBrutoImpurezas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoBrutoImpurezas.Depth = 0;
            this.txtPesoBrutoImpurezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtPesoBrutoImpurezas.LeadingIcon = null;
            this.txtPesoBrutoImpurezas.Location = new System.Drawing.Point(248, 42);
            this.txtPesoBrutoImpurezas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesoBrutoImpurezas.MaxLength = 50;
            this.txtPesoBrutoImpurezas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoBrutoImpurezas.Multiline = false;
            this.txtPesoBrutoImpurezas.Name = "txtPesoBrutoImpurezas";
            this.txtPesoBrutoImpurezas.ReadOnly = true;
            this.txtPesoBrutoImpurezas.Size = new System.Drawing.Size(133, 50);
            this.txtPesoBrutoImpurezas.TabIndex = 4;
            this.txtPesoBrutoImpurezas.Text = "0";
            this.txtPesoBrutoImpurezas.TrailingIcon = null;
            // 
            // cmbMuestra
            // 
            this.cmbMuestra.AutoResize = false;
            this.cmbMuestra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMuestra.Depth = 0;
            this.cmbMuestra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMuestra.DropDownHeight = 174;
            this.cmbMuestra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMuestra.DropDownWidth = 121;
            this.cmbMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbMuestra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbMuestra.FormattingEnabled = true;
            this.cmbMuestra.IntegralHeight = false;
            this.cmbMuestra.ItemHeight = 43;
            this.cmbMuestra.Items.AddRange(new object[] {
            "10",
            "50",
            "100"});
            this.cmbMuestra.Location = new System.Drawing.Point(827, 128);
            this.cmbMuestra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMuestra.MaxDropDownItems = 4;
            this.cmbMuestra.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbMuestra.Name = "cmbMuestra";
            this.cmbMuestra.Size = new System.Drawing.Size(160, 49);
            this.cmbMuestra.StartIndex = 0;
            this.cmbMuestra.TabIndex = 3;
            this.cmbMuestra.SelectedIndexChanged += new System.EventHandler(this.cmbMuestra_SelectedIndexChanged);
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.Location = new System.Drawing.Point(44, 158);
            this.materialLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(134, 19);
            this.materialLabel19.TabIndex = 2;
            this.materialLabel19.Text = "Peso no conforme:";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.Location = new System.Drawing.Point(44, 80);
            this.materialLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(81, 19);
            this.materialLabel18.TabIndex = 1;
            this.materialLabel18.Text = "Peso bruto:";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.Location = new System.Drawing.Point(616, 158);
            this.materialLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(79, 19);
            this.materialLabel17.TabIndex = 0;
            this.materialLabel17.Text = "% Muestra:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMTicketImpurezas);
            this.groupBox5.Controls.Add(this.cmbTicketImpurezas);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(28, 28);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1343, 238);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ticket";
            // 
            // txtMTicketImpurezas
            // 
            this.txtMTicketImpurezas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMTicketImpurezas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMTicketImpurezas.Depth = 0;
            this.txtMTicketImpurezas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMTicketImpurezas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMTicketImpurezas.Location = new System.Drawing.Point(389, 21);
            this.txtMTicketImpurezas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMTicketImpurezas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMTicketImpurezas.Name = "txtMTicketImpurezas";
            this.txtMTicketImpurezas.ReadOnly = true;
            this.txtMTicketImpurezas.Size = new System.Drawing.Size(787, 185);
            this.txtMTicketImpurezas.TabIndex = 8;
            this.txtMTicketImpurezas.TabStop = false;
            this.txtMTicketImpurezas.Text = "";
            // 
            // cmbTicketImpurezas
            // 
            this.cmbTicketImpurezas.AutoResize = false;
            this.cmbTicketImpurezas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTicketImpurezas.Depth = 0;
            this.cmbTicketImpurezas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTicketImpurezas.DropDownHeight = 174;
            this.cmbTicketImpurezas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketImpurezas.DropDownWidth = 121;
            this.cmbTicketImpurezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTicketImpurezas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTicketImpurezas.FormattingEnabled = true;
            this.cmbTicketImpurezas.Hint = "Número de ticket";
            this.cmbTicketImpurezas.IntegralHeight = false;
            this.cmbTicketImpurezas.ItemHeight = 43;
            this.cmbTicketImpurezas.Location = new System.Drawing.Point(43, 81);
            this.cmbTicketImpurezas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTicketImpurezas.MaxDropDownItems = 4;
            this.cmbTicketImpurezas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTicketImpurezas.Name = "cmbTicketImpurezas";
            this.cmbTicketImpurezas.Size = new System.Drawing.Size(308, 49);
            this.cmbTicketImpurezas.StartIndex = 0;
            this.cmbTicketImpurezas.TabIndex = 1;
            this.cmbTicketImpurezas.SelectedIndexChanged += new System.EventHandler(this.cmbTicketImpurezas_SelectedIndexChanged);
            this.cmbTicketImpurezas.Click += new System.EventHandler(this.cmbTicketImpurezas_Click);
            // 
            // tbSUsuarios
            // 
            this.tbSUsuarios.BackColor = System.Drawing.Color.White;
            this.tbSUsuarios.BaseTabControl = this.tbUsuarios;
            this.tbSUsuarios.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tbSUsuarios.Depth = 0;
            this.tbSUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSUsuarios.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tbSUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSUsuarios.Name = "tbSUsuarios";
            this.tbSUsuarios.Size = new System.Drawing.Size(1600, 38);
            this.tbSUsuarios.TabIndex = 3;
            this.tbSUsuarios.Text = "materialTabSelector1";
            // 
            // VRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 970);
            this.Controls.Add(this.tbUsuarios);
            this.Controls.Add(this.tbSUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VRecepcion";
            this.Text = "VRecepcion";
            this.Load += new System.EventHandler(this.VRecepcion_Load);
            this.Leave += new System.EventHandler(this.VRecepcion_Leave);
            this.tbUsuarios.ResumeLayout(false);
            this.tbEntrada.ResumeLayout(false);
            this.tbEntrada.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tbSalida.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tbImpurezas.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbUsuarios;
        private System.Windows.Forms.TabPage tbEntrada;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigoProveedor;
        private System.Windows.Forms.TabPage tbImpurezas;
        private MaterialSkin.Controls.MaterialTabSelector tbSUsuarios;
        private System.Windows.Forms.TabPage tbSalida;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNTicket;
        private MaterialSkin.Controls.MaterialTextBox2 txtVehiculo;
        private MaterialSkin.Controls.MaterialTextBox2 txtConductor;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialComboBox cmbFormaEntrega;
        private MaterialSkin.Controls.MaterialComboBox cmbMaterial;
        private MaterialSkin.Controls.MaterialTextBox txtPesoEntrada;
        private MaterialSkin.Controls.MaterialTextBox2 txtGuia;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialButton btnLimpiarEntrada;
        private MaterialSkin.Controls.MaterialButton btnObtenerPesoEntrada;
        private MaterialSkin.Controls.MaterialButton btnGuardarEntrada;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialComboBox cmbTicketImpurezas;
        private System.Windows.Forms.GroupBox groupBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialTextBox txtPesoNoConformeImpurezas;
        private MaterialSkin.Controls.MaterialTextBox txtPesoBrutoImpurezas;
        private MaterialSkin.Controls.MaterialComboBox cmbMuestra;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private System.Windows.Forms.GroupBox groupBox7;
        private MaterialSkin.Controls.MaterialButton btnGuardarImpurezas;
        private MaterialSkin.Controls.MaterialButton btnLimpiarImpurezas;
        private MaterialSkin.Controls.MaterialButton btnoObtenerPesoImpurezas;
        private System.Windows.Forms.GroupBox groupBox9;
        private MaterialSkin.Controls.MaterialTextBox txtPesoSalida;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox10;
        private MaterialSkin.Controls.MaterialButton btnGuardarSalida;
        private MaterialSkin.Controls.MaterialButton btnLimpiarSalida;
        private MaterialSkin.Controls.MaterialButton btnObtenerPesoSalida;
        private MaterialSkin.Controls.MaterialComboBox cmbTicketSalida;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtMTicketSalida;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtMProveedor;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtMTicketImpurezas;
        private System.IO.Ports.SerialPort serialPortCamionera;
        private System.IO.Ports.SerialPort serialPortPiso;
        private MaterialSkin.Controls.MaterialTextBox txtPesoNetoImpurezas;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtPesoImpurezas;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtPesoBrutoSalida;
        private MaterialSkin.Controls.MaterialTextBox txtPesoEntradaSalida;
    }
}