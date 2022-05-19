namespace Aplicacion_Heladeria
{
    partial class frmBienvenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDesarrollador = new System.Windows.Forms.Button();
            this.btnApp = new System.Windows.Forms.Button();
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.picFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Philosopher", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(162, 334);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 36);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloTexto);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Philosopher", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(162, 413);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = 'X';
            this.txtContraseña.Size = new System.Drawing.Size(220, 39);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumero);
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFechaHora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.ForeColor = System.Drawing.Color.Black;
            this.lblFechaHora.Image = global::Aplicacion_Heladeria.Properties.Resources.Heladeria_Fondo;
            this.lblFechaHora.Location = new System.Drawing.Point(643, 478);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(142, 22);
            this.lblFechaHora.TabIndex = 23;
            this.lblFechaHora.Text = "Fecha y hora: ";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblContraseña.Font = new System.Drawing.Font("Philosopher", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Image = ((System.Drawing.Image)(resources.GetObject("lblContraseña.Image")));
            this.lblContraseña.Location = new System.Drawing.Point(37, 421);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(111, 22);
            this.lblContraseña.TabIndex = 22;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUsuario.Font = new System.Drawing.Font("Philosopher", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.Location = new System.Drawing.Point(53, 343);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(78, 22);
            this.lblUsuario.TabIndex = 21;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnIngresar.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources._1472426600_key_safety_lock_unlock_safe_access;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.Location = new System.Drawing.Point(414, 354);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(83, 82);
            this.btnIngresar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnIngresar, "Ingresar al sistema");
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSalir.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources._1472372679_close_red;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(836, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 82);
            this.btnSalir.TabIndex = 19;
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
            this.btnDesarrollador.Location = new System.Drawing.Point(747, 354);
            this.btnDesarrollador.Name = "btnDesarrollador";
            this.btnDesarrollador.Size = new System.Drawing.Size(83, 82);
            this.btnDesarrollador.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnDesarrollador, "Desarrolladores");
            this.btnDesarrollador.UseVisualStyleBackColor = false;
            this.btnDesarrollador.Click += new System.EventHandler(this.btnDesarrollador_Click);
            // 
            // btnApp
            // 
            this.btnApp.BackColor = System.Drawing.Color.PeachPuff;
            this.btnApp.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources.helado2;
            this.btnApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApp.FlatAppearance.BorderSize = 0;
            this.btnApp.Location = new System.Drawing.Point(658, 354);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(83, 82);
            this.btnApp.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnApp, "Sobre la App");
            this.btnApp.UseVisualStyleBackColor = false;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // picTitulo
            // 
            this.picTitulo.BackgroundImage = global::Aplicacion_Heladeria.Properties.Resources.Heladeria_Fondo;
            this.picTitulo.Image = global::Aplicacion_Heladeria.Properties.Resources.Bienvenida_Heladeria;
            this.picTitulo.Location = new System.Drawing.Point(0, 12);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(1007, 292);
            this.picTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTitulo.TabIndex = 1;
            this.picTitulo.TabStop = false;
            // 
            // picFondo
            // 
            this.picFondo.Image = global::Aplicacion_Heladeria.Properties.Resources.Heladeria_Fondo;
            this.picFondo.Location = new System.Drawing.Point(0, -1);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(1018, 504);
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1019, 501);
            this.ControlBox = false;
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDesarrollador);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picTitulo);
            this.Controls.Add(this.picFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBienvenida";
            this.Text = "Heladería: Copito de nieve";
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDesarrollador;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Timer Tiempo;
    }
}