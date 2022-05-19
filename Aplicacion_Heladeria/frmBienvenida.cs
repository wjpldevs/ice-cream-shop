using System;
using System.Threading;
using System.Windows.Forms;

namespace Aplicacion_Heladeria
{
    public partial class frmBienvenida : Form
    {
        private frmPrincipal principal;
        private frmApp app;
        private frmDesarrollador desarrollador;
        
        private int contador;

        public frmBienvenida()
        {
            InitializeComponent();
            Contador = 0;
        }

        public int Contador
        {
            get { return contador; }
            set { contador = value; }
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            this.lblFechaHora.Text = string.Format("Fecha y hora: "+DateTime.Now.ToString());
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(txtContraseña.Text) || "".Equals(txtUsuario.Text))
                {
                    MessageBox.Show("Ingrese su usuario o contraseña", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtUsuario.Focus();
                }
                else
                {
                    if (txtContraseña.Text == "1234")
                    {
                        this.Hide();
                        this.txtContraseña.Clear(); this.txtUsuario.Clear(); this.txtUsuario.Focus();
                        principal = new frmPrincipal();
                        principal.Show();
                        
                    }
                    else
                    {
                        Contador++;
                        if (Contador == 3)
                        {
                            for (int i = 10; i >= 1; i--)
                            {
                                this.txtContraseña.Enabled = false;
                                this.txtUsuario.Enabled = false;
                                this.btnIngresar.Enabled = false;
                                Thread.Sleep(1000);
                            }
                        }
                        this.txtContraseña.Enabled = true;
                        this.txtUsuario.Enabled = true;
                        this.btnIngresar.Enabled = true;
                        this.txtUsuario.Clear(); this.txtContraseña.Clear(); this.txtUsuario.Focus();
                    }
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Ha ocurrido lo siguiente al ingresar: " + ex.Message, "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUsuario.Clear();
                this.txtContraseña.Clear();
                this.txtUsuario.Focus();
            }
        }

        private void SoloTexto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; return;
            }
        }

        private void SoloNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; return;
            }
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            app = new frmApp();
            app.Show();
        }

        private void btnDesarrollador_Click(object sender, EventArgs e)
        {
            desarrollador = new frmDesarrollador();
            desarrollador.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
