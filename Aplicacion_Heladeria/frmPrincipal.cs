using System;
using System.Windows.Forms;

namespace Aplicacion_Heladeria
{
    public partial class frmPrincipal : Form
    {

        private Random Cliente;
        private int i;
        private frmApp app;
        private frmDesarrollador desarrollador;

        private struct Factura
        {
            public int CantidadProducto;
            public decimal PrecioProducto;
            public string Producto;
        };

        Factura[] FacturaCliente;


        public frmPrincipal()
        {
            InitializeComponent();
            Cliente = new Random();
            this.dtgClientes.Rows.Add("CLI-349", "Mayorista", "03/08/2016", "03:45 p.m.", "C$ 504.23", "16", "C$ 600", "C$ 95.77");
            this.dtgClientes.Rows.Add("CLI-265", "Simple", "04/08/2016", "10:09 a.m.", "C$ 200.12", "10", "C$ 300", "C$ 99.88");
            this.dtgClientes.Rows.Add("CLI-994", "Mayorista", "06/08/2016", "01:23 p.m.", "C$ 472.54", "5", "C$ 500", "C$ 27.46");
            this.dtgClientes.Rows.Add("CLI-124", "Mayorista", "08/08/2016", "08:32 a.m.", "C$ 436.34", "7", "C$ 450", "C$ 43.66");
            this.dtgClientes.Rows.Add("CLI-893", "Mayorista", "09/08/2016", "09:43 a.m.", "C$ 674.88", "2", "C$ 700", "C$ 25.12");
            this.dtgClientes.Rows.Add("CLI-453", "Simple", "09/08/2016", "04:22 p.m.", "C$ 687.22", "5", "C$ 700", "C$ 12.78");
            this.dtgClientes.Rows.Add("CLI-743", "Mayorista", "10/08/2016", "06:32 p.m.", "C$ 353.75", "4", "C$ 400", "C$ 46.25");
            this.dtgClientes.Rows.Add("CLI-231", "Mayorista", "11/08/2016", "11:36 p.m.", "C$ 322.34", "7", "C$ 350", "C$ 27.66");
            this.dtgClientes.Rows.Add("CLI-673", "Mayorista", "11/08/2016", "07:23 p.m.", "C$ 544.32", "12", "C$ 600", "C$ 55.68");
            this.dtgClientes.Rows.Add("CLI-554", "Simple", "12/08/2016", "05:12 p.m.", "C$ 400.75", "6", "C$ 600", "C$ 199.25");
            this.dtgClientes.Rows.Add("CLI-210", "Mayorista", "24/08/2016", "10:11 a.m.", "C$ 508.56", "9", "C$ 600", "C$ 91.44");
        }

        public int Indice
        {
            get { return i; }
            set { i = (value < 0) ? 0 : value; }
        }

        private void SoloEnteros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) { e.Handled = true; return; }
        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            this.lblCliente.Text = "CLI-" + Convert.ToString(Cliente.Next(97, 1998));
            this.txtTotal.Text = string.Format("{0:C}", 0.0);
            this.txtSubtotal.Text = string.Format("{0:C}", 0.0);
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            this.lblFecha.Text = DateTime.Today.ToShortDateString();
            this.lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        public decimal Subtotal()
        {
            decimal sub = 0.0m;

            for (int i = 0; i < this.dtgFactura.RowCount - 1; i++) { sub += Convert.ToDecimal(this.dtgFactura[2, i].Value.ToString()) * Convert.ToDecimal(this.dtgFactura[3, i].Value.ToString()); }

            return sub;
        }

        public void MostrarTotales(string producto, int cantidad, decimal precio)
        {
            FacturaCliente[Indice].Producto = producto;
            FacturaCliente[Indice].CantidadProducto = cantidad;
            FacturaCliente[Indice].PrecioProducto = precio;
            this.dtgFactura.Rows.Add(Indice + 1, producto, precio, cantidad);

            this.txtSubtotal.Text = string.Format("{0:C}", Subtotal());
            this.txtTotal.Text = string.Format("{0:C}", Subtotal() * 1.15m);
            this.txtCantidadProd.Clear(); this.txtCantidadProd.Focus();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(txtCantidadProd.Text) || "".Equals(cboProductos.Text))
                {
                    MessageBox.Show("No pueden existir campos vacíos.\nInténtelo de nuevo.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtCantidadProd.Focus();
                }
                else
                {
                    switch (this.cboProductos.SelectedItem.ToString())
                    {

                        case "Hielo": MostrarTotales("Hielo", Convert.ToInt32(this.txtCantidadProd.Text), 2.00m); break;

                        case "Sorbete": MostrarTotales("Sorbete", Convert.ToInt32(this.txtCantidadProd.Text), 35.00m); break;

                        case "Raspado": MostrarTotales("Sorbete", Convert.ToInt32(this.txtCantidadProd.Text), 45.00m); break;

                        case "Posicle": MostrarTotales("Posicle", Convert.ToInt32(this.txtCantidadProd.Text), 20.00m); break;

                        case "Paleta": MostrarTotales("Paleta", Convert.ToInt32(this.txtCantidadProd.Text), 18.00m); break;

                        case "Chocobanano": MostrarTotales("Chocobanano", Convert.ToInt32(this.txtCantidadProd.Text), 20.00m); break;

                        case "Gelatina": MostrarTotales("Gelatina", Convert.ToInt32(this.txtCantidadProd.Text), 25.00m); break;

                        default:

                            break;
                    }
                    Indice++;
                    if (Indice == FacturaCliente.Length)
                    {
                        MessageBox.Show(string.Format("El cliente {0} ha realizado exitosamente sus {1} compras.\n¡Muchas gracias!", this.lblCliente.Text, this.FacturaCliente.Length), "Gracias por su compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtCantidadCom.Enabled = true;
                        this.btnIniciar.Enabled = true;
                        this.txtEfectivo.Focus();

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido lo suguiente:" + ex.Message, "Botón Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(txtCantidadCom.Text))
                {
                    MessageBox.Show("Ingrese por favor una cantidad.");
                    this.txtCantidadCom.Focus();
                }
                else
                {
                    Indice = 0;
                    FacturaCliente = new Factura[Convert.ToInt32(this.txtCantidadCom.Text)];
                    this.txtCantidadCom.Clear();
                    this.txtCantidadCom.Enabled = false;
                    this.btnIniciar.Enabled = false;
                    this.cboProductos.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido lo suguiente:" + ex.Message, "Botón Iniciar", MessageBoxButtons.OK, MessageBoxIcon.Information); ; }
        }

        private void CambiarItem(object sender, EventArgs e)
        {
            this.txtCantidadProd.Focus();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(this.txtEfectivo.Text))
                {
                    MessageBox.Show("Ha ocurrido un error con el efectivo.\nInténtalo de nuevo.");
                    this.txtEfectivo.Clear();
                    this.txtEfectivo.Focus();
                }
                else
                {
                    this.txtTotal.Text = string.Format("{0}", Subtotal() * 1.15m);
                    if (Convert.ToDecimal(this.txtTotal.Text) == 0.0m || Convert.ToDecimal(this.txtEfectivo.Text) < Convert.ToDecimal(this.txtTotal.Text))
                    {
                        this.txtTotal.Text = string.Format("{0:C}", Subtotal() * 1.15m);
                        MessageBox.Show("Hay un error, inténtelo de nuevo.");
                        this.txtEfectivo.Clear(); this.txtEfectivo.Focus();
                    }
                    else
                    {
                        if (Convert.ToDecimal(this.txtEfectivo.Text) > Convert.ToDecimal(this.txtTotal.Text))
                        {
                            this.txtCambio.Text = string.Format("{0:C}", decimal.Parse(this.txtEfectivo.Text) - decimal.Parse(this.txtTotal.Text));
                            this.txtTotal.Text = string.Format("{0:C}", Subtotal() * 1.15m);
                            MessageBox.Show("¡Gracias por su compra!\nVuelva pronto.", "Gracias por su compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            this.txtCambio.Text = string.Format("{0:C}", 0.0m);
                            this.txtTotal.Text = string.Format("{0:C}", Subtotal() * 1.15m);
                            MessageBox.Show("¡Gracias por su compra!\nVuelva pronto.", "Gracias por su compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido lo suguiente:" + ex.Message, "Botón Pagar", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == MessageBox.Show("¿Desea establecer un nuevo cliente?", "Nuevo cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    int cantidad = 0;
                    for (int i = 0; i < FacturaCliente.Length; i++) { cantidad += FacturaCliente[i].CantidadProducto; }
                    this.txtTotal.Text = string.Format("{0}", Subtotal() * 1.15m);

                    if (Convert.ToDecimal(this.txtTotal.Text) >= 700.00m)
                    {
                        this.txtTotal.Text = string.Format("{0:C}", Subtotal() * 1.15m);
                        MessageBox.Show("Usted es un cliente mayorista,\nha sido ingresado en el sistema.", "Cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dtgClientes.Rows.Add(this.lblCliente.Text, "Mayorista", this.lblFecha.Text, this.lblHora.Text, this.txtTotal.Text, cantidad, "C$ " + this.txtEfectivo.Text, this.txtCambio.Text);
                    }
                    else
                    {
                        this.txtTotal.Text = string.Format("{0:C}", Subtotal() * 1.15m);
                        MessageBox.Show("Usted es un cliente simple,\nle mostraremos su factura y lo ingresaremos al sistema.", "Cliente simple", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dtgClientes.Rows.Add(this.lblCliente.Text, "Simple", this.lblFecha.Text, this.lblHora.Text, this.txtTotal.Text, cantidad, "C$ " + this.txtEfectivo.Text, this.txtCambio.Text);
                        MessageBox.Show(string.Format("CLIENTE: \t\t{0}\nTIPO DE CLIENTE: \t{1}\nFECHA: \t\t{2}\nHORA: \t\t{3}\nTOTAL: \t\t{4}\nCANT. PRODUCTOS: {5}\nEFECTIVO: \t{6}\nCAMBIO: \t\t{7}",
                            this.lblCliente.Text, "Simple", this.lblFecha.Text, this.lblHora.Text, this.txtTotal.Text, cantidad, "C$ " + this.txtEfectivo.Text, this.txtCambio.Text), "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.lblCliente.Text = "CLI-" + Convert.ToString(Cliente.Next(97, 1998));
                    this.txtEfectivo.Clear();
                    this.txtCambio.Clear();
                    this.dtgFactura.Rows.Clear();
                    this.txtTotal.Text = string.Format("{0:C}", 0.0m);
                    this.txtSubtotal.Text = string.Format("{0:C}", 0.0m);
                    this.txtCantidadCom.Focus();
                }
                else { this.txtCantidadCom.Focus(); }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido lo suguiente:" + ex.Message, "Botón Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        public void Secuencia()
        {
            for (int i = 0; i < this.dtgFactura.RowCount - 1; i++) { this.dtgFactura[0, i].Value = i + 1; }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(txtEliminar.Text))
                {
                    MessageBox.Show("Este campo no puede estar vacío.\nInténtelo de nuevo.", "Campo vacío",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtEliminar.Clear(); this.txtEliminar.Focus();
                }
                else
                {
                    dtgFactura.Rows.RemoveAt(Convert.ToInt32(txtEliminar.Text));
                    FacturaCliente[Convert.ToInt32(txtEliminar.Text)].CantidadProducto = 0;
                    FacturaCliente[Convert.ToInt32(txtEliminar.Text)].PrecioProducto = 0.0m;
                    FacturaCliente[Convert.ToInt32(txtEliminar.Text)].Producto = "";
                    Secuencia();
                    this.txtTotal.Text = string.Format("{0:C}", Subtotal() * 1.15m);
                    this.txtSubtotal.Text = string.Format("{0:C}", Subtotal());
                    this.txtEliminar.Clear(); this.btnEliminar.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido lo suguiente:" + ex.Message, "Botón Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(this.txtBuscar.Text)) { MessageBox.Show("Ingrese el elemento a buscar.", "Elemento a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { Buscar(FacturaCliente, FacturaCliente.Length, this.txtBuscar.Text); }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido lo suguiente:" + ex.Message, "Botón Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        private void Buscar(Factura[] arregloFactura, int longitud, string elementoBuscar) // Aquí se aplica el algoritmo de búsqueda desordenada
        {
            int i = 0;
            while ((i < longitud) && (arregloFactura[i].Producto != elementoBuscar))
                i++;

            if (i == longitud)
            {
                MessageBox.Show(string.Format("El producto {0} no está en la factura.", elementoBuscar), "Elemento no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBuscar.Clear(); this.txtBuscar.Focus();
            }
            else
            {
                MessageBox.Show(string.Format("El producto {0} se encuentra en la fila {1}", elementoBuscar, i + 1), "Elemento encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBuscar.Clear(); this.txtBuscar.Focus();
            }
        }
        //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬

        private void Buscar(DataGridView arregloCliente, string elementoBuscar) // Aquí se aplica el algoritmo de búsqueda desordenada
        {
            /*Aquí habrá una ligera variación del algoritmo por tratarse de un arreglo bidimensional*/

            int j = 0;
            while (j < arregloCliente.RowCount && !elementoBuscar.Equals(arregloCliente[0, j].Value.ToString())) // para recorrer las filas
            {
                    j++;
            }

            if (j == arregloCliente.RowCount)
            {
                MessageBox.Show(string.Format("No se encontró elemento {0}", elementoBuscar), "Elemento encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBuscarCliente.Clear(); this.txtBuscarCliente.Focus();
            }
            else
            {
                MessageBox.Show(string.Format("El elemento {0} se encuentra la fila {1}.", elementoBuscar, j+1), "Elemento encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBuscarCliente.Clear(); this.txtBuscarCliente.Focus();
            }

        }

        private void SoloTexto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
                return;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(this.txtBuscarCliente.Text))
                {
                    MessageBox.Show("Ingrese por favor un elemento a buscar", "Elemento a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtBuscarCliente.Focus();
                }
                else
                {
                    Buscar(dtgClientes, this.txtBuscarCliente.Text);
                    this.txtBuscarCliente.Clear(); this.txtBuscarCliente.Focus();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Ha ocurrido lo suguiente:" + ex.Message, "Botón Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBuscarCliente.Clear(); this.txtBuscarCliente.Focus();
            }
        }

        private void Cambiar(object sender, EventArgs e)
        {
            this.txtBuscarCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            app = new frmApp();
            app.Show();
        }

        private void btnDesarrollador_Click(object sender, EventArgs e)
        {
            desarrollador = new frmDesarrollador();
            desarrollador.Show();
        }
    }
}