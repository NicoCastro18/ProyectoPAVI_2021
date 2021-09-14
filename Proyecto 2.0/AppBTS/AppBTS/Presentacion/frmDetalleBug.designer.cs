namespace AppBTS.Presentacion
{
    partial class frmDetalleBug
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_historiales = new System.Windows.Forms.DataGridView();
            this.fec_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignado_a_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_criticidad = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_fec_alta = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txt_prioridad = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txt_descri = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_nro_bug = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historiales)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dgv_historiales);
            this.GroupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(21, 277);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(433, 215);
            this.GroupBox1.TabIndex = 40;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Historial Bug";
            // 
            // dgv_historiales
            // 
            this.dgv_historiales.AllowUserToAddRows = false;
            this.dgv_historiales.AllowUserToDeleteRows = false;
            this.dgv_historiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historiales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fec_col,
            this.responsable_col,
            this.estado_col,
            this.asignado_a_col});
            this.dgv_historiales.Location = new System.Drawing.Point(6, 18);
            this.dgv_historiales.Name = "dgv_historiales";
            this.dgv_historiales.ReadOnly = true;
            this.dgv_historiales.Size = new System.Drawing.Size(420, 185);
            this.dgv_historiales.TabIndex = 22;
            this.dgv_historiales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_historiales_CellContentClick);
            // 
            // fec_col
            // 
            this.fec_col.HeaderText = "Fecha";
            this.fec_col.Name = "fec_col";
            this.fec_col.ReadOnly = true;
            // 
            // responsable_col
            // 
            this.responsable_col.HeaderText = "Responsable";
            this.responsable_col.Name = "responsable_col";
            this.responsable_col.ReadOnly = true;
            // 
            // estado_col
            // 
            this.estado_col.HeaderText = "Estado";
            this.estado_col.Name = "estado_col";
            this.estado_col.ReadOnly = true;
            // 
            // asignado_a_col
            // 
            this.asignado_a_col.HeaderText = "Asignado a";
            this.asignado_a_col.Name = "asignado_a_col";
            this.asignado_a_col.ReadOnly = true;
            // 
            // txt_criticidad
            // 
            this.txt_criticidad.Enabled = false;
            this.txt_criticidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_criticidad.Location = new System.Drawing.Point(128, 243);
            this.txt_criticidad.Name = "txt_criticidad";
            this.txt_criticidad.Size = new System.Drawing.Size(261, 22);
            this.txt_criticidad.TabIndex = 39;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(56, 248);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(53, 13);
            this.Label10.TabIndex = 38;
            this.Label10.Text = "Criticidad:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(201, 491);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 37;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_fec_alta
            // 
            this.txt_fec_alta.Enabled = false;
            this.txt_fec_alta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fec_alta.Location = new System.Drawing.Point(128, 96);
            this.txt_fec_alta.Name = "txt_fec_alta";
            this.txt_fec_alta.Size = new System.Drawing.Size(123, 22);
            this.txt_fec_alta.TabIndex = 36;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(25, 101);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(84, 13);
            this.Label9.TabIndex = 35;
            this.Label9.Text = "Fecha creación:";
            // 
            // txt_prioridad
            // 
            this.txt_prioridad.Enabled = false;
            this.txt_prioridad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prioridad.Location = new System.Drawing.Point(128, 213);
            this.txt_prioridad.Name = "txt_prioridad";
            this.txt_prioridad.Size = new System.Drawing.Size(260, 22);
            this.txt_prioridad.TabIndex = 34;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(56, 218);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(51, 13);
            this.Label7.TabIndex = 33;
            this.Label7.Text = "Prioridad:";
            // 
            // txt_producto
            // 
            this.txt_producto.Enabled = false;
            this.txt_producto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.Location = new System.Drawing.Point(128, 66);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(261, 22);
            this.txt_producto.TabIndex = 30;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(56, 66);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 13);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "Producto:";
            // 
            // txt_descri
            // 
            this.txt_descri.Enabled = false;
            this.txt_descri.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descri.Location = new System.Drawing.Point(128, 126);
            this.txt_descri.Multiline = true;
            this.txt_descri.Name = "txt_descri";
            this.txt_descri.Size = new System.Drawing.Size(262, 80);
            this.txt_descri.TabIndex = 28;
            this.txt_descri.TextChanged += new System.EventHandler(this.txt_descri_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(43, 155);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 13);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "Descripción:";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Enabled = false;
            this.txt_titulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(128, 36);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(260, 22);
            this.txt_titulo.TabIndex = 26;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(71, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Título:";
            // 
            // txt_nro_bug
            // 
            this.txt_nro_bug.Enabled = false;
            this.txt_nro_bug.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nro_bug.Location = new System.Drawing.Point(128, 6);
            this.txt_nro_bug.Name = "txt_nro_bug";
            this.txt_nro_bug.Size = new System.Drawing.Size(68, 22);
            this.txt_nro_bug.TabIndex = 24;
            this.txt_nro_bug.TextChanged += new System.EventHandler(this.txt_nro_bug_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(70, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "# Bug:";
            // 
            // frmDetalleBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 522);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txt_criticidad);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_fec_alta);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txt_prioridad);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txt_descri);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_nro_bug);
            this.Controls.Add(this.Label1);
            this.Name = "frmDetalleBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Bug";
            this.Load += new System.EventHandler(this.frmDetalleBug_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historiales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dgv_historiales;
        internal System.Windows.Forms.DataGridViewTextBoxColumn fec_col;
        internal System.Windows.Forms.DataGridViewTextBoxColumn responsable_col;
        internal System.Windows.Forms.DataGridViewTextBoxColumn estado_col;
        internal System.Windows.Forms.DataGridViewTextBoxColumn asignado_a_col;
        internal System.Windows.Forms.TextBox txt_criticidad;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button btn_aceptar;
        internal System.Windows.Forms.TextBox txt_fec_alta;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txt_prioridad;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txt_producto;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txt_descri;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_titulo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_nro_bug;
        internal System.Windows.Forms.Label Label1;
    }
}