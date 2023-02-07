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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRecepcionPesos.Vista
{
    public partial class VConfiguracion : Form
    {
        ConfiguracionController controlador = new ConfiguracionController();
        private delegate void DelegadoAccesoCamionera(string accion);
        private delegate void DelegadoAccesoPiso(string accion);
        string serialCamionera = string.Empty;
        string serialPiso = string.Empty;
        public VConfiguracion()
        {
            InitializeComponent();
            IniciarCamionera();
            IniciarPiso();
        }

        private void VConfiguracion_Load(object sender, EventArgs e)
        {
            
            CargarConfiguracion();
        }

        private void btnProbarConexionCamionera_Click(object sender, EventArgs e)
        {
            ObtenerSerialCamionera();
        }
        private void btnProbarConexionPiso_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("asdihsad");
            ObtenerSerialPiso();
        }

        private void btnProbarConexionPiso_Click(object sender, EventArgs e)
        {

        }

        public void IniciarCamionera()
        {
            try
            {
                string COM = controlador.ObtenerCOMCamionera();
                serialPortCamionera = new SerialPort(COM, 9600, Parity.None, 8, StopBits.One);
                serialPortCamionera.Handshake = Handshake.None;
                serialPortCamionera.RtsEnable = false;
                serialPortCamionera.DataReceived += new SerialDataReceivedEventHandler(SP_DataReceived_Camionera);
                serialPortCamionera.ReadTimeout = 500;
                serialPortCamionera.WriteTimeout = 500;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La configuración de la balanza camionera no se ha realizado");
            }

        }
        public void IniciarPiso()
        {
            try
            {
                string COM = controlador.ObtenerCOMPiso();
                serialPortPiso = new SerialPort(COM, 9600, Parity.None, 8, StopBits.One);
                serialPortPiso.Handshake = Handshake.None;
                serialPortPiso.RtsEnable = false;
                serialPortPiso.DataReceived += new SerialDataReceivedEventHandler(SP_DataReceived_Piso);
                serialPortPiso.ReadTimeout = 500;
                serialPortPiso.WriteTimeout = 500;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La configuración de la balanza de piso no se ha realizado");
            }

        }
        void SP_DataReceived_Camionera(object sender, SerialDataReceivedEventArgs e)
        {
            if (this.Enabled == true)
            {
                Thread.Sleep(300);
                string data = "";
                if (serialPortCamionera.IsOpen)
                    data = serialPortCamionera.ReadExisting();
                else
                    //MessageBox.Show("puerto cerrado");
                    serialPortCamionera.Close();

                this.BeginInvoke(new DelegadoAccesoCamionera(si_DataReceived_Camionera), new object[] { data });
            }
        }
        void SP_DataReceived_Piso(object sender, SerialDataReceivedEventArgs e)
        {
            if (this.Enabled == true)
            {
                Thread.Sleep(300);
                string data = "";
                if (serialPortPiso.IsOpen)
                    data = serialPortPiso.ReadExisting();
                else
                    //MessageBox.Show("puerto cerrado");
                    serialPortPiso.Close();

                this.BeginInvoke(new DelegadoAccesoPiso(si_DataReceived_Piso), new object[] { data });
            }
        }

        private void si_DataReceived_Camionera(string accion)
        {
            try
            {
                string accion2 = accion.Trim();
                accion2 = accion.Trim().Substring(6, 10);
            
                if(accion2.Length==10)
                {
                    serialCamionera = accion2;
                    // MessageBox.Show(accion2);
                    ValidarCamionera(accion2);
                }
                else
                {
                    serialPortCamionera.Close();
                }
                //textBox2.Text = accion2;
                
                //MessageBox.Show(accion2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("data received: " + ex.Message);
                serialPortCamionera.Close();
            }
        }
        private void si_DataReceived_Piso(string accion)
        {
            try
            {
                string accion2 = accion.Trim();
                accion2 = accion.Trim().Substring(6, 10);
                if (accion2.Length == 10)
                {
                    serialPiso = accion2;
                    // MessageBox.Show(accion2);
                    ValidarPiso(accion2);
                }
                else
                {
                    serialPortPiso.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("data received: " + ex.Message);
                serialPortPiso.Close();
            }
        }
        public void ObtenerSerialCamionera()
        {
            try
            {
                if (serialPortCamionera.IsOpen)
                {
                    serialPortCamionera.Close();

                }
                serialPortCamionera.Open();
                serialPortCamionera.WriteLine("I4");

            }
            catch (Exception ex)
            {
                //MessageBox.Show("button1: " + ex.Message);
                serialPortCamionera.Close();
            }
        }
        public void ObtenerSerialPiso()
        {
            try
            {
                if (serialPortPiso.IsOpen)
                {
                    serialPortPiso.Close();

                }
                serialPortPiso.Open();
                serialPortPiso.WriteLine("I4");

            }
            catch (Exception ex)
            {
                //MessageBox.Show("button1: " + ex.Message);
                serialPortPiso.Close();
            }
        }
        public void ValidarCamionera(string serial)
        {
            if (controlador.ObtenerSerialCamionera().Equals(serial))
            {
                MessageBox.Show("serial correcto");
            }
            else
            {
                MessageBox.Show("serial incorrecto");
            }
        }
        public void ValidarPiso(string serial)
        {
            if (controlador.ObtenerSerialPiso().Equals(serial))
            {
                MessageBox.Show("serial correcto");
            }
            else
            {
                MessageBox.Show("serial incorrecto");
            }
        }

        private void btnEditarCamionera_Click(object sender, EventArgs e)
        {
            VNuevoConfiguracion nuevo = new VNuevoConfiguracion("camionera");
            nuevo.ShowDialog();
            CargarConfiguracion();
        }
        private void btnEditarPiso_Click(object sender, EventArgs e)
        {
            VNuevoConfiguracion nuevo = new VNuevoConfiguracion("piso");
            nuevo.ShowDialog();
            CargarConfiguracion();
        }
        public void CargarConfiguracion()
        {
            txtMConfiguracionCamionera.Text = string.Empty;
            txtMConfiguracionPiso.Text = string.Empty;
            txtMConfiguracionCamionera.Text = "Serial: " + controlador.ObtenerSerialCamionera() + "\n" +
                               "COM: " + controlador.ObtenerCOMCamionera() + "\n" +
                               "Bits por segundo: " + "9600" + "\n" +
                               "Bits de datos: " + "8" + "\n" +
                               "Paridad: " + "Ninguno" + "\n" +
                               "Bits de parada: " + "1" + "\n" +
                               "Control de flujo: " + "Ninguno" + "\n";

            txtMConfiguracionPiso.Text = "Serial: " + controlador.ObtenerSerialPiso() + "\n" +
                               "COM: " + controlador.ObtenerCOMPiso() + "\n" +
                               "Bits por segundo: " + "9600" + "\n" +
                               "Bits de datos: " + "8" + "\n" +
                               "Paridad: " + "Ninguno" + "\n" +
                               "Bits de parada: " + "1" + "\n" +
                               "Control de flujo: " + "Ninguno" + "\n";
        }

        private void VConfiguracion_Leave(object sender, EventArgs e)
        {
            serialPortPiso.Close();
            serialPortCamionera.Close();
        }
    }
}
