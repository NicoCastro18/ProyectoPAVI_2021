namespace ProyectoGrupo9.Negocio
{
    partial class frmRegistrarMedico
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefonoMed = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblApeMedico = new System.Windows.Forms.Label();
            this.lblNombreMed = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtHonorarios = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblHonorarios = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblTelefonoMed);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.lblApeMedico);
            this.groupBox1.Controls.Add(this.lblNombreMed);
            this.groupBox1.Location = new System.Drawing.Point(45, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(166, 160);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(185, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(166, 116);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(185, 20);
            this.txtMail.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(166, 74);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTelefonoMed
            // 
            this.lblTelefonoMed.AutoSize = true;
            this.lblTelefonoMed.Location = new System.Drawing.Point(43, 167);
            this.lblTelefonoMed.Name = "lblTelefonoMed";
            this.lblTelefonoMed.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoMed.TabIndex = 3;
            this.lblTelefonoMed.Text = "Telefono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(43, 123);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail";
            // 
            // lblApeMedico
            // 
            this.lblApeMedico.AutoSize = true;
            this.lblApeMedico.Location = new System.Drawing.Point(43, 81);
            this.lblApeMedico.Name = "lblApeMedico";
            this.lblApeMedico.Size = new System.Drawing.Size(54, 13);
            this.lblApeMedico.TabIndex = 1;
            this.lblApeMedico.Text = "Apellido(*)";
            // 
            // lblNombreMed
            // 
            this.lblNombreMed.AutoSize = true;
            this.lblNombreMed.Location = new System.Drawing.Point(43, 35);
            this.lblNombreMed.Name = "lblNombreMed";
            this.lblNombreMed.Size = new System.Drawing.Size(54, 13);
            this.lblNombreMed.TabIndex = 0;
            this.lblNombreMed.Text = "Nombre(*)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtHonorarios);
            this.groupBox2.Controls.Add(this.txtMatricula);
            this.groupBox2.Controls.Add(this.lblHonorarios);
            this.groupBox2.Controls.Add(this.lblEspecialidad);
            this.groupBox2.Controls.Add(this.lblMatricula);
            this.groupBox2.Location = new System.Drawing.Point(45, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Profesionales";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // txtHonorarios
            // 
            this.txtHonorarios.Location = new System.Drawing.Point(166, 120);
            this.txtHonorarios.Name = "txtHonorarios";
            this.txtHonorarios.Size = new System.Drawing.Size(185, 20);
            this.txtHonorarios.TabIndex = 10;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(166, 44);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(185, 20);
            this.txtMatricula.TabIndex = 8;
            // 
            // lblHonorarios
            // 
            this.lblHonorarios.AutoSize = true;
            this.lblHonorarios.Location = new System.Drawing.Point(43, 127);
            this.lblHonorarios.Name = "lblHonorarios";
            this.lblHonorarios.Size = new System.Drawing.Size(68, 13);
            this.lblHonorarios.TabIndex = 3;
            this.lblHonorarios.Text = "Honorarios(*)";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(43, 85);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(77, 13);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad(*)";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(43, 47);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(60, 13);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula(*)";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(414, 486);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(321, 486);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRegistrarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 521);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarMedico";
            this.Text = "Registrar Medico";
            this.Load += new System.EventHandler(this.frmRegistrarMedico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefonoMed;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblApeMedico;
        private System.Windows.Forms.Label lblNombreMed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHonorarios;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblHonorarios;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}