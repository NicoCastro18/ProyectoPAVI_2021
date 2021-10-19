
namespace ProyectoGrupo9
{
    partial class frmRegistrarPaciente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboObra = new System.Windows.Forms.ComboBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.btnCancelarIngreso = new System.Windows.Forms.Button();
            this.btnAceptarIngreso = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAlturaCalle = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboObra);
            this.groupBox1.Controls.Add(this.lblObraSocial);
            this.groupBox1.Controls.Add(this.btnCancelarIngreso);
            this.groupBox1.Controls.Add(this.btnAceptarIngreso);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Datos Pacientes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboObra
            // 
            this.cboObra.FormattingEnabled = true;
            this.cboObra.Location = new System.Drawing.Point(161, 147);
            this.cboObra.Name = "cboObra";
            this.cboObra.Size = new System.Drawing.Size(244, 21);
            this.cboObra.TabIndex = 15;
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(33, 155);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(72, 13);
            this.lblObraSocial.TabIndex = 14;
            this.lblObraSocial.Text = "Obra Social(*)";
            // 
            // btnCancelarIngreso
            // 
            this.btnCancelarIngreso.Location = new System.Drawing.Point(244, 458);
            this.btnCancelarIngreso.Name = "btnCancelarIngreso";
            this.btnCancelarIngreso.Size = new System.Drawing.Size(81, 20);
            this.btnCancelarIngreso.TabIndex = 13;
            this.btnCancelarIngreso.Text = "Cancelar";
            this.btnCancelarIngreso.UseVisualStyleBackColor = true;
            this.btnCancelarIngreso.Click += new System.EventHandler(this.btnCancelarIngreso_Click);
            // 
            // btnAceptarIngreso
            // 
            this.btnAceptarIngreso.Location = new System.Drawing.Point(336, 458);
            this.btnAceptarIngreso.Name = "btnAceptarIngreso";
            this.btnAceptarIngreso.Size = new System.Drawing.Size(77, 21);
            this.btnAceptarIngreso.TabIndex = 12;
            this.btnAceptarIngreso.Text = "Registrar";
            this.btnAceptarIngreso.UseVisualStyleBackColor = true;
            this.btnAceptarIngreso.Click += new System.EventHandler(this.btnAceptarIngreso_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(161, 178);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(244, 20);
            this.txtMail.TabIndex = 11;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(33, 185);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAlturaCalle);
            this.groupBox2.Controls.Add(this.lblAltura);
            this.groupBox2.Controls.Add(this.txtCalle);
            this.groupBox2.Controls.Add(this.cboProvincia);
            this.groupBox2.Controls.Add(this.cboCiudad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblProvincia);
            this.groupBox2.Controls.Add(this.lblCiudad);
            this.groupBox2.Location = new System.Drawing.Point(23, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 198);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domicilio";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtAlturaCalle
            // 
            this.txtAlturaCalle.Location = new System.Drawing.Point(275, 123);
            this.txtAlturaCalle.Name = "txtAlturaCalle";
            this.txtAlturaCalle.Size = new System.Drawing.Size(115, 20);
            this.txtAlturaCalle.TabIndex = 7;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(218, 130);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(59, 123);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(136, 20);
            this.txtCalle.TabIndex = 5;
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(91, 34);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(267, 21);
            this.cboProvincia.TabIndex = 4;
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(91, 75);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(268, 21);
            this.cboCiudad.TabIndex = 3;
            this.cboCiudad.SelectedIndexChanged += new System.EventHandler(this.cboCiudad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(28, 42);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(61, 13);
            this.lblProvincia.TabIndex = 1;
            this.lblProvincia.Text = "Provincia(*)";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(28, 83);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(50, 13);
            this.lblCiudad.TabIndex = 0;
            this.lblCiudad.Text = "Ciudad(*)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(1920, 1, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Nacimiento";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(161, 116);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(244, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(33, 119);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(36, 13);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI(*)";
            this.lblDNI.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(161, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(244, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(33, 78);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apeliido(*)";
            this.lblApellido.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre(*)";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmRegistrarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 500);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Pacientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtAlturaCalle;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnCancelarIngreso;
        private System.Windows.Forms.Button btnAceptarIngreso;
        private System.Windows.Forms.ComboBox cboObra;
        private System.Windows.Forms.Label lblObraSocial;
    }
}

