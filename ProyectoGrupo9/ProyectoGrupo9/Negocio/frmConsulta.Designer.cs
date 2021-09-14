
namespace ProyectoGrupo9.Negocio
{
    partial class frmConsulta
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPacienteFiltrado = new System.Windows.Forms.DataGridView();
            this.colum_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fechaNaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorFiltro = new System.Windows.Forms.Button();
            this.txtDniFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltroDni = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteFiltrado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.dgvPacienteFiltrado);
            this.groupBox2.Location = new System.Drawing.Point(18, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 248);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pacientes";
            // 
            // dgvPacienteFiltrado
            // 
            this.dgvPacienteFiltrado.AllowUserToAddRows = false;
            this.dgvPacienteFiltrado.AllowUserToDeleteRows = false;
            this.dgvPacienteFiltrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienteFiltrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_ID,
            this.colum_DNI,
            this.colum_Nombre,
            this.colum_Apellido,
            this.colum_Provincia,
            this.colum_Ciudad,
            this.colum_ObraSocial,
            this.colum_Calle,
            this.colum_Altura,
            this.colum_Mail,
            this.colum_fechaNaci});
            this.dgvPacienteFiltrado.Location = new System.Drawing.Point(6, 19);
            this.dgvPacienteFiltrado.Name = "dgvPacienteFiltrado";
            this.dgvPacienteFiltrado.ReadOnly = true;
            this.dgvPacienteFiltrado.Size = new System.Drawing.Size(859, 194);
            this.dgvPacienteFiltrado.TabIndex = 2;
            this.dgvPacienteFiltrado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugs_CellContentClick);
            // 
            // colum_ID
            // 
            this.colum_ID.HeaderText = "ID";
            this.colum_ID.Name = "colum_ID";
            this.colum_ID.ReadOnly = true;
            this.colum_ID.Width = 40;
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
            this.colum_Altura.HeaderText = "Altura Calle";
            this.colum_Altura.Name = "colum_Altura";
            this.colum_Altura.ReadOnly = true;
            // 
            // colum_Mail
            // 
            this.colum_Mail.HeaderText = "Mail";
            this.colum_Mail.Name = "colum_Mail";
            this.colum_Mail.ReadOnly = true;
            this.colum_Mail.Width = 80;
            // 
            // colum_fechaNaci
            // 
            this.colum_fechaNaci.HeaderText = "Fecha Nacimiento";
            this.colum_fechaNaci.Name = "colum_fechaNaci";
            this.colum_fechaNaci.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPorFiltro);
            this.groupBox1.Controls.Add(this.txtDniFiltro);
            this.groupBox1.Controls.Add(this.lblFiltroDni);
            this.groupBox1.Location = new System.Drawing.Point(18, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
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
            // txtDniFiltro
            // 
            this.txtDniFiltro.Location = new System.Drawing.Point(150, 22);
            this.txtDniFiltro.Name = "txtDniFiltro";
            this.txtDniFiltro.Size = new System.Drawing.Size(314, 20);
            this.txtDniFiltro.TabIndex = 1;
            // 
            // lblFiltroDni
            // 
            this.lblFiltroDni.AutoSize = true;
            this.lblFiltroDni.Location = new System.Drawing.Point(38, 29);
            this.lblFiltroDni.Name = "lblFiltroDni";
            this.lblFiltroDni.Size = new System.Drawing.Size(72, 13);
            this.lblFiltroDni.TabIndex = 0;
            this.lblFiltroDni.Text = "Filtro por DNI:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(630, 219);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(725, 219);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // frmBorrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBorrado";
            this.Text = "frmConsulta";
            this.Load += new System.EventHandler(this.frmBorrado_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteFiltrado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPacienteFiltrado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPorFiltro;
        private System.Windows.Forms.TextBox txtDniFiltro;
        private System.Windows.Forms.Label lblFiltroDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_ObraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_fechaNaci;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
    }
}