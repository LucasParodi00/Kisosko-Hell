using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Utilidades
{
    public partial class mdCompras : Form
    {
        public Compra _Compra { get; set; }


        public mdCompras()
        {
            InitializeComponent();
        }

        private void mdCompras_Load(object sender, EventArgs e)
        {

        }
    }
}
