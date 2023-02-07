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
    public partial class VProveedores : Form
    {
        ProveedorController controlador = new ProveedorController();
        PROVEEDOR proveedorPorEditar;
        public VProveedores()
        {
            InitializeComponent();
        }

        private void LlenarProveedores()
        {
            lstProveedores.Items.Clear();
            foreach (PROVEEDOR proveedor in controlador.ObtenerProveedores())
            {
                ListViewItem item = new ListViewItem(proveedor.PROV_ID.ToString());
                item.SubItems.Add(proveedor.PROV_RUC);
                item.SubItems.Add(proveedor.PROV_NOMBRE);
                item.SubItems.Add(proveedor.PROV_DIRECCION);
                item.SubItems.Add(proveedor.PROV_TELEFONO);

                lstProveedores.Items.Add(item);
            }
        }

        private void tbProveedor_Enter(object sender, EventArgs e)
        {
            LlenarProveedores();
        }

        private void VProveedores_Load(object sender, EventArgs e)
        {
            LlenarProveedores();
            NuevoProveedor();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposLlenos())
                {
                    PROVEEDOR proveedor = new PROVEEDOR();
                    proveedor.PROV_ID = txtCodigo.Text;
                    proveedor.PROV_RUC = txtRUC.Text;
                    proveedor.PROV_NOMBRE = txtNombre.Text;
                    proveedor.PROV_DIRECCION = txtDireccion.Text;
                    proveedor.PROV_TELEFONO = txtTelefono.Text;
                    controlador.GuardarProveedor(proveedor);
                    MessageBox.Show("¡Guardado Exitoso!");
                    NuevoProveedor();
                    LlenarProveedores();
                }
                else
                {
                    MessageBox.Show("Faltan campos por llenar");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("¡No se pudo guardar el proveedor!");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NuevoProveedor();
        }
        private void NuevoProveedor()
        {
            txtCodigo.Text = string.Empty;
            txtRUC.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            btnGuardarEditado.Visible = false;
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedItems.Count > 0)
            {
                ListViewItem item = lstProveedores.SelectedItems[0];
                proveedorPorEditar = controlador.ObtenerProveedorPorId(item.SubItems[0].Text);
                CargarProveedorPorEditar(proveedorPorEditar);
                btnGuardarEditado.Visible = true;

            }
        }
        private void CargarProveedorPorEditar(PROVEEDOR proveedor)
        {
            txtNombre.Text = proveedor.PROV_NOMBRE;
            txtDireccion.Text = proveedor.PROV_DIRECCION;
            txtTelefono.Text = proveedor.PROV_TELEFONO;
            
        }

        private void btnGuardarEditado_Click(object sender, EventArgs e)
        {

            if (CamposLlenosPorEditar())
            {
                try
                {
                    if (controlador.ActualizarProveedor(proveedorPorEditar, txtNombre.Text, txtDireccion.Text, txtTelefono.Text))
                    {
                        MessageBox.Show("¡Guardado Exitoso!");
                        NuevoProveedor();
                        LlenarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("¡No se pudo actualizar el proveedor!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");

            }

        }
        private bool CamposLlenos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text)|| string.IsNullOrWhiteSpace(txtRUC.Text)|| string.IsNullOrWhiteSpace(txtNombre.Text)
                || string.IsNullOrWhiteSpace(txtDireccion.Text)|| string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CamposLlenosPorEditar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)
                || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedItems.Count > 0)
            {
                ListViewItem item = lstProveedores.SelectedItems[0];
                EliminarProveedor(item.SubItems[0].Text);
            }
        }
        private void EliminarProveedor(string id)
        {
            if(controlador.ExisteProveedorEnTicket(id))
            {
                MessageBox.Show("No se puede eliminar un proveedor que ya fue utilizado en un ticket");
            }
            else
            {
                controlador.EliminarProveedor(id);
                MessageBox.Show("¡Guardado Exitoso!");
                NuevoProveedor();
                LlenarProveedores();
            }
        }
    }
}
