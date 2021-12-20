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
using U1_PROYECTO_ULISES_Y_GABRIEL_V2.Models;

namespace U1_PROYECTO_ULISES_Y_GABRIEL_V2
{
    public partial class FormLogin : Form
    {
        public int id = 0;

        Registros jjjj = new Registros();

        public FormLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            //    materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            label1.Font = new Font(label1.Font.Name, 12);
            label2.Font = new Font(label2.Font.Name, 12);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //    if (txbUsuario.Text == "Admin" && txbContraseña.Text == "pass")
            //    {
            //        FormMenu frmMenu = new FormMenu();
            //        frmMenu.ShowDialog();
            //    }

            //    if (txbUsuario.Text != "Admin" || txbContraseña.Text != "pass")
            //    {
            //        MessageBox.Show("Usuario o contraseña Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

            //    using (var context = new ApplicationDbContext())
            //    {
            //        if (id != 0)
            //        {
            //            var registro1 = context.registros.First(x => x.Email == txbUsuario.Text);
            //            var registro2 = context.registros.First(x => x.Contraseña == txbContraseña.Text);


            //        }
            //        MessageBox.Show(" existe");
            //        FormMenu frmMenu = new FormMenu();
            //        frmMenu.ShowDialog();
            //    }
            //}


            using (var context = new ApplicationDbContext())
            {
                if (txbUsuario.Text is not null)
                {
                //    string ena = jjjj.Email;
                    var Registro = context.registros.Where(x => x.Email.Contains(jjjj.Email));
                    if (Registro is not null )
                    {
                        MessageBox.Show("correo correcto");
                        if (txbContraseña.Text == null)
                        {
                         var Contraseña1 = context.registros.First(x => x.Contraseña.Contains(txbContraseña.Text));

                        }
                    }
                }
            }
        }


            private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void horayfecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("H:mm:ss");
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString() + "     ||";

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
            frmregistro.Show();

        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
           // SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            lblFecha.Font = new Font(lblFecha.Font.Name, 8);
            lblHora.Font = new Font (lblHora.Font.Name,8);
            label1.Font = new Font(label1.Font.Name, 12);
            label2.Font = new Font(label2.Font.Name, 12);


        }
    }
}  


