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
    public partial class FormRegistroLogin : Form
    {
        
        public FormRegistroLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
    //        materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            lblFecha.Font = new Font(lblFecha.Font.Name, 8);
            lblHora.Font = new Font(lblHora.Font.Name, 8);
            label1.Font = new Font(label1.Font.Name, 20);
            label2.Font = new Font(label2.Font.Name, 12);
            label3.Font = new Font(label3.Font.Name, 12);
            label4.Font = new Font(label4.Font.Name, 12);
            label5.Font = new Font(label5.Font.Name, 12);
            label6.Font = new Font(label6.Font.Name, 12);
        }



        //public FormRegistroLogin(String emailID,String Contraseña)
        //{     
            
        //}



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
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            this.Close();
         }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormRegistroLogin_Load(object sender, EventArgs e)
        {
        //    SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            lblFecha.Font = new Font(lblFecha.Font.Name, 8);
            lblHora.Font = new Font(lblHora.Font.Name, 8);
            label1.Font = new Font(label1.Font.Name, 20);
            label2.Font = new Font(label2.Font.Name, 12);
            label3.Font = new Font(label3.Font.Name, 12);
            label4.Font = new Font(label4.Font.Name, 12);
            label5.Font = new Font(label5.Font.Name, 12);
            label6.Font = new Font(label6.Font.Name, 12);


        }
        private void progreso_Tick(object sender, EventArgs e)
        {
            if (pbrTrabajo.Value < 100)
                pbrTrabajo.Value++;

            if (pbrTrabajo.Value == 100)
            {
                progreso.Enabled = false;
                progreso.Stop();
                this.Close();
            }
            if (prbTrabajo2.Value < 100)
                prbTrabajo2.Value++;

            if (prbTrabajo2.Value == 100)
            {
                progreso.Enabled = false;

            }


        }
        private void btnFinalizarRegistro_Click(object sender, EventArgs e)
        {

            btnFinalizarRegistro.Visible = false;//?
            progreso.Enabled = true;
            pbrTrabajo.Value = 0;
            prbTrabajo2.Value = 0;

            using (var context = new ApplicationDbContext())
            {
                //paso 1 crear el objeto 
                var registro1 = new Registros();
                registro1.Nombre = txbNombre.Text;
                registro1.Apellido = txbApellido.Text;
                registro1.Email = txbEmail.Text;
                registro1.Contraseña = txbContraseña.Text;

                context.registros.Add(registro1);



                context.SaveChanges();


            }
            using (var context = new ApplicationDbContext())
            {
                var inv = context.registros.ToList();
                //dgvinventario.DataSource = inv;
            }


        }

        private void txbConfirmar_TextChanged(object sender, EventArgs e)
        {
            txbConfirmar.Text = txbConfirmar.Text;
            if (txbConfirmar.Text== txbContraseña.Text)
            {
                btnFinalizarRegistro.Enabled = true;
                label7.Text = ".";
                pberror.Visible = false;
                pbcorrecto.Visible = true;
            }
            if (txbConfirmar.Text != txbContraseña.Text)
            {
                  btnFinalizarRegistro.Enabled = false;
                  label7.Text = "la contraseña no coincide";
                pbcorrecto.Visible = false;
                pberror.Visible = true;
               
            }

        }



      
    }
}
