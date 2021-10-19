
namespace ProyectoGrupo9.Negocio
{
    partial class frmModificacionParticular
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCambios = new System.Windows.Forms.Button();
            this.btnConfirmarCambios = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAlturaCalle = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.btnCancelarCambios);
            this.groupBox1.Controls.Add(this.btnConfirmarCambios);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(55, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 489);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificacion Datos Paciente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancelarCambios
            // 
            this.btnCancelarCambios.Location = new System.Drawing.Point(244, 458);
            this.btnCancelarCambios.Name = "btnCancelarCambios";
            this.btnCancelarCambios.Size = new System.Drawing.Size(81, 20);
            this.btnCancelarCambios.TabIndex = 13;
            this.btnCancelarCambios.Text = "Cancelar";
            this.btnCancelarCambios.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarCambios
            // 
            this.btnConfirmarCambios.Location = new System.Drawing.Point(336, 458);
            this.btnConfirmarCambios.Name = "btnConfirmarCambios";
            this.btnConfirmarCambios.Size = new System.Drawing.Size(77, 21);
            this.btnConfirmarCambios.TabIndex = 12;
            this.btnConfirmarCambios.Text = "Confirmar ";
            this.btnConfirmarCambios.UseVisualStyleBackColor = true;
            this.btnConfirmarCambios.Click += new System.EventHandler(this.btnAceptarIngreso_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(65, 150);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(276, 20);
            this.txtMail.TabIndex = 11;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 157);
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
            this.groupBox2.Controls.Add(this.lblCalle);
            this.groupBox2.Controls.Add(this.lblProvincia);
            this.groupBox2.Controls.Add(this.lblCiudad);
            this.groupBox2.Location = new System.Drawing.Point(23, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 198);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domicilio";
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
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(10, 130);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 2;
            this.lblCalle.Text = "Calle";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(28, 42);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 1;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(28, 83);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 0;
            this.lblCiudad.Text = "Ciudad";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(1920, 1, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Nacimiento";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(65, 119);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(276, 20);
            this.txtDni.TabIndex = 5;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(6, 126);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(65, 82);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(276, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 85);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apeliido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = " Nombre";
            // 
            // frmModificacionParticular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmModificacionParticular";
            this.Text = "frmModificacionParticular";
            this.Load += new System.EventHandler(this.frmModificacionParticular_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelarCambios;
        private System.Windows.Forms.Button btnConfirmarCambios;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAlturaCalle;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}