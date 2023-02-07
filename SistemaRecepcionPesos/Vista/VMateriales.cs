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
    public partial class VMateriales : Form
    {
        MaterialController controlador = new MaterialController();
        MATERIAL materialPorEditar;
        public VMateriales()
        {
            InitializeComponent();
        }

        private void LlenarMateriales()
        {
            lstMateriales.Items.Clear();
            foreach (MATERIAL material in controlador.ObtenerMateriales())
            {
                ListViewItem item = new ListViewItem(material.MAT_ID.ToString());
                item.SubItems.Add(material.MAT_NOMBRE);


                lstMateriales.Items.Add(item);
            }
        }

        private void tbMaterial_Enter(object sender, EventArgs e)
        {
            LlenarMateriales();
        }

        private void VMateriales_Load(object sender, EventArgs e)
        {
            LlenarMateriales();
            NuevoMaterial();
        }


        private void tbMateriales_Enter(object sender, EventArgs e)
        {
            LlenarMateriales();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(CamposLlenos())
                {
                    MATERIAL material = new MATERIAL();
                    material.MAT_NOMBRE = txtNombre.Text;
                    controlador.GuardarMaterial(material);
                    MessageBox.Show("¡Guardado Exitoso!");
                    NuevoMaterial();
                    LlenarMateriales();
                }
                else
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("¡No se pudo guardar el material!");
            }

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NuevoMaterial();
        }

        private void NuevoMaterial()
        {
            txtNombre.Text = string.Empty;
            btnGuardarEditado.Visible = false;
        }
        private void CargarMaterialPorEditar(MATERIAL material)
        {
            txtNombre.Text = material.MAT_NOMBRE;
        }
        private bool CamposLlenos()
        {
            if(string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnGuardarEditado_Click(object sender, EventArgs e)
        {
            if (CamposLlenos())
            {
                try
                {
                    if (controlador.ActualizarMaterial(materialPorEditar, txtNombre.Text))
                    {
                        MessageBox.Show("¡Guardado Exitoso!");
                        NuevoMaterial();
                        LlenarMateriales();
                    }
                    else
                    {
                        MessageBox.Show("¡No se pudo actualizar el material!");
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMateriales.SelectedItems.Count > 0)
            {
                ListViewItem item = lstMateriales.SelectedItems[0];

                if(controlador.ExisteMaterialEnTicket(Convert.ToInt32(item.SubItems[0].Text)))
                {
                    MessageBox.Show("No se puede editar un material que ya fue utilizado en un ticket");
                }
                else
                {
                    btnGuardarEditado.Visible = true;
                    materialPorEditar = controlador.ObtenerMaterialPorId(Convert.ToInt32(item.SubItems[0].Text));
                    CargarMaterialPorEditar(materialPorEditar);

                }

            }
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMateriales.SelectedItems.Count > 0)
            {
                ListViewItem item = lstMateriales.SelectedItems[0];

                if (controlador.ExisteMaterialEnTicket(Convert.ToInt32(item.SubItems[0].Text)))
                {
                    MessageBox.Show("No se puede eliminar un material que ya fue utilizado en un ticket");
                }
                else
                {
                    controlador.EliminarMaterial(Convert.ToInt32(item.SubItems[0].Text));
                    MessageBox.Show("¡Guardado Exitoso!");
                    NuevoMaterial();
                    LlenarMateriales();

                }

            }
        }
    }
}
