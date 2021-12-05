using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_PROYECTO_ULISES_Y_GABRIEL_V2
{
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        public FormLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void horayfecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("H:mm:ss");
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString() +"     ||";

        }

        private void pbMenu_MouseClick(object sender, MouseEventArgs e)
        {
            panelmenu.Visible = true;
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            panelmenu.Visible = false;

        }


        private void btnCreditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROYECTO HECHO POR: \n " +
                "Gabriel Hernández Diaz N.C 19540444 \n " +
                "Ulises Alejandro Saenz Guerrero N.C 19540123 \n" +
                "MATERIA: Tópicos Avanzados de Programación \n" +
                "PROFE: César Adan Acosta", "Hola Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 panelmenu.Visible = false;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistroLogin frmregistro = new FormRegistroLogin();
            frmregistro.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String nombre = txbUsuario.Text;
            String contraseña = txbContraseña.Text;
            if (txbUsuario.Text == "Admin" && (txbContraseña.Text == "pass"))
            {

                FormMenu frmMenu = new FormMenu();
                frmMenu.ShowDialog();
            }
            MessageBox.Show("Error, Nombre de Usuario o Contraseña incorrectos", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;

        }
    }
}
