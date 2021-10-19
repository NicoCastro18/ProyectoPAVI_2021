
namespace ProyectoGrupo9.Negocio
{
    partial class frmBuscarEmpleado
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.colum_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Usuar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(26, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(53, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(321, 20);
            this.txtId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_id,
            this.col_nom,
            this.colum_Ape,
            this.colum_Usuar,
            this.colum_cont,
            this.colum,
            this.colum_Mail});
            this.dgvEmpleado.Location = new System.Drawing.Point(31, 146);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Size = new System.Drawing.Size(688, 168);
            this.dgvEmpleado.TabIndex = 4;
            this.dgvEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicoFiltrado_CellClick);
            // 
            // colum_id
            // 
            this.colum_id.HeaderText = "ID";
            this.colum_id.Name = "colum_id";
            this.colum_id.Width = 50;
            // 
            // col_nom
            // 
            this.col_nom.HeaderText = "Nombre";
            this.col_nom.Name = "col_nom";
            // 
            // colum_Ape
            // 
            this.colum_Ape.HeaderText = "Apellido";
            this.colum_Ape.Name = "colum_Ape";
            // 
            // colum_Usuar
            // 
            this.colum_Usuar.HeaderText = "Usuario";
            this.colum_Usuar.Name = "colum_Usuar";
            // 
            // colum_cont
            // 
            this.colum_cont.HeaderText = "Contraseña";
            this.colum_cont.Name = "colum_cont";
            // 
            // colum
            // 
            this.colum.HeaderText = "Rol";
            this.colum.Name = "colum";
            // 
            // colum_Mail
            // 
            this.colum_Mail.HeaderText = "Mail";
            this.colum_Mail.Name = "colum_Mail";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(506, 333);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(400, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(615, 333);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(70, 333);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 8;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 368);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBuscarEmpleado";
            this.Text = "BuscarEmpleado";
            this.Load += new System.EventHandler(this.frmBuscarEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Usuar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Mail;
    }
}