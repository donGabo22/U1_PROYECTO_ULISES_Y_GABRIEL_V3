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
    public partial class FormRegistroLogin : MaterialSkin.Controls.MaterialForm
    {
        public FormRegistroLogin()
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
            lblFecha.Text = DateTime.Now.ToLongDateString() + "     ||";
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            panelmenu.Visible = true;

        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            panelmenu.Visible = false;

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROYECTO HECHO POR: \n " +
    "Gabriel Hernández Diaz N.C 19540444 \n " +
    "Ulises Alejandro Saenz Guerrero N.C 19540123 \n" +
    "MATERIA: Tópicos Avanzados de Programación \n" +
    "PROFE: César Adan Acosta", "Hola Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFinalizarRegistro_Click(object sender, EventArgs e)
        {
            //if (txbNombre.Text != "" && txbApellido.Text != "" && txbEmail.Text != "" && txbContraseña.Text != "" && txbConfirmar.Text !="")
            //{
            //}
            String nombre = txbNombre.Text;
            String apellido = txbApellido.Text;
            String email = txbEmail.Text;


            if (txbContraseña.Text == txbConfirmar.Text)
            {
                String contraseña = txbContraseña.Text;
            }
            else
            {
                MessageBox.Show(" Las Contraseñas no coinciden", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



            this.Close();
        }
    }
}
