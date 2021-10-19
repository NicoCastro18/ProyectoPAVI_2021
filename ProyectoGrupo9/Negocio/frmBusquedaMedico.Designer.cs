
namespace ProyectoGrupo9.Negocio
{
    partial class frmBusquedaMedico
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
            this.lblBusquedaMed = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMedicoFiltrado = new System.Windows.Forms.DataGridView();
            this.Id_Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Honorarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicoFiltrado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBusquedaMed
            // 
            this.lblBusquedaMed.AutoSize = true;
            this.lblBusquedaMed.Location = new System.Drawing.Point(30, 31);
            this.lblBusquedaMed.Name = "lblBusquedaMed";
            this.lblBusquedaMed.Size = new System.Drawing.Size(50, 13);
            this.lblBusquedaMed.TabIndex = 0;
            this.lblBusquedaMed.Text = "Matricula";
            this.lblBusquedaMed.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(112, 24);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(181, 20);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(21, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvMedicoFiltrado
            // 
            this.dgvMedicoFiltrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicoFiltrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Medico,
            this.Matricula,
            this.Honorarios,
            this.Especialidad,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Mail});
            this.dgvMedicoFiltrado.Location = new System.Drawing.Point(12, 122);
            this.dgvMedicoFiltrado.Name = "dgvMedicoFiltrado";
            this.dgvMedicoFiltrado.Size = new System.Drawing.Size(839, 184);
            this.dgvMedicoFiltrado.TabIndex = 3;
            this.dgvMedicoFiltrado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicoFiltrado_CellClick);
            this.dgvMedicoFiltrado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_Medico
            // 
            this.Id_Medico.HeaderText = "Id Medico";
            this.Id_Medico.Name = "Id_Medico";
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // Honorarios
            // 
            this.Honorarios.HeaderText = "Honorarios";
            this.Honorarios.Name = "Honorarios";
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(752, 349);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(532, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(637, 349);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.lblBusquedaMed);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(58, 349);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 8;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmBusquedaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 380);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvMedicoFiltrado);
            this.Name = "frmBusquedaMedico";
            this.Text = "Busqueda de Medicos";
            this.Load += new System.EventHandler(this.frmActualizacionMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicoFiltrado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBusquedaMed;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMedicoFiltrado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Honorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefrescar;
    }
}