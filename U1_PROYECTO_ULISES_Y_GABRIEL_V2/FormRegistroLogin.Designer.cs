
namespace U1_PROYECTO_ULISES_Y_GABRIEL_V2
{
    partial class FormRegistroLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroLogin));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pbrTrabajo = new System.Windows.Forms.ProgressBar();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.btnFinalizarRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbConfirmar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.horayfecha = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.prbTrabajo2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.progreso = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.pberror = new System.Windows.Forms.PictureBox();
            this.pbcorrecto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pberror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcorrecto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegresar.Location = new System.Drawing.Point(7, 1);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(115, 39);
            this.btnRegresar.TabIndex = 23;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pbrTrabajo
            // 
            this.pbrTrabajo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbrTrabajo.Location = new System.Drawing.Point(40, 465);
            this.pbrTrabajo.Name = "pbrTrabajo";
            this.pbrTrabajo.Size = new System.Drawing.Size(646, 34);
            this.pbrTrabajo.TabIndex = 35;
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(9, 560);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(32, 42);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 3;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // btnFinalizarRegistro
            // 
            this.btnFinalizarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarRegistro.Enabled = false;
            this.btnFinalizarRegistro.Location = new System.Drawing.Point(285, 406);
            this.btnFinalizarRegistro.Name = "btnFinalizarRegistro";
            this.btnFinalizarRegistro.Size = new System.Drawing.Size(187, 37);
            this.btnFinalizarRegistro.TabIndex = 34;
            this.btnFinalizarRegistro.Text = "Finalizar Registro";
            this.btnFinalizarRegistro.UseVisualStyleBackColor = false;
            this.btnFinalizarRegistro.Click += new System.EventHandler(this.btnFinalizarRegistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 48);
            this.label1.TabIndex = 23;
            this.label1.Text = "bienvenido registrate con nosotros";
            // 
            // txbConfirmar
            // 
            this.txbConfirmar.Location = new System.Drawing.Point(285, 334);
            this.txbConfirmar.Name = "txbConfirmar";
            this.txbConfirmar.PlaceholderText = "Confirma tu contraseña";
            this.txbConfirmar.Size = new System.Drawing.Size(331, 31);
            this.txbConfirmar.TabIndex = 33;
            this.txbConfirmar.TextChanged += new System.EventHandler(this.txbConfirmar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(285, 289);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PlaceholderText = "Ingresa tu contraseña";
            this.txbContraseña.Size = new System.Drawing.Size(331, 31);
            this.txbContraseña.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Apellidos";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(285, 242);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PlaceholderText = "Ingresa tu Email aqui";
            this.txbEmail.Size = new System.Drawing.Size(331, 31);
            this.txbEmail.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(285, 199);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.PlaceholderText = "Ingresa tus Apellidos aqui";
            this.txbApellido.Size = new System.Drawing.Size(331, 31);
            this.txbApellido.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Contraseña";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(285, 157);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PlaceholderText = "Ingresa tu nombre aqui";
            this.txbNombre.Size = new System.Drawing.Size(331, 31);
            this.txbNombre.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "Confirmar Contraseña";
            // 
            // horayfecha
            // 
            this.horayfecha.Enabled = true;
            this.horayfecha.Tick += new System.EventHandler(this.horayfecha_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(267, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(76, 32);
            this.lblFecha.TabIndex = 38;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora.Location = new System.Drawing.Point(581, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(65, 32);
            this.lblHora.TabIndex = 37;
            this.lblHora.Text = "Hora";
            // 
            // prbTrabajo2
            // 
            this.prbTrabajo2.Depth = 0;
            this.prbTrabajo2.Location = new System.Drawing.Point(111, 505);
            this.prbTrabajo2.MouseState = MaterialSkin.MouseState.HOVER;
            this.prbTrabajo2.Name = "prbTrabajo2";
            this.prbTrabajo2.Size = new System.Drawing.Size(464, 5);
            this.prbTrabajo2.TabIndex = 39;
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.Transparent;
            this.panelmenu.Controls.Add(this.btnCreditos);
            this.panelmenu.Controls.Add(this.btnRegresar);
            this.panelmenu.Location = new System.Drawing.Point(40, 560);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(247, 42);
            this.panelmenu.TabIndex = 36;
            this.panelmenu.Visible = false;
            // 
            // btnCreditos
            // 
            this.btnCreditos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreditos.Location = new System.Drawing.Point(129, 0);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(115, 39);
            this.btnCreditos.TabIndex = 24;
            this.btnCreditos.Text = "Cancelar";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // progreso
            // 
            this.progreso.Tick += new System.EventHandler(this.progreso_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(285, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = ".";
            // 
            // pberror
            // 
            this.pberror.BackColor = System.Drawing.Color.Transparent;
            this.pberror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pberror.Image = global::U1_PROYECTO_ULISES_Y_GABRIEL_V2.Properties.Resources.pixlr_bg_result__2_;
            this.pberror.Location = new System.Drawing.Point(622, 286);
            this.pberror.Name = "pberror";
            this.pberror.Size = new System.Drawing.Size(76, 75);
            this.pberror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pberror.TabIndex = 41;
            this.pberror.TabStop = false;
            this.pberror.Visible = false;
            // 
            // pbcorrecto
            // 
            this.pbcorrecto.BackColor = System.Drawing.Color.Transparent;
            this.pbcorrecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbcorrecto.Image = global::U1_PROYECTO_ULISES_Y_GABRIEL_V2.Properties.Resources.pixlr_bg_result__3_;
            this.pbcorrecto.Location = new System.Drawing.Point(622, 286);
            this.pbcorrecto.Name = "pbcorrecto";
            this.pbcorrecto.Size = new System.Drawing.Size(76, 75);
            this.pbcorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcorrecto.TabIndex = 42;
            this.pbcorrecto.TabStop = false;
            // 
            // FormRegistroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::U1_PROYECTO_ULISES_Y_GABRIEL_V2.Properties.Resources.naranja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.pbcorrecto);
            this.Controls.Add(this.pberror);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prbTrabajo2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pbrTrabajo);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.txbConfirmar);
            this.Controls.Add(this.btnFinalizarRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.label5);
            this.Name = "FormRegistroLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistroLogin";
            this.Load += new System.EventHandler(this.FormRegistroLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pberror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcorrecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.ProgressBar pbrTrabajo;
        private System.Windows.Forms.Button btnFinalizarRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer horayfecha;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private MaterialSkin.Controls.MaterialProgressBar prbTrabajo2;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.Timer progreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pberror;
        private System.Windows.Forms.PictureBox pbcorrecto;
    }
}