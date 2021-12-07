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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void fechayhora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("H:mm:ss");
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToString("d/MM/yyyy");
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
         //   panelmenu.Visible = false;
            this.Close();
          
        }

        private void pbProducto_Click(object sender, EventArgs e)
        {
            FormInventario frmInventario = new FormInventario();
            frmInventario.ShowDialog();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            panelmenu.Visible = true;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
   ///        frmLogin.me

///    lblpontunombreaqui=nose
        }

        private void pbProovedores_Click(object sender, EventArgs e)
        {
            FormProveedores frmprov = new FormProveedores();
            frmprov.Show();
        }

        private void pbLista_Click(object sender, EventArgs e)
        {

        }
    }
}
