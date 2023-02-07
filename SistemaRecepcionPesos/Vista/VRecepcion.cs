using MaterialSkin.Controls;
using SistemaRecepcionPesos.Controlador;
using SistemaRecepcionPesos.Modelo;
using SistemaRecepcionPesos.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRecepcionPesos
{
    public partial class VRecepcion : Form
    {
        RecepcionController controlador = new RecepcionController();
        private delegate void DelegadoAccesoCamionera(string accion);
        private delegate void DelegadoAccesoPiso(string accion);
        USUARIO usuarioActual;
        float pesoCamioneraActual = 0F;
        float pesoPisoActual = 0F;
        string serialCamioneraActual = string.Empty;
        string serialPisoActual = string.Empty;
        public VRecepcion(USUARIO usuario)
        {
            this.usuarioActual = usuario;
            serialPortCamionera = new SerialPort();
            serialPortPiso = null;
            InitializeComponent();
            IniciarCamionera();
            IniciarPiso();
        }
        private void VRecepcion_Load(object sender, EventArgs e)
        {
            NuevaRecepcion();
        }

        private void btnObtenerPesoEntrada_Click(object sender, EventArgs e)
        {
            ObtenerPesoCamionera();
            VObtenerPeso obtencion = new VObtenerPeso();
            obtencion.ShowDialog();
           
            
            txtPesoEntrada.Text = pesoCamioneraActual.ToString()+" KG";
            if (ValidarCamionera(serialCamioneraActual))
            {
                if (pesoCamioneraActual <= 0)
                {
                    btnGuardarEntrada.Enabled = false;
                    MessageBox.Show("El peso no puede ser 0 o menor que 0. Coloque un peso en la balanza porfavor");
                }
                else
                {
                    btnGuardarEntrada.Enabled = true;
                }
            }

        }
        private void btnoObtenerPesoImpurezas_Click(object sender, EventArgs e)
        {
            ObtenerPesoPiso();
            VObtenerPeso obtencion = new VObtenerPeso();
            obtencion.ShowDialog();

            try
            {
                int codigo = controlador.ObtenerCodigoTicket(cmbTicketImpurezas.Text);
                float pesoEntrada = controlador.ObtenerPesoEntrada(codigo);
                float pesoSalida = controlador.ObtenerPesoSalida(codigo);
                float pesoBruto = pesoEntrada - pesoSalida;
                float pesoImpurezas = pesoPisoActual;
                int muestra = Int32.Parse(cmbMuestra.Text);
                float pesoNoConforme = (pesoImpurezas * 100) / muestra;

                float pesoNeto = pesoBruto - pesoNoConforme;

                txtPesoBrutoImpurezas.Text = pesoBruto.ToString() + " KG";

                txtPesoNoConformeImpurezas.Text = pesoNoConforme.ToString() + " KG";
                txtPesoNetoImpurezas.Text = pesoNeto.ToString() + " KG";

                txtPesoImpurezas.Text = pesoPisoActual.ToString() + " KG";

                if (ValidarPiso(serialPisoActual))
                {
                    if (pesoPisoActual <= 0)
                    {
                        btnGuardarImpurezas.Enabled = false;
                        MessageBox.Show("El peso no puede ser 0 o menor que 0. Coloque un peso en la balanza porfavor");
                    }
                    else
                    {
                        btnGuardarImpurezas.Enabled = true;
                    }
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnObtenerPesoSalida_Click(object sender, EventArgs e)
        {
            ObtenerPesoCamionera();
            VObtenerPeso obtencion = new VObtenerPeso();
            obtencion.ShowDialog();

            
            txtPesoSalida.Text = pesoCamioneraActual.ToString() + " KG";

            try
            {
                int codigo = controlador.ObtenerCodigoTicket(cmbTicketSalida.Text);
                float pesoEntrada = controlador.ObtenerPesoEntrada(codigo);
                float pesoSalida = pesoCamioneraActual;
                float pesoBruto = pesoEntrada - pesoSalida;

                txtPesoEntradaSalida.Text = pesoEntrada.ToString() + " KG";

                txtPesoBrutoSalida.Text = pesoBruto.ToString() + " KG";
                if (ValidarCamionera(serialCamioneraActual))
                {
                    if (pesoCamioneraActual == 0)
                    {
                        btnGuardarSalida.Enabled = false;
                        MessageBox.Show("El peso no puede ser 0. Coloque un peso en la balanza porfavor");
                    }
                    else
                    {
                        btnGuardarSalida.Enabled = true;
                    }
                }

                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" No se han escogido todos los campos");
            }
            
        }

        private void btnLimpiarEntrada_Click(object sender, EventArgs e)
        {
            NuevaRecepcion();
        }
        private void btnLimpiarImpurezas_Click(object sender, EventArgs e)
        {
            NuevaRecepcion();
        }
        private void btnLimpiarSalida_Click(object sender, EventArgs e)
        {
            NuevaRecepcion();
        }
        private void NuevaRecepcion()
        {
            //Peso entrada
            txtCodigoProveedor.Text = string.Empty;
            txtConductor.Text = string.Empty;
            txtVehiculo.Text = string.Empty;
            txtGuia.Text = string.Empty;
            cmbFormaEntrega.Text = string.Empty;
            cmbMaterial.Items.Clear();
            txtPesoEntrada.Text = "0";
            txtMProveedor.Text = String.Empty;
            lblNTicket.Text = controlador.NumeroTicket();
            txtCodigoProveedor.Enabled = true;
            btnObtenerPesoEntrada.Enabled = false;
            btnLimpiarEntrada.Enabled = false;
            btnGuardarEntrada.Enabled = false;

            //Peso impurezas
            cmbTicketImpurezas.Items.Clear();
            txtMTicketImpurezas.Text = string.Empty;
            txtPesoBrutoImpurezas.Text = "0";
            txtPesoNoConformeImpurezas.Text = "0";
            txtPesoImpurezas.Text = "0";
            txtPesoNetoImpurezas.Text = "0";
            cmbMuestra.Text = string.Empty;
            cmbTicketImpurezas.Enabled = true;
            btnoObtenerPesoImpurezas.Enabled = false;
            btnLimpiarImpurezas.Enabled = false;
            btnGuardarImpurezas.Enabled = false;

            //Peso salida
            cmbTicketSalida.Items.Clear();
            txtMTicketSalida.Text = string.Empty;
            txtPesoSalida.Text = "0";
            txtPesoEntradaSalida.Text = "0";
            txtPesoBrutoSalida.Text = "0";
            cmbTicketSalida.Enabled = true;
            btnObtenerPesoSalida.Enabled = false;
            btnLimpiarSalida.Enabled = false;
            btnGuardarSalida.Enabled = false;
        }

        private void cmbMaterial_Click(object sender, EventArgs e)
        {
            cmbMaterial.Items.Clear();

            foreach (string material in controlador.ObtenerMateriales())
            {
                cmbMaterial.Items.Add(material);
            }
        }

        private void cmbTicketImpurezas_Click(object sender, EventArgs e)
        {
            cmbTicketImpurezas.Items.Clear();
            foreach (string ticket in controlador.ObtenerNumeroTicketsImpurezas())
            {
                cmbTicketImpurezas.Items.Add(ticket);
            }
        }

        private void cmbTicketImpurezas_SelectedIndexChanged(object sender, EventArgs e)
        {
            TICKET ticket = controlador.ObtenerTicket(cmbTicketImpurezas.Text, "SALIDA");
            txtMTicketImpurezas.Text = "Código de proveedor: " + ticket.PROV_ID + "\n" +
                "Conductor: " + ticket.TICK_NOMBRECONDUCTOR + "\n" +
                "Vehiculo: " + ticket.TICK_PLACAVEHICULO + "\n" +
                "Material: " + controlador.ObtenerNombreMaterial(ticket.MAT_ID) + "\n" +
                "N# de Guía: " + ticket.TICK_GUIA;

            btnoObtenerPesoImpurezas.Enabled = true;
            btnLimpiarImpurezas.Enabled = true;

            int codigo = controlador.ObtenerCodigoTicket(cmbTicketImpurezas.Text);
            float pesoEntrada = controlador.ObtenerPesoEntrada(codigo);
            float pesoSalida = controlador.ObtenerPesoSalida(codigo);
            float pesoBruto = pesoEntrada - pesoSalida;

            txtPesoBrutoImpurezas.Text = pesoBruto.ToString() + " KG";

        }

        private void cmbTicketSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            TICKET ticket = controlador.ObtenerTicket(cmbTicketSalida.Text, "ENTRADA");
            txtMTicketSalida.Text = "Código de proveedor: " + ticket.PROV_ID + "\n" +
                "Conductor: " + ticket.TICK_NOMBRECONDUCTOR + "\n" +
                "Vehiculo: " + ticket.TICK_PLACAVEHICULO + "\n" +
                "Material: " + controlador.ObtenerNombreMaterial(ticket.MAT_ID) + "\n" +
                "N# de Guía: " + ticket.TICK_GUIA;
            //cmbTicketSalida.Enabled = false;
            btnObtenerPesoSalida.Enabled = true;
            btnLimpiarSalida.Enabled = true;


            int codigo = controlador.ObtenerCodigoTicket(cmbTicketSalida.Text);
            float pesoEntrada = controlador.ObtenerPesoEntrada(codigo);

            txtPesoEntradaSalida.Text = pesoEntrada.ToString() + " KG";


        }

        private void cmbTicketSalida_Click(object sender, EventArgs e)
        {
            cmbTicketSalida.Items.Clear();
            foreach (string ticket in controlador.ObtenerNumeroTicketsSalidas())
            {
                cmbTicketSalida.Items.Add(ticket);
            }
        }

        private void btnGuardarEntrada_Click(object sender, EventArgs e)
        {
            if(CamposLlenosEntrada())
            {
                TICKET ticket = new TICKET();
                ticket.TICK_NUMERO = controlador.NumeroTicket();
                ticket.TICK_NOMBRECONDUCTOR = txtConductor.Text;
                ticket.TICK_PLACAVEHICULO = txtVehiculo.Text;
                ticket.TICK_GUIA = txtGuia.Text;
                ticket.TICK_FORMAENTREGA = cmbFormaEntrega.Text;
                ticket.PROV_ID = txtCodigoProveedor.Text;
                ticket.MAT_ID = controlador.ObtenerCodigoMaterial(cmbMaterial.Text);
                ticket.TICK_ESTADO = "ENTRADA";
                controlador.GuardarTicket(ticket);
                PESO pesoEntrada = new PESO();
                pesoEntrada.PES_FECHA = DateTime.Now;
                pesoEntrada.PES_PESO = pesoCamioneraActual;
                pesoEntrada.PES_PORCENTAJE = 100;
                pesoEntrada.PES_TIPO = 1;
                pesoEntrada.USU_ID = usuarioActual.USU_ID;
                pesoEntrada.TICK_ID = controlador.ObtenerUltimoCodigoTicket();

                controlador.GuardarPeso(pesoEntrada);

                MessageBox.Show("¡Guardado Exitoso!");
                NuevaRecepcion();
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            
        }
        private void btnGuardarImpurezas_Click(object sender, EventArgs e)
        {
            if(CamposLlenosImpurezas())
            {
                PESO pesoImpurezas = new PESO();
                pesoImpurezas.PES_FECHA = DateTime.Now;
                pesoImpurezas.PES_PESO = pesoPisoActual;
                pesoImpurezas.PES_TIPO = 3;
                pesoImpurezas.PES_PORCENTAJE = Convert.ToInt32(cmbMuestra.Text);
                pesoImpurezas.USU_ID = usuarioActual.USU_ID;
                pesoImpurezas.TICK_ID = controlador.ObtenerCodigoTicket(cmbTicketImpurezas.Text);
                controlador.GuardarPeso(pesoImpurezas);
                controlador.ActualizarEstadoTicket(cmbTicketImpurezas.Text, "IMPUREZAS");
                MessageBox.Show("¡Guardado Exitoso!");
                NuevaRecepcion();
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            
        }

        private void btnGuardarSalida_Click(object sender, EventArgs e)
        {
            if(CamposLlenosSalida())
            {
                PESO pesoSalida = new PESO();
                pesoSalida.PES_FECHA = DateTime.Now;
                pesoSalida.PES_PESO = pesoCamioneraActual;
                pesoSalida.PES_TIPO = 2;
                pesoSalida.PES_PORCENTAJE = 100;
                pesoSalida.USU_ID = usuarioActual.USU_ID;
                pesoSalida.TICK_ID = controlador.ObtenerCodigoTicket(cmbTicketSalida.Text);
                controlador.GuardarPeso(pesoSalida);
                controlador.ActualizarEstadoTicket(cmbTicketSalida.Text, "SALIDA");
                MessageBox.Show("¡Guardado Exitoso!");
                NuevaRecepcion();
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            
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
            }catch(Exception ex)
            {
                MessageBox.Show("No se ha completado la configuración");
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
            }catch(Exception ex)
            {
                MessageBox.Show("No se ha completado la configuración");
            }

        }
        void SP_DataReceived_Camionera(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(300);
            string data = "";
            if (serialPortCamionera.IsOpen)
                data = serialPortCamionera.ReadExisting();
            else
                //MessageBox.Show("puerto cerrado");
                serialPortCamionera.Close();

            this.BeginInvoke(new DelegadoAccesoCamionera(MostrarPesoCamionera), new object[] { data });
        }
        void SP_DataReceived_Piso(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(300);
            string data = "";
            if (serialPortPiso.IsOpen)
                data = serialPortPiso.ReadExisting();
            else
                //MessageBox.Show("puerto cerrado");
                serialPortPiso.Close();

            this.BeginInvoke(new DelegadoAccesoPiso(MostrarPesoPiso), new object[] { data });
        }
        private void MostrarPesoCamionera(string accion)
        {
            try
            {
                    accion = accion.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Trim();
                    accion= accion.Replace(".", ",");
                    float peso = float.Parse(accion.Substring(8, 11));
                    pesoCamioneraActual = peso;
                    string serial = accion.Substring(28, 10);
                    serialCamioneraActual = serial;

                serialPortCamionera.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("data received: " + ex.Message);
                serialPortCamionera.Close();
            }


        }
        private void MostrarPesoPiso(string accion)
        {
            try
            {
                accion = accion.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Trim();
                accion = accion.Replace(".", ",");
                float peso = float.Parse(accion.Substring(3, 11));
                pesoPisoActual = peso;
                string serial = accion.Substring(23, 10);
                serialPisoActual = serial;
                serialPortPiso.Close();

            }
            catch (Exception ex)
            {
                // MessageBox.Show("data received: " + ex.Message);
                serialPortPiso.Close();
            }


        }
        public void ObtenerPesoCamionera()
        {
            try
            {
                if (serialPortCamionera.IsOpen)
                {
                    serialPortCamionera.Close();
                }
                serialPortCamionera.Open();
                serialPortCamionera.WriteLine("TAC");
                serialPortCamionera.WriteLine("S");
                serialPortCamionera.WriteLine("I4");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"No se pudo obtener el peso");
                serialPortCamionera.Close();
            }
        }
        public void ObtenerPesoPiso()
        {
            try
            {
                if (serialPortPiso.IsOpen)
                {
                    serialPortPiso.Close();
                }
                serialPortPiso.Open();
                serialPortPiso.WriteLine("S");
                serialPortPiso.WriteLine("I4");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "No se pudo obtener el peso");
                serialPortPiso.Close();
            }
        }
        public bool ValidarCamionera(string serial)
        {
            if(serial.Equals(string.Empty))
            {
                MessageBox.Show("No se recibe respuesta por parte de la balanza. Revise la conexión porfavor");
                pesoCamioneraActual = 0;
                return false;
            }
            else
            {
                if (controlador.ObtenerSerialCamionera().Equals(serial))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El serial de la balanza es incorrecto. Revise la configuración de la balanza porfavor");
                    pesoCamioneraActual = 0;
                    return false;
                }
            }
            
        }
        public bool ValidarPiso(string serial)
        {
            if (serial.Equals(string.Empty))
            {
                MessageBox.Show("No se recibe respuesta por parte de la balanza. Revise la conexión porfavor");
                pesoPisoActual = 0;
                return false;
            }
            else
            {
                if (controlador.ObtenerSerialPiso().Equals(serial))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El serial de la balanza es incorrecto. Revise la configuración de la balanza porfavor");
                    pesoPisoActual = 0;
                    return false;
                }
            }
            
        }

        
        private bool CamposLlenosEntrada()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProveedor.Text) || string.IsNullOrWhiteSpace(txtConductor.Text)
                || string.IsNullOrWhiteSpace(txtVehiculo.Text) || string.IsNullOrWhiteSpace(txtGuia.Text)
                || cmbFormaEntrega.SelectedItem == null || cmbMaterial.SelectedItem == null
                || string.IsNullOrWhiteSpace(txtPesoEntrada.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private bool CamposLlenosImpurezas()
        {
            if (cmbTicketImpurezas.SelectedItem == null || cmbMuestra.SelectedItem == null
                || string.IsNullOrWhiteSpace(txtPesoBrutoImpurezas.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CamposLlenosSalida()
        {
            if (cmbTicketSalida.SelectedItem == null || string.IsNullOrWhiteSpace(txtPesoSalida.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtCodigoProveedor_TextChanged(object sender, EventArgs e)
        {
            if (!txtCodigoProveedor.Equals(string.Empty) || !txtCodigoProveedor.Equals(""))
            {
                try
                {
                    PROVEEDOR proveedor = controlador.ObtenerProveedor(txtCodigoProveedor.Text);
                    if (proveedor == null)
                    {
                        txtMProveedor.Text = string.Empty;
                        btnObtenerPesoEntrada.Enabled = false;
                        btnLimpiarEntrada.Enabled = false;
                        btnGuardarEntrada.Enabled = false;
                    }
                    else
                    {
                        txtMProveedor.Text = "RUC: " + proveedor.PROV_RUC + "\n" +
                            "Nombres: " + proveedor.PROV_NOMBRE + "\n" +
                            "Dirección: " + proveedor.PROV_DIRECCION + "\n" +
                            "Teléfono: " + proveedor.PROV_TELEFONO + "\n";
                        btnObtenerPesoEntrada.Enabled = true;
                        btnLimpiarEntrada.Enabled = true;
                    }

                }
                catch (InvalidOperationException ex)
                {
                    //MessageBox.Show("exepcion: " + ex.Message);
                }
            }
        }

        private void cmbMuestra_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo = controlador.ObtenerCodigoTicket(cmbTicketImpurezas.Text);
            float pesoEntrada = controlador.ObtenerPesoEntrada(codigo);
            float pesoSalida = controlador.ObtenerPesoSalida(codigo);
            float pesoBruto = pesoEntrada - pesoSalida;
            float pesoImpurezas = pesoPisoActual;
            int muestra = Int32.Parse(cmbMuestra.Text);
            float pesoNoConforme = (pesoImpurezas * 100) / muestra;

            float pesoNeto = pesoBruto - pesoNoConforme;

            txtPesoNoConformeImpurezas.Text = controlador.PesoNoConforme(pesoPisoActual,
                Int32.Parse(cmbMuestra.Text)).ToString() + " KG";
            txtPesoNetoImpurezas.Text = pesoNeto.ToString() + " KG";
            
        }

        private void VRecepcion_Leave(object sender, EventArgs e)
        {
            serialPortPiso.Close();
            serialPortCamionera.Close();
        }

        private void tbEntrada_Enter(object sender, EventArgs e)
        {
            NuevaRecepcion();
        }

        private void tbImpurezas_Enter(object sender, EventArgs e)
        {
            NuevaRecepcion();
        }

        private void tbSalida_Enter(object sender, EventArgs e)
        {
            NuevaRecepcion();
        }
    }
}