using SistemaRecepcionPesos.Controlador;
using SistemaRecepcionPesos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRecepcionPesos.Vista
{
    public partial class VLogin : Form
    {
        LoginController controlador=new LoginController();
        int X = 0;
        int Y = 0;
        public VLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Acceder();
        }

        

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Acceder();
            }
        }
        private void Acceder()
        {
            USUARIO usuario = controlador.obtenerUsuarioLogeado(txtUsuario.Text, txtContraseña.Text);
            if (usuario==null)
            {
                MessageBox.Show("Usuario no existe o contraseña incorrecta");
            }
            else
            {
                
                this.Hide();
                VPrincipal vprincipal = new VPrincipal(usuario);
                vprincipal.FormClosed += (s, args) => this.Close();
                vprincipal.Show();
            }
                
            
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
            else
            {
                Left = Left + (e.X - X);
                Top = Top + (e.Y - Y);
            }
        }
    }
}
