using SistemaRecepcionPesos.Controlador;
using SistemaRecepcionPesos.Modelo;
using SistemaRecepcionPesos.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRecepcionPesos
{
    public partial class VUsuarios : Form
    {
        UsuariosController controlador = new UsuariosController();
        USUARIO usuarioPorEditar;
        public VUsuarios()
        {
            InitializeComponent();
        }

        private void tbTodos_Enter(object sender, EventArgs e)
        {
            LlenarUsuarios();
        }

        private void VUsuarios_Load(object sender, EventArgs e)
        {
            LlenarUsuarios();
            NuevoUsuario();
        }

        private void LlenarUsuarios()
        {
            lstUsuarios.Items.Clear();
            foreach (USUARIO usuario in controlador.ObtenerUsuarios())
            {
                ListViewItem item = new ListViewItem(usuario.USU_ID.ToString());
                item.SubItems.Add(usuario.USU_USUARIO);
                item.SubItems.Add(usuario.USU_NOMBRES);
                item.SubItems.Add(usuario.USU_ROL);
                
                lstUsuarios.Items.Add(item);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(CamposLlenos())
            {
                USUARIO usuario = new USUARIO();
                usuario.USU_USUARIO = txtUsuario.Text.ToUpper();
                usuario.USU_NOMBRES = txtNombre.Text;
                usuario.USU_CONTRASENA = controlador.Base64_Encode(txtContraseña.Text);
                usuario.USU_ROL = cmbRol.Text;
                controlador.GuardarUsuario(usuario);
                MessageBox.Show("¡Guardado Exitoso!");
                NuevoUsuario();
                LlenarUsuarios();
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NuevoUsuario();
        }
        private void NuevoUsuario()
        {
            txtUsuario.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtContraseña.Hint = string.Empty;
            cmbRol.Text = string.Empty;


            btnGuardarEditado.Visible = false;
        }
        private bool CamposLlenos()
        {
            if(string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text)||
                string.IsNullOrWhiteSpace(txtContraseña.Text))
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void opEditar_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItems.Count > 0)
            {
                ListViewItem item = lstUsuarios.SelectedItems[0];
                if (Convert.ToInt32(item.SubItems[0].Text)!=1)
                {
                    usuarioPorEditar = controlador.ObtenerUsuarioPorId(Convert.ToInt32(item.SubItems[0].Text));
                    CargarUsuarioPorEditar(usuarioPorEditar);
                    btnGuardarEditado.Visible = true;
                }
                
                
            }
        }

        private void CargarUsuarioPorEditar(USUARIO usuario)
        {
            txtNombre.Text = usuario.USU_NOMBRES;
            txtContraseña.Hint = "Ingrese nueva contraseña";
        }

        private void btnGuardarEditado_Click(object sender, EventArgs e)
        {
            if (CamposLlenosPorEditar())
            {
                try
                {
                    if (controlador.ActualizarUsuario(usuarioPorEditar, txtNombre.Text,
                        controlador.Base64_Encode(txtContraseña.Text),cmbRol.Text))
                    {
                        MessageBox.Show("¡Guardado Exitoso!");
                        NuevoUsuario();
                        LlenarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("¡No se pudo actualizar el usuario!");
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

        private void opEliminar_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItems.Count > 0)
            {
                ListViewItem item = lstUsuarios.SelectedItems[0];
                if (Convert.ToInt32(item.SubItems[0].Text) != 1)
                {
                    EliminarUsuario(Convert.ToInt32(item.SubItems[0].Text));
                }
                   
            }
        }
        private void EliminarUsuario(int id)
        {
            if (controlador.ExisteUsuarioEnPeso(id))
            {
                MessageBox.Show("No se puede eliminar un usuario que ya fue utilizado en un ticket");
            }
            else
            {
                controlador.EliminarUsuario(id);
                MessageBox.Show("¡Guardado Exitoso!");
                NuevoUsuario();
                LlenarUsuarios();
            }
        }
    }
}
