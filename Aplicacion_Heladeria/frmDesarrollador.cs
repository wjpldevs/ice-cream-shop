using System;
using System.Text;
using System.Windows.Forms;

namespace Aplicacion_Heladeria
{
    public partial class frmDesarrollador : Form
    {
        public frmDesarrollador()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkTwitter.LinkVisited = true;
            System.Diagnostics.Process.Start("chrome.exe", "https://twitter.com/wilmerfiliporo");
        }
    }
}
