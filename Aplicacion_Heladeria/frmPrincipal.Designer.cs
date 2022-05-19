namespace Aplicacion_Heladeria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dtgFactura = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidadCom = new System.Windows.Forms.TextBox();
            this.lblCompras = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDesarrollador = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.picGround = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.picCenter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgFactura
            // 
            this.dtgFactura.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Philosopher", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgFactura.GridColor = System.Drawing.Color.Sienna;
            this.dtgFactura.Location = new System.Drawing.Point(12, 302);
            this.dtgFactura.Name = "dtgFactura";
            this.dtgFactura.Size = new System.Drawing.Size(393, 172);
            this.dtgFactura.TabIndex = 18;
            this.toolTip1.SetToolTip(this.dtgFactura, "Tabla de productos");
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Philosopher", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "N°";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // txtCantidadCom
            // 
            this.txtCantidadCom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCantidadCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadCom.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadCom.Location = new System.Drawing.Point(476, 335);
            this.txtCantidadCom.Name = "txtCantidadCom";
            this.txtCantidadCom.Size = new System.Drawing.Size(67, 25);
            this.txtCantidadCom.TabIndex = 0;
            this.txtCantidadCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtCantidadCom, "Cantidad de compras");
            this.txtCantidadCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEnteros);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.BackColor = System.Drawing.Color.Azure;
            this.lblCompras.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.Location = new System.Drawing.Point(468, 309);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(84, 17);
            this.lblCompras.TabIndex = 7;
            this.lblCompras.Text = "# Compras";
            // 
            // cboProductos
            // 
            this.cboProductos.BackColor = System.Drawing.Color.White;
            this.cboProductos.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Items.AddRange(new object[] {
            "Hielo",
            "Sorbete",
            "Raspado",
            "Posicle",
            "Paleta",
            "Chocobanano",
            "Gelatina"});
            this.cboProductos.Location = new System.Drawing.Point(616, 331);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(126, 25);
            this.cboProductos.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cboProductos, "Productos");
            this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.CambiarItem);
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCantidadProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadProd.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProd.Location = new System.Drawing.Point(748, 331);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(67, 25);
            this.txtCantidadProd.TabIndex = 3;
            this.txtCantidadProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidadProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEnteros);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCambio.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(1162, 349);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(59, 17);
            this.lblCambio.TabIndex = 24;
            this.lblCambio.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(1139, 372);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(100, 25);
            this.txtCambio.TabIndex = 10;
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblEfectivo.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.Location = new System.Drawing.Point(990, 352);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(63, 17);
            this.lblEfectivo.TabIndex = 22;
            this.lblEfectivo.Text = "Efectivo";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEfectivo.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.Location = new System.Drawing.Point(970, 372);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(100, 25);
            this.txtEfectivo.TabIndex = 9;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTotal.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1169, 426);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 17);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1139, 449);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 25);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSubtotal.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(989, 426);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotal.TabIndex = 18;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(970, 449);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 25);
            this.txtSubtotal.TabIndex = 12;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEliminar.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.Location = new System.Drawing.Point(749, 392);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(67, 25);
            this.txtEliminar.TabIndex = 5;
            this.txtEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtEliminar, "Fila a eliminar en base 0");
            this.txtEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEnteros);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(748, 449);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(67, 25);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloTexto);
            // 
            // dtgClientes
            // 
            this.dtgClientes.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Philosopher", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column8,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgClientes.GridColor = System.Drawing.Color.Sienna;
            this.dtgClientes.Location = new System.Drawing.Point(12, 491);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(1172, 206);
            this.dtgClientes.TabIndex = 19;
            this.toolTip1.SetToolTip(this.dtgClientes, "Tabla clientes");
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 141;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tipo de cliente";
            this.Column8.Name = "Column8";
            this.Column8.Width = 141;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 141;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 141;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 141;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cant. Productos";
            this.Column5.Name = "Column5";
            this.Column5.Width = 141;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Efectivo";
            this.Column6.Name = "Column6";
            this.Column6.Width = 141;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cambio";
            this.Column7.Name = "Column7";
            this.Column7.Width = 141;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Azure;
            this.lblFecha.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(967, 302);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 17);
            this.lblFecha.TabIndex = 32;
            this.lblFecha.Text = "lblFecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Azure;
            this.lblHora.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1115, 300);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(57, 17);
            this.lblHora.TabIndex = 33;
            this.lblHora.Text = "lblHora";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Azure;
            this.lblCliente.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(1258, 300);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(73, 17);
            this.lblCliente.TabIndex = 34;
            this.lblCliente.Text = "lblCliente";
            // 
            // Reloj
            // 
            this.Reloj.Enabled = true;
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(1212, 576);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(126, 25);
            this.txtBuscarCliente.TabIndex = 36;
            this.txtBuscarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1222, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Buscar Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBuscarCliente.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources._1472422073_magnifier_glass;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.Location = new System.Drawing.Point(1247, 607);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(51, 48);
            this.btnBuscarCliente.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btnBuscarCliente, "Buscar cliente");
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSalir.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources._1472372679_close_red;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(540, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 48);
            this.btnSalir.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDesarrollador
            // 
            this.btnDesarrollador.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDesarrollador.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources._1472372596_web_code;
            this.btnDesarrollador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesarrollador.FlatAppearance.BorderSize = 0;
            this.btnDesarrollador.Location = new System.Drawing.Point(483, 426);
            this.btnDesarrollador.Name = "btnDesarrollador";
            this.btnDesarrollador.Size = new System.Drawing.Size(51, 48);
            this.btnDesarrollador.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnDesarrollador, "Desarrolladores");
            this.btnDesarrollador.UseVisualStyleBackColor = false;
            this.btnDesarrollador.Click += new System.EventHandler(this.btnDesarrollador_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.BackColor = System.Drawing.Color.PeachPuff;
            this.btnInformacion.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources.helado2;
            this.btnInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.Location = new System.Drawing.Point(426, 426);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(51, 48);
            this.btnInformacion.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnInformacion, "Sobre la App");
            this.btnInformacion.UseVisualStyleBackColor = false;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnIniciar.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources.boton_de_encendido;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.Location = new System.Drawing.Point(483, 366);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(51, 48);
            this.btnIniciar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnIniciar, "Iniciar App");
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBuscar.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources.lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Location = new System.Drawing.Point(821, 426);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 48);
            this.btnBuscar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Producto");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEliminar.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources.cesta;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Location = new System.Drawing.Point(821, 369);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(51, 48);
            this.btnEliminar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar Producto");
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.PeachPuff;
            this.btnNuevoUsuario.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources.agregar_usuario;
            this.btnNuevoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(1279, 426);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(52, 48);
            this.btnNuevoUsuario.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnNuevoUsuario, "Nuevo usuario");
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPagar.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources.bolsa_de_dinero;
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPagar.FlatAppearance.BorderSize = 2;
            this.btnPagar.Location = new System.Drawing.Point(1280, 352);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(51, 48);
            this.btnPagar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnPagar, "Pagar");
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAgregar.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources.mas;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Location = new System.Drawing.Point(821, 309);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(51, 48);
            this.btnAgregar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar Producto");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // picGround
            // 
            this.picGround.Image = global::Aplicacion_Heladeria.Properties.Resources.Heladeria_Fondo;
            this.picGround.Location = new System.Drawing.Point(-81, 289);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(1681, 665);
            this.picGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGround.TabIndex = 8;
            this.picGround.TabStop = false;
            // 
            // picLeft
            // 
            this.picLeft.Image = global::Aplicacion_Heladeria.Properties.Resources.Heladeria_Izq;
            this.picLeft.Location = new System.Drawing.Point(932, -1);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(521, 297);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeft.TabIndex = 3;
            this.picLeft.TabStop = false;
            // 
            // picRight
            // 
            this.picRight.Image = global::Aplicacion_Heladeria.Properties.Resources.Heladeria_Izq;
            this.picRight.Location = new System.Drawing.Point(-103, -1);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(517, 297);
            this.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRight.TabIndex = 2;
            this.picRight.TabStop = false;
            // 
            // picCenter
            // 
            this.picCenter.Image = global::Aplicacion_Heladeria.Properties.Resources.Heladeria;
            this.picCenter.Location = new System.Drawing.Point(405, -1);
            this.picCenter.Name = "picCenter";
            this.picCenter.Size = new System.Drawing.Size(530, 297);
            this.picCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCenter.TabIndex = 0;
            this.picCenter.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDesarrollador);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtCantidadProd);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.txtCantidadCom);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgFactura);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picCenter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "frmPrincipal";
            this.Text = "Formulario principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCenter;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.DataGridView dtgFactura;
        private System.Windows.Forms.TextBox txtCantidadCom;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnDesarrollador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}

