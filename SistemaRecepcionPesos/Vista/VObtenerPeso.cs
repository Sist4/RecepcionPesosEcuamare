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
    public partial class VObtenerPeso : Form
    {
        public VObtenerPeso()
        {
            InitializeComponent();
        }

        private void VObtenerPeso_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Start();
            timer1.Interval = 500;
            materialProgressBar1.Maximum = 2;
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (materialProgressBar1.Value != 2)
            {
                materialProgressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
