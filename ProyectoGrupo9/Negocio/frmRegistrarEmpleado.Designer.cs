
namespace ProyectoGrupo9.Negocio
{
    partial class frmRegistrarEmpleado
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre(*)";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(22, 67);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido(*)";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(22, 112);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "Mail";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(33, 38);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario(*)";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(279, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(102, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(279, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(102, 109);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(279, 20);
            this.txtDni.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(102, 60);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(279, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(33, 84);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(71, 13);
            this.lblContra.TabIndex = 8;
            this.lblContra.Text = "Contraseña(*)";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(102, 81);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(279, 20);
            this.txtContraseña.TabIndex = 9;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(33, 138);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 13);
            this.lblRol.TabIndex = 10;
            this.lblRol.Text = "Rol(*)";
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(102, 130);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(279, 21);
            this.cboRol.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboRol);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.lblContra);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Location = new System.Drawing.Point(24, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 186);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Empresa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.txtDni);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.lblDni);
            this.groupBox2.Controls.Add(this.lblApellido);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Location = new System.Drawing.Point(24, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 158);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Personales";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(280, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(364, 418);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmRegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 453);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarEmpleado";
            this.Text = "frmRegistrarEmpleado";
            this.Load += new System.EventHandler(this.frmRegistrarEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}