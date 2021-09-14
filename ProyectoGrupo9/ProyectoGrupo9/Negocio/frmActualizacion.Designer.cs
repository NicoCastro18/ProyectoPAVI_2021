
namespace ProyectoGrupo9.Negocio
{
    partial class frmActualizacion
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
            this.dgvBugs = new System.Windows.Forms.DataGridView();
            this.colum_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fechaNaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).BeginInit();
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBugs);
            this.groupBox2.Location = new System.Drawing.Point(17, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 215);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pacientes";
            // 
            // dgvBugs
            // 
            this.dgvBugs.AllowUserToAddRows = false;
            this.dgvBugs.AllowUserToDeleteRows = false;
            this.dgvBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_DNI,
            this.colum_Nombre,
            this.colum_Apellido,
            this.colum_Provincia,
            this.colum_Ciudad,
            this.colum_ObraSocial,
            this.colum_Calle,
            this.colum_Mail,
            this.colum_fechaNaci});
            this.dgvBugs.Location = new System.Drawing.Point(6, 19);
            this.dgvBugs.Name = "dgvBugs";
            this.dgvBugs.ReadOnly = true;
            this.dgvBugs.Size = new System.Drawing.Size(740, 170);
            this.dgvBugs.TabIndex = 2;
            this.dgvBugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugs_CellContentClick);
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
            // frmActualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmActualizacion";
            this.Text = "frmActualizacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFiltroDni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPorFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_ObraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_fechaNaci;
    }
}