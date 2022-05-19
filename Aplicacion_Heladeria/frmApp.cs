using System;
using System.Windows.Forms;

namespace Aplicacion_Heladeria
{
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
