using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaRecepcionPesos.Negocio
{
    class ObtencionPeso
    {
        SerialPort camioneraPort;
        SerialPort pisoPort;
        private delegate void DelegadoAcceso(string accion);

        public void IniciarCamionera()
        {
            camioneraPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            camioneraPort.Handshake = Handshake.None;
            camioneraPort.RtsEnable = false;
            camioneraPort.DataReceived += new SerialDataReceivedEventHandler(SP_DataReceived_Camionera);
            camioneraPort.ReadTimeout = 500;
            camioneraPort.WriteTimeout = 500;
        }
        void SP_DataReceived_Camionera(object sender, SerialDataReceivedEventArgs e)
        {
                Thread.Sleep(300);
                string data = "";
                if (camioneraPort.IsOpen)
                    data = camioneraPort.ReadExisting();
                else
                    //MessageBox.Show("puerto cerrado");
                    camioneraPort.Close();

           //th1.BeginInvoke(new DelegadoAcceso(PesoCamionera), new object[] { data });
        }
        private void PesoCamionera(string accion)
        {
            string valor = "";
            float numero = 0;
            string accion2 = "";

            try
            {
                if (accion.Length == 19)
                {
                    //MessageBox.Show("si son 18");
                    valor = accion.Substring(3, 11).Trim();
                    numero = float.Parse(valor);
                    //label2.Text = numero.ToString();
                    camioneraPort.Close();
                }
                else
                {
                    //textBox1.Text = accion + "peso inestable";
                    //label2.Text = "0";
                    //MessageBox.Show(accion2);
                    camioneraPort.Close();
                    //if (accion.Substring(0, 3).Equals("S I"))
                    //{
                    //    textBox1.Text = accion;
                    //    MessageBox.Show(accion.Trim() + " " + accion.Trim().Length);
                    //}

                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("data received: " + ex.Message);
                camioneraPort.Close();
            }


        }
    }
}
