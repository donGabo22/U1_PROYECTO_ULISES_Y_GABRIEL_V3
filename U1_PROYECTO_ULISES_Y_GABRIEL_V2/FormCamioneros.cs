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
            //Verificar que los campos no esten incompletos
            if (txtNombre.Text!="" && txtNumCamion.Text != "" && txtNumero.Text != "" && txtDireccion.Text != "")
            {
                Registrar();//Mandar llamr al metodo que registra 
                MostrarCam();//Actualizar la tabla con el nuevo registro 
                Limpiar();//Limpiar las celdas para su reutilizacion
            }
            else
            {
                //Mostrar mensaje en caso de no cumplir la condicion 
                MessageBox.Show("Campos vacios porfavor llenarlos ;)");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Asegurarse de que todos los datos esten completos
            if (txtNombre.Text != "" && txtNumCamion.Text != "" && txtNumero.Text != "" && txtDireccion.Text != "")
            {
                Modificar();//Llamar al metodo que modifica el registro
                MostrarCam();//Actualizar la tabla con el registro modificado
                Limpiar();//Limpiar las celdas para volver a usarlas
                Desactivar();//Desactivar botones no necesarios
            }
            else
            {
                //Mensaje en x¡caso de que no se cumpla la condicion
                MessageBox.Show("Algunos campos estan vacios favor de llenarlos ;)");
            }
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Se elimina el elemento seleccionado 
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
            MostrarCam();//Actualizar la tabla sin el registro 
            Limpiar();//Limpiar las celdas para volver a usar
            Desactivar();//Desactivar los botones que no son requridos 
        }

        private void MostrarCam()//Mostrar los registros
        {
            using (var context = new ApplicationDbContext())
            {
                var Cam = context.Camionero.ToList();
                dgvCamionero.DataSource = Cam;
            }
        }

        private void Modificar()// Modificar el registro seleccionado
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
        }
        public void Activar()//Activar botones Eliminar y modificar
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        public void Desactivar()//Desactivar botones Eliminar y modificar
        {
            btnModificar.Enabled =false;
            btnEliminar.Enabled = false;
        }
        private void Limpiar()//Limpiar las celdas para reutilizarlas
        {
            txtNombre.Text = "";
            txtNumero.Text = "";
            txtNumCamion.Text = "";
            txtDireccion.Text = "";
        }

        public void Registrar()//Se registra los elemntos dentro de las celdas 
        {
            using (var context = new ApplicationDbContext())
            {
                //Crear el objeto
                var Cam = new Camionero();
                Cam.Nombre = txtNombre.Text;
                Cam.Numero = txtNumero.Text;
                Cam.NumCamion = txtNumCamion.Text;
                Cam.Direccion = txtDireccion.Text;


                //Notificamos a EFC el agregar un Camionero
                context.Camionero.Add(Cam);

                //Guardamos los cambios
                context.SaveChanges();
            }
        }

        private void FormCamioneros_Load(object sender, EventArgs e)
        {
            MostrarCam();//Mostrar los registros dentros de la BD
            Desactivar();//Desactivar los botnes inesarios de momento
        }

        private void dgvCamionero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvCamionero.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvCamionero.CurrentRow.Cells[1].Value.ToString();
            txtNumero.Text = dgvCamionero.CurrentRow.Cells[2].Value.ToString();
            txtNumCamion.Text = dgvCamionero.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvCamionero.CurrentRow.Cells[4].Value.ToString();

            Activar();//Activar los botones necesarios 
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var Cam = context.Camionero.Where(x => x.Nombre.Contains(txtNombre.Text)).ToList();
                dgvCamionero.DataSource = Cam;
            }
        }
    }
}
