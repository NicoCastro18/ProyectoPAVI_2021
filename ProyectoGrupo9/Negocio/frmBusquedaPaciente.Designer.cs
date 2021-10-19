
namespace ProyectoGrupo9.Negocio
{
    partial class frmBusquedaPaciente
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
            this.lblFiltroDni = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorFiltro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltroDni
            // 
            this.lblFiltroDni.AutoSize = true;
            this.lblFiltroDni.Location = new System.Drawing.Point(38, 29);
            this.lblFiltroDni.Name = "lblFiltroDni";
            this.lblFiltroDni.Size = new System.Drawing.Size(72, 13);
            this.lblFiltroDni.TabIndex = 0;
            this.lblFiltroDni.Text = "Filtro por DNI:";
            this.lblFiltroDni.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPorFiltro);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblFiltroDni);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBuscarPorFiltro
            // 
            this.btnBuscarPorFiltro.Location = new System.Drawing.Point(33, 56);
            this.btnBuscarPorFiltro.Name = "btnBuscarPorFiltro";
            this.btnBuscarPorFiltro.Size = new System.Drawing.Size(95, 21);
            this.btnBuscarPorFiltro.TabIndex = 2;
            this.btnBuscarPorFiltro.Text = "Buscar";
            this.btnBuscarPorFiltro.UseVisualStyleBackColor = true;
            this.btnBuscarPorFiltro.Click += new System.EventHandler(this.btnBuscarPorFiltro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPaciente);
            this.groupBox2.Location = new System.Drawing.Point(17, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 215);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pacientes";
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.AllowUserToAddRows = false;
            this.dgvPaciente.AllowUserToDeleteRows = false;
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
            this.dgvPaciente.Location = new System.Drawing.Point(6, 19);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.ReadOnly = true;
            this.dgvPaciente.Size = new System.Drawing.Size(806, 161);
            this.dgvPaciente.TabIndex = 2;
            this.dgvPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaciente_CellClick);
            this.dgvPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugs_CellContentClick);
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
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(646, 338);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(744, 338);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Actualizar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(52, 338);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 6;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(548, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBusquedaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 364);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBusquedaPaciente";
            this.Text = "Busqueda Paciente";
            this.Load += new System.EventHandler(this.frmActualizacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFiltroDni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPorFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCancelar;
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
    }
}