
namespace U1_PROYECTO_ULISES_Y_GABRIEL_V2
{
    partial class FormInventario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbZona = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvinventario = new System.Windows.Forms.DataGridView();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.cbUnidadesdeMedida = new System.Windows.Forms.ComboBox();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblHoraandFecha = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txbprecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.horayfecha = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::U1_PROYECTO_ULISES_Y_GABRIEL_V2.Properties.Resources.verde;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.pbMenu);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 704);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 40);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(899, -2);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 21);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(3, -2);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(32, 42);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 3;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(879, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 21);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txbZona);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvinventario);
            this.panel2.Controls.Add(this.txbCantidad);
            this.panel2.Controls.Add(this.cbUnidadesdeMedida);
            this.panel2.Controls.Add(this.txbBusqueda);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Controls.Add(this.lblHoraandFecha);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Controls.Add(this.txbprecio);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.cbTipo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txbNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 708);
            this.panel2.TabIndex = 23;
            // 
            // txbZona
            // 
            this.txbZona.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbZona.Location = new System.Drawing.Point(0, 454);
            this.txbZona.Name = "txbZona";
            this.txbZona.Size = new System.Drawing.Size(318, 31);
            this.txbZona.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 48);
            this.label6.TabIndex = 88;
            this.label6.Text = "Zona de Inventario:";
            // 
            // dgvinventario
            // 
            this.dgvinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinventario.Location = new System.Drawing.Point(348, 67);
            this.dgvinventario.Name = "dgvinventario";
            this.dgvinventario.RowHeadersWidth = 62;
            this.dgvinventario.RowTemplate.Height = 33;
            this.dgvinventario.Size = new System.Drawing.Size(627, 532);
            this.dgvinventario.TabIndex = 87;
            this.dgvinventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinventario_CellContentClick);
            // 
            // txbCantidad
            // 
            this.txbCantidad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbCantidad.Location = new System.Drawing.Point(0, 296);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(180, 31);
            this.txbCantidad.TabIndex = 68;
            // 
            // cbUnidadesdeMedida
            // 
            this.cbUnidadesdeMedida.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbUnidadesdeMedida.FormattingEnabled = true;
            this.cbUnidadesdeMedida.Items.AddRange(new object[] {
            "Kg",
            "Lts",
            "Unidades"});
            this.cbUnidadesdeMedida.Location = new System.Drawing.Point(181, 294);
            this.cbUnidadesdeMedida.Name = "cbUnidadesdeMedida";
            this.cbUnidadesdeMedida.Size = new System.Drawing.Size(137, 33);
            this.cbUnidadesdeMedida.TabIndex = 86;
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbBusqueda.Location = new System.Drawing.Point(-3, 557);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(324, 31);
            this.txbBusqueda.TabIndex = 85;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.txbBusqueda_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 48);
            this.label7.TabIndex = 84;
            this.label7.Text = "Buscar";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(178, 659);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 34);
            this.btnRegresar.TabIndex = 72;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblHoraandFecha
            // 
            this.lblHoraandFecha.AutoSize = true;
            this.lblHoraandFecha.BackColor = System.Drawing.Color.White;
            this.lblHoraandFecha.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraandFecha.Location = new System.Drawing.Point(739, 7);
            this.lblHoraandFecha.Name = "lblHoraandFecha";
            this.lblHoraandFecha.Size = new System.Drawing.Size(138, 45);
            this.lblHoraandFecha.TabIndex = 83;
            this.lblHoraandFecha.Text = "Aqui va la fecha";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 659);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 34);
            this.btnModificar.TabIndex = 70;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gabriola", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(556, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 55);
            this.label4.TabIndex = 82;
            this.label4.Text = "Fecha de Registro:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 619);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 34);
            this.btnRegistrar.TabIndex = 69;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txbprecio
            // 
            this.txbprecio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbprecio.Location = new System.Drawing.Point(3, 369);
            this.txbprecio.Name = "txbprecio";
            this.txbprecio.Size = new System.Drawing.Size(318, 31);
            this.txbprecio.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 48);
            this.label3.TabIndex = 81;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 48);
            this.label2.TabIndex = 80;
            this.label2.Text = "Cantidad";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(178, 619);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 34);
            this.btnEliminar.TabIndex = 79;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Productos Lácteos",
            "Grasas y aceites \t",
            "Confitería (Cacaó, jarabes, endulzantes,etc...)",
            "Cereales y productos a base de cereales",
            "Edulcorantes, incluida la miel y mermelada",
            "Huevos y productos a base de huevo",
            "Otro..."});
            this.cbTipo.Location = new System.Drawing.Point(3, 112);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(324, 33);
            this.cbTipo.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 48);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tipo de Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 48);
            this.label5.TabIndex = 63;
            this.label5.Text = "Nombre del Producto:";
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbNombre.Location = new System.Drawing.Point(3, 45);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(324, 31);
            this.txbNombre.TabIndex = 64;
            // 
            // horayfecha
            // 
            this.horayfecha.Enabled = true;
            this.horayfecha.Tick += new System.EventHandler(this.horayfecha_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 48);
            this.label8.TabIndex = 90;
            this.label8.Text = "Empresa:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 33);
            this.comboBox1.TabIndex = 91;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer horayfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txbprecio;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label lblHoraandFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvinventario;
        private System.Windows.Forms.ComboBox cbUnidadesdeMedida;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbZona;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}