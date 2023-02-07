using SistemaRecepcionPesos.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRecepcionPesos.Vista
{
    public partial class VNuevoConfiguracion : Form
    {
        ConfiguracionController controlador = new ConfiguracionController();
        string configuracion = string.Empty;
        public VNuevoConfiguracion(string configuracion)
        {
            InitializeComponent();
            this.configuracion = configuracion;
        }

        private void cmbPort_Click(object sender, EventArgs e)
        {
            cmbPort.Items.Clear();
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();

                foreach (string s in portnames)
                {
                    cmbPort.Items.Add(s);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(configuracion.Equals("camionera"))
            {
                controlador.ActualizarCamionera(txtSerial.Text, cmbPort.Text);
                MessageBox.Show("¡Guardado Exitoso!");
            }
            if(configuracion.Equals("piso"))
            {
                controlador.ActualizarPiso(txtSerial.Text, cmbPort.Text);
                MessageBox.Show("¡Guardado Exitoso!");
            }
        }

        private void VNuevoConfiguracion_Load(object sender, EventArgs e)
        {
            if (configuracion.Equals("camionera"))
            {
                txtSerial.Text = controlador.ObtenerSerialCamionera();
            }
            else
            {
                txtSerial.Text = controlador.ObtenerSerialPiso();
            }
                
        }
    }
}
