
namespace U1_PROYECTO_ULISES_Y_GABRIEL_V2
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fechayhora = new System.Windows.Forms.Timer(this.components);
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.pbProovedores = new System.Windows.Forms.PictureBox();
            this.pbChoferes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProovedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.Transparent;
            this.panelmenu.Controls.Add(this.btnCreditos);
            this.panelmenu.Controls.Add(this.btnRegresar);
            this.panelmenu.Controls.Add(this.label3);
            this.panelmenu.Location = new System.Drawing.Point(-1, 423);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(128, 181);
            this.panelmenu.TabIndex = 22;
            this.panelmenu.Visible = false;
            // 
            // btnCreditos
            // 
            this.btnCreditos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreditos.Location = new System.Drawing.Point(4, 82);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(110, 55);
            this.btnCreditos.TabIndex = 24;
            this.btnCreditos.Text = "CRÉDITOS";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegresar.Location = new System.Drawing.Point(4, 143);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 35);
            this.btnRegresar.TabIndex = 23;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 64);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mas\r\nOpciones:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.pbMenu);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 40);
            this.panel1.TabIndex = 21;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFecha.Location = new System.Drawing.Point(879, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 21);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // fechayhora
            // 
            this.fechayhora.Enabled = true;
            this.fechayhora.Tick += new System.EventHandler(this.fechayhora_Tick);
            // 
            // pbProducto
            // 
            this.pbProducto.BackColor = System.Drawing.Color.Transparent;
            this.pbProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbProducto.Image")));
            this.pbProducto.Location = new System.Drawing.Point(30, 100);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(250, 250);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProducto.TabIndex = 23;
            this.pbProducto.TabStop = false;
            this.pbProducto.Click += new System.EventHandler(this.pbProducto_Click);
            // 
            // pbProovedores
            // 
            this.pbProovedores.BackColor = System.Drawing.Color.Transparent;
            this.pbProovedores.Image = ((System.Drawing.Image)(resources.GetObject("pbProovedores.Image")));
            this.pbProovedores.Location = new System.Drawing.Point(365, 100);
            this.pbProovedores.Name = "pbProovedores";
            this.pbProovedores.Size = new System.Drawing.Size(250, 250);
            this.pbProovedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProovedores.TabIndex = 24;
            this.pbProovedores.TabStop = false;
            this.pbProovedores.Click += new System.EventHandler(this.pbProovedores_Click);
            // 
            // pbChoferes
            // 
            this.pbChoferes.BackColor = System.Drawing.Color.Transparent;
            this.pbChoferes.Image = ((System.Drawing.Image)(resources.GetObject("pbChoferes.Image")));
            this.pbChoferes.Location = new System.Drawing.Point(702, 100);
            this.pbChoferes.Name = "pbChoferes";
            this.pbChoferes.Size = new System.Drawing.Size(250, 250);
            this.pbChoferes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChoferes.TabIndex = 25;
            this.pbChoferes.TabStop = false;
            this.pbChoferes.Click += new System.EventHandler(this.pbLista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Agregar Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(365, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Agregar Proovedores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(712, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Agregar Choferes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::U1_PROYECTO_ULISES_Y_GABRIEL_V2.Properties.Resources.neon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbChoferes);
            this.Controls.Add(this.pbProovedores);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProovedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoferes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer fechayhora;
        private System.Windows.Forms.PictureBox pbProducto;
        private System.Windows.Forms.PictureBox pbProovedores;
        private System.Windows.Forms.PictureBox pbChoferes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}