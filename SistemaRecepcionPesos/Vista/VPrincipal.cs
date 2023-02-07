using MaterialSkin;
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
    public partial class VPrincipal : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkin.MaterialSkinManager skinManager;
        USUARIO usuarioActual;
        public VPrincipal(USUARIO usuario)
        {
            this.usuarioActual = usuario;
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Indigo700,
                Primary.Indigo900,Primary.BlueGrey300,Accent.DeepOrange700, TextShade.WHITE);
            
            InitializeComponent();
            if(usuario.USU_ROL.Equals("Operador"))
            {
                ((Control)this.tbConfiguracion).Enabled = false;
                ((Control)this.tbUsuarios).Enabled = false;
                //tbConfiguracion.
            }
            
        }
        private void AbrirFormHijo(object formhijo, TabPage tabpage)
        {
            if (tabpage.Controls.Count > 0)
            {
                tabpage.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            tabpage.Controls.Add(fh);
            tabpage.Tag = fh;
            fh.Show();
        }

        private void tbUsuarios_Enter(object sender, EventArgs e)
        {
            AbrirFormHijo(new VUsuarios(), tbUsuarios);
        }

        private void tbRecepcion_Enter(object sender, EventArgs e)
        {
            AbrirFormHijo(new VRecepcion(usuarioActual), tbRecepcion);
        }

        private void tbTickets_Enter(object sender, EventArgs e)
        {
            AbrirFormHijo(new VTickets(), tbTickets);
        }

        private void tbProveedores_Enter(object sender, EventArgs e)
        {
            AbrirFormHijo(new VProveedores(), tbProveedores);
        }

        private void tbMateriales_Enter(object sender, EventArgs e)
        {
            AbrirFormHijo(new VMateriales(), tbMateriales);
        }

        private void tbConfiguracion_Enter(object sender, EventArgs e)
        {
            AbrirFormHijo(new VConfiguracion(), tbConfiguracion);
        }

        private void tbAcerca_Enter(object sender, EventArgs e)
        {
            AbrirFormHijo(new VAcerca(), tbAcerca);
        }

        private void tbSalir_Enter(object sender, EventArgs e)
        {
            this.Hide();
            VLogin vlogin = new VLogin();
            vlogin.FormClosed += (s, args) => this.Close();
            vlogin.Show();
        }
    }
}
