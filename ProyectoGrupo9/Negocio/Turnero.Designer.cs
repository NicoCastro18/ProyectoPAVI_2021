
namespace ProyectoGrupo9.Negocio
{
    partial class Turnero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turnero));
            this.lblDni = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboMedico = new System.Windows.Forms.ComboBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cboEstudio = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBucar = new System.Windows.Forms.Button();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.colum_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fechaNaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboHora = new System.Windows.Forms.Label();
            this.cboHoras = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cboCosto = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(27, 21);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(68, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Dni Paciente";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(423, 247);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(52, 13);
            this.lblMedico.TabIndex = 1;
            this.lblMedico.Text = "Medico(*)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 2;
            // 
            // cboMedico
            // 
            this.cboMedico.FormattingEnabled = true;
            this.cboMedico.Location = new System.Drawing.Point(486, 239);
            this.cboMedico.Name = "cboMedico";
            this.cboMedico.Size = new System.Drawing.Size(225, 21);
            this.cboMedico.TabIndex = 3;
            this.cboMedico.SelectedIndexChanged += new System.EventHandler(this.cboMedico_SelectedIndexChanged);
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(39, 396);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(62, 13);
            this.lblObraSocial.TabIndex = 4;
            this.lblObraSocial.Text = "Obra Social";
            // 
            // txtObraSocial
            // 
            this.txtObraSocial.Location = new System.Drawing.Point(116, 388);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(263, 20);
            this.txtObraSocial.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.Location = new System.Drawing.Point(773, 431);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 47);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(41, 247);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(52, 13);
            this.lblEspecialidad.TabIndex = 7;
            this.lblEspecialidad.Text = "Estudio(*)";
            // 
            // cboEstudio
            // 
            this.cboEstudio.FormattingEnabled = true;
            this.cboEstudio.Location = new System.Drawing.Point(116, 239);
            this.cboEstudio.Name = "cboEstudio";
            this.cboEstudio.Size = new System.Drawing.Size(263, 21);
            this.cboEstudio.TabIndex = 8;
            this.cboEstudio.SelectedIndexChanged += new System.EventHandler(this.cboEstudio_SelectedIndexChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(423, 347);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha(*)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.btnBucar);
            this.groupBox1.Controls.Add(this.dgvPaciente);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 223);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Paciente";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSeleccionar.Location = new System.Drawing.Point(661, 187);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(102, 26);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnBucar
            // 
            this.btnBucar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBucar.Location = new System.Drawing.Point(414, 11);
            this.btnBucar.Name = "btnBucar";
            this.btnBucar.Size = new System.Drawing.Size(75, 23);
            this.btnBucar.TabIndex = 4;
            this.btnBucar.Text = "Buscar";
            this.btnBucar.UseVisualStyleBackColor = false;
            this.btnBucar.Click += new System.EventHandler(this.btnBucar_Click);
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.AllowUserToAddRows = false;
            this.dgvPaciente.AllowUserToDeleteRows = false;
            this.dgvPaciente.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_DNI,
            this.colum_Nombre,
            this.colum_Apellido,
            this.colum_Provincia,
            this.colum_Ciudad,
            this.colum_ObraSocial,
            this.colum_Calle,
            this.colum_Altura,
            this.colum_fechaNaci,
            this.colum_Mail});
            this.dgvPaciente.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvPaciente.Location = new System.Drawing.Point(30, 40);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.ReadOnly = true;
            this.dgvPaciente.Size = new System.Drawing.Size(818, 141);
            this.dgvPaciente.TabIndex = 3;
            this.dgvPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaciente_CellClick);
            // 
            // colum_DNI
            // 
            this.colum_DNI.HeaderText = "DNI";
            this.colum_DNI.Name = "colum_DNI";
            this.colum_DNI.ReadOnly = true;
            this.colum_DNI.Width = 80;
            // 
            // colum_Nombre
            // 
            this.colum_Nombre.HeaderText = "Nombre";
            this.colum_Nombre.Name = "colum_Nombre";
            this.colum_Nombre.ReadOnly = true;
            // 
            // colum_Apellido
            // 
            this.colum_Apellido.HeaderText = "Apellido";
            this.colum_Apellido.Name = "colum_Apellido";
            this.colum_Apellido.ReadOnly = true;
            // 
            // colum_Provincia
            // 
            this.colum_Provincia.HeaderText = "Provincia";
            this.colum_Provincia.Name = "colum_Provincia";
            this.colum_Provincia.ReadOnly = true;
            this.colum_Provincia.Width = 60;
            // 
            // colum_Ciudad
            // 
            this.colum_Ciudad.HeaderText = "Ciudad";
            this.colum_Ciudad.Name = "colum_Ciudad";
            this.colum_Ciudad.ReadOnly = true;
            this.colum_Ciudad.Width = 50;
            // 
            // colum_ObraSocial
            // 
            this.colum_ObraSocial.HeaderText = "Obra Social";
            this.colum_ObraSocial.Name = "colum_ObraSocial";
            this.colum_ObraSocial.ReadOnly = true;
            this.colum_ObraSocial.Width = 50;
            // 
            // colum_Calle
            // 
            this.colum_Calle.HeaderText = "Calle";
            this.colum_Calle.Name = "colum_Calle";
            this.colum_Calle.ReadOnly = true;
            // 
            // colum_Altura
            // 
            this.colum_Altura.HeaderText = "Altura";
            this.colum_Altura.Name = "colum_Altura";
            this.colum_Altura.ReadOnly = true;
            this.colum_Altura.Width = 50;
            // 
            // colum_fechaNaci
            // 
            this.colum_fechaNaci.HeaderText = "Fecha Nacimiento";
            this.colum_fechaNaci.Name = "colum_fechaNaci";
            this.colum_fechaNaci.ReadOnly = true;
            // 
            // colum_Mail
            // 
            this.colum_Mail.HeaderText = "Mail";
            this.colum_Mail.Name = "colum_Mail";
            this.colum_Mail.ReadOnly = true;
            this.colum_Mail.Width = 80;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(486, 341);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // cboHora
            // 
            this.cboHora.AutoSize = true;
            this.cboHora.Location = new System.Drawing.Point(423, 396);
            this.cboHora.Name = "cboHora";
            this.cboHora.Size = new System.Drawing.Size(40, 13);
            this.cboHora.TabIndex = 12;
            this.cboHora.Text = "Hora(*)";
            // 
            // cboHoras
            // 
            this.cboHoras.FormattingEnabled = true;
            this.cboHoras.Location = new System.Drawing.Point(486, 388);
            this.cboHoras.Name = "cboHoras";
            this.cboHoras.Size = new System.Drawing.Size(225, 21);
            this.cboHoras.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 298);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 291);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(423, 294);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(40, 13);
            this.lblEquipo.TabIndex = 16;
            this.lblEquipo.Text = "Equipo";
            // 
            // cboEquipo
            // 
            this.cboEquipo.FormattingEnabled = true;
            this.cboEquipo.Location = new System.Drawing.Point(486, 294);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(225, 21);
            this.cboEquipo.TabIndex = 17;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(41, 431);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(44, 13);
            this.lblCosto.TabIndex = 18;
            this.lblCosto.Text = "Costo(*)";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(673, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 47);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(41, 348);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(118, 341);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(260, 20);
            this.txtApellido.TabIndex = 22;
            // 
            // cboCosto
            // 
            this.cboCosto.FormattingEnabled = true;
            this.cboCosto.Location = new System.Drawing.Point(116, 428);
            this.cboCosto.Name = "cboCosto";
            this.cboCosto.Size = new System.Drawing.Size(262, 21);
            this.cboCosto.TabIndex = 23;
            // 
            // Turnero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(878, 490);
            this.Controls.Add(this.cboCosto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.cboEquipo);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboHoras);
            this.Controls.Add(this.cboHora);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cboEstudio);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtObraSocial);
            this.Controls.Add(this.lblObraSocial);
            this.Controls.Add(this.cboMedico);
            this.Controls.Add(this.lblMedico);
            this.Name = "Turnero";
            this.Text = "Turnero";
            this.Load += new System.EventHandler(this.Turnero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboMedico;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.TextBox txtObraSocial;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cboEstudio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label cboHora;
        private System.Windows.Forms.ComboBox cboHoras;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_ObraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_fechaNaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Mail;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBucar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cboCosto;
    }
}