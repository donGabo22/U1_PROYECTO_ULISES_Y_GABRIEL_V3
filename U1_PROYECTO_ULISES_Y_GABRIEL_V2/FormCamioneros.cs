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
    public partial class FormCamioneros : Form
    {
        int id = 0;
        public FormCamioneros()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                //Crear el objeto
                var Cam = new Camionero();
                Cam.Nombre = txtNombre.Text;
                Cam.Numero = txtNumero.Text;
                Cam.NumCamion = txtNumCamion.Text;
                Cam.Direccion = txtDireccion.Text;


                //Notificamos a EFC el agregar un cliente
                context.Camionero.Add(Cam);

                //Guardamos los cambios
                context.SaveChanges();
            }
            MostrarCam();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var Cam = context.Camionero.First(x => x.Id == id);
                    if (Cam != null)
                    {
                        Cam.Nombre = txtNombre.Text;
                        Cam.Numero = txtNumero.Text;
                        Cam.NumCamion = txtNumCamion.Text;
                        Cam.Direccion = txtDireccion.Text;
                        context.SaveChanges();
                    }
                }
            }
            MostrarCam();
            Limpiar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var Cam = context.Camionero.First(x => x.Id == id);
                    if (Cam != null)
                    {
                        context.Remove(Cam);
                        context.SaveChanges();
                    }
                }
            }
            MostrarCam();
            Limpiar();
        }

        private void MostrarCam()
        {
            using (var context = new ApplicationDbContext())
            {
                var Cam = context.Camionero.ToList();
                dgvCamionero.DataSource = Cam;
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtNumero.Text = "";
            txtNumCamion.Text = "";
            txtDireccion.Text = "";
        }

        private void FormCamioneros_Load(object sender, EventArgs e)
        {
            MostrarCam();
        }

        private void dgvCamionero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvCamionero.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvCamionero.CurrentRow.Cells[1].Value.ToString();
            txtNumero.Text = dgvCamionero.CurrentRow.Cells[2].Value.ToString();
            txtNumCamion.Text = dgvCamionero.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvCamionero.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var Cam = context.Camionero.Where(x => x.Nombre.Contains(txtNombre.Text)).ToList();
                dgvCamionero.DataSource = Prov;
            }
        }
    }
}
