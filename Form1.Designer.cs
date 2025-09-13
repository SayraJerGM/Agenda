namespace Agenda
{
    partial class frmAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ColNombre = new DataGridViewTextBoxColumn();
            Colappterno = new DataGridViewTextBoxColumn();
            Colapmaterno = new DataGridViewTextBoxColumn();
            coltelefono = new DataGridViewTextBoxColumn();
            Colcorreo = new DataGridViewTextBoxColumn();
            ColDireccion = new DataGridViewTextBoxColumn();
            lblDatos = new Label();
            lblEstado = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNombre, Colappterno, Colapmaterno, coltelefono, Colcorreo, ColDireccion });
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(937, 357);
            dataGridView1.TabIndex = 0;
           // dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.Width = 125;
            // 
            // Colappterno
            // 
            Colappterno.HeaderText = "Ap paterno";
            Colappterno.MinimumWidth = 6;
            Colappterno.Name = "Colappterno";
            Colappterno.Width = 125;
            // 
            // Colapmaterno
            // 
            Colapmaterno.HeaderText = "Ap Materno";
            Colapmaterno.MinimumWidth = 6;
            Colapmaterno.Name = "Colapmaterno";
            Colapmaterno.Width = 125;
            // 
            // coltelefono
            // 
            coltelefono.HeaderText = "Telefono";
            coltelefono.MinimumWidth = 6;
            coltelefono.Name = "coltelefono";
            coltelefono.Width = 125;
            // 
            // Colcorreo
            // 
            Colcorreo.HeaderText = "Correo";
            Colcorreo.MinimumWidth = 6;
            Colcorreo.Name = "Colcorreo";
            Colcorreo.Width = 125;
            // 
            // ColDireccion
            // 
            ColDireccion.HeaderText = "Direcccion";
            ColDireccion.MinimumWidth = 6;
            ColDireccion.Name = "ColDireccion";
            ColDireccion.Width = 125;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Location = new Point(12, 390);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(0, 20);
            lblDatos.TabIndex = 1;
           // lblDatos.Click += label1_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(65, 390);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 20);
            lblEstado.TabIndex = 2;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 488);
            Controls.Add(lblEstado);
            Controls.Add(lblDatos);
            Controls.Add(dataGridView1);
            Name = "frmAgenda";
            Text = "Agenda";
            Load += frmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn Colappterno;
        private DataGridViewTextBoxColumn Colapmaterno;
        private DataGridViewTextBoxColumn coltelefono;
        private DataGridViewTextBoxColumn Colcorreo;
        private DataGridViewTextBoxColumn ColDireccion;
        private Label lblDatos;
        private Label lblEstado;
    }
}
