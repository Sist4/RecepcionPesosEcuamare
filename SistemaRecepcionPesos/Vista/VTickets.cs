using MaterialSkin.Controls;
using SistemaRecepcionPesos.Controlador;
using SistemaRecepcionPesos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRecepcionPesos.Vista
{
    public partial class VTickets : Form
    {
        TicketController controlador = new TicketController();
        public VTickets()
        {
            InitializeComponent();
        }

        private void tbProceso_Enter(object sender, EventArgs e)
        {
        }

        private void tbFinalizados_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbBuscar_Enter(object sender, EventArgs e)
        {
        }

        private void lstFinalizados_Click(object sender, MouseEventArgs e)
        {
        }

        private void lstFinalizados_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lstFinalizados_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void VTickets_Load(object sender, EventArgs e)
        {
            
            
            if(controlador.ObtenerTicketEnProceso()!=null)
            {
                LlenarTicketsEnProceso();
            }
            if(controlador.ObtenerTicketFinalizados()!=null)
            {
                LlenarTicketsFinalizados();
            }
            
        }
        private void LlenarTicketsFinalizados()
        {
            lstFinalizados.Items.Clear();
            foreach (V_TicketImprimir ticket in controlador.ObtenerTicketFinalizados())
            {
                ListViewItem item = new ListViewItem(ticket.TICKET);
                item.SubItems.Add(ticket.ESTADO);
                item.SubItems.Add(ticket.C_CODIGO_PROVEEDOR);
                item.SubItems.Add(ticket.RUC_PROVEEDOR);
                item.SubItems.Add(ticket.NOMBRE_PROVEEDOR);
                item.SubItems.Add(ticket.CONDUCTOR);
                item.SubItems.Add(ticket.VEHICULO);
                item.SubItems.Add(ticket.N__GUIA);
                item.SubItems.Add(ticket.FECHA_ENTRADA.ToString());
                item.SubItems.Add(ticket.FECHA_SALIDA.ToString());
                item.SubItems.Add(ticket.FORMA_DE_ENTREGA);
                item.SubItems.Add(ticket.MATERIAL);
                item.SubItems.Add(ticket.PESO_ENTRADA.ToString());
                item.SubItems.Add(ticket.PESO_SALIDA.ToString());
                item.SubItems.Add(ticket.PESO_BRUTO.ToString());
                item.SubItems.Add(ticket.C_MUESTRA.ToString());
                item.SubItems.Add(ticket.PESO_IMPUREZAS.ToString());
                item.SubItems.Add(ticket.PESO_NO_CONFORME.ToString());
                item.SubItems.Add(ticket.PESO_NETO.ToString());
                lstFinalizados.Items.Add(item);

            }
        }
        private void LlenarTicketsEnProceso()
        {
            lstEnProceso.Items.Clear();
            foreach (V_TicketImprimir ticket in controlador.ObtenerTicketEnProceso())
            {
                    ListViewItem item = new ListViewItem(ticket.TICKET);
                    item.SubItems.Add(ticket.ESTADO);
                    item.SubItems.Add(ticket.C_CODIGO_PROVEEDOR);
                    item.SubItems.Add(ticket.RUC_PROVEEDOR);
                    item.SubItems.Add(ticket.NOMBRE_PROVEEDOR);
                    item.SubItems.Add(ticket.CONDUCTOR);
                    item.SubItems.Add(ticket.VEHICULO);
                    item.SubItems.Add(ticket.N__GUIA);
                    item.SubItems.Add(ticket.FECHA_ENTRADA.ToString());
                    item.SubItems.Add(ticket.FECHA_SALIDA.ToString());
                    item.SubItems.Add(ticket.FORMA_DE_ENTREGA);
                    item.SubItems.Add(ticket.MATERIAL);
                    item.SubItems.Add(ticket.PESO_ENTRADA.ToString());
                    item.SubItems.Add(ticket.PESO_SALIDA.ToString());
                    item.SubItems.Add(ticket.PESO_BRUTO.ToString());
                    item.SubItems.Add(ticket.C_MUESTRA.ToString());
                    item.SubItems.Add(ticket.PESO_IMPUREZAS.ToString());
                    item.SubItems.Add(ticket.PESO_NO_CONFORME.ToString());
                    item.SubItems.Add(ticket.PESO_NETO.ToString());
                    lstEnProceso.Items.Add(item);
                

            }
        }
        private void LlenarTicketBuscar(V_TicketImprimir ticket)
        {
            lstBuscar.Items.Clear();
            ListViewItem item = new ListViewItem(ticket.TICKET);
            item.SubItems.Add(ticket.ESTADO);
            item.SubItems.Add(ticket.C_CODIGO_PROVEEDOR);
            item.SubItems.Add(ticket.RUC_PROVEEDOR);
            item.SubItems.Add(ticket.NOMBRE_PROVEEDOR);
            item.SubItems.Add(ticket.CONDUCTOR);
            item.SubItems.Add(ticket.VEHICULO);
            item.SubItems.Add(ticket.N__GUIA);
            item.SubItems.Add(ticket.FECHA_ENTRADA.ToString());
            item.SubItems.Add(ticket.FECHA_SALIDA.ToString());
            item.SubItems.Add(ticket.FORMA_DE_ENTREGA);
            item.SubItems.Add(ticket.MATERIAL);
            item.SubItems.Add(ticket.PESO_ENTRADA.ToString());
            item.SubItems.Add(ticket.PESO_SALIDA.ToString());
            item.SubItems.Add(ticket.PESO_BRUTO.ToString());
            item.SubItems.Add(ticket.C_MUESTRA.ToString());
            item.SubItems.Add(ticket.PESO_IMPUREZAS.ToString());
            item.SubItems.Add(ticket.PESO_NO_CONFORME.ToString());
            item.SubItems.Add(ticket.PESO_NETO.ToString());
            lstBuscar.Items.Add(item);

        }

        private void txtMNumeroTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                lstBuscar.Items.Clear();
                if (!txtMNumeroTicket.Equals(string.Empty) || !txtMNumeroTicket.Equals(""))
                {
                    try
                    {
                        V_TicketImprimir ticket = controlador.ObtenerTicketSalidayFinalizadoPorNumero(txtMNumeroTicket.Text);
                        if (ticket == null)
                        {
                            MaterialMessageBox.Show("no existe ese número de ticket",false);
                        }
                        else
                        {
                            //lstBuscar.Visible = true;
                            lstBuscar.Items.Clear();
                            LlenarTicketBuscar(ticket);
                        }

                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("No existe ese número de ticket");
                    }

                }

            }
        }

        private void opGenerarPDF_Click(object sender, EventArgs e)
        {

            if (lstFinalizados.SelectedItems.Count > 0)
            {
                ListViewItem item = lstFinalizados.SelectedItems[0];
                if(item==null)
                {
                    MessageBox.Show("No se ha seleccionado un ticket");
                }
                else
                {
                    //MessageBox.Show(item.SubItems[0].Text);
                    GuardarPDF(controlador.ObtenerIDPorNumeroTicket(item.SubItems[0].Text));
                }
            }

            if (lstBuscar.SelectedItems.Count > 0)
            {
                ListViewItem item = lstBuscar.SelectedItems[0];
                if (item == null)
                {
                    MessageBox.Show("No se ha seleccionado un ticket");
                }
                else
                {
                    //MessageBox.Show(item.SubItems[0].Text);
                    GuardarPDF(controlador.ObtenerIDPorNumeroTicket(item.SubItems[0].Text));
                }
            }
            if (lstEnProceso.SelectedItems.Count > 0)
            {
                ListViewItem item = lstEnProceso.SelectedItems[0];
                if (item == null)
                {
                    MessageBox.Show("No se ha seleccionado un ticket");
                }
                else
                {
                    if(item.SubItems[1].Text.Equals("SALIDA"))
                    {
                        GuardarPDF(controlador.ObtenerIDPorNumeroTicket(item.SubItems[0].Text));
                    }
                    
                }
            }

        }

        private void GuardarPDF(int idTicket)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF document (*.pdf)|*.pdf";
            saveFileDialog1.Title = "Guardar Ticket";
            saveFileDialog1.FileName = "TICKET# "+controlador.ObtenerNumeroTicketPorID(idTicket);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    controlador.GenerarPDF2(saveFileDialog1.FileName, idTicket);
                    //MessageBox.Show(saveFileDialog1.FileName);
                }
            }
        }
    }
}
