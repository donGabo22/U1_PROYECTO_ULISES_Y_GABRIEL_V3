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
    public partial class FormProveedores : Form
    {
        public int id = 0;
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            MostrarProv();//Mostrar la tabla cuando cargue el Form 
            Desactivar();//Desactivar botones no necesarios
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text!="" && txtNumero.Text!="" && txtEmpresa.Text != "")// Condicion para que los campos no queden vacios 
            {
                RegistrarProv();// Mando llamar al metodo para registrar
                MostrarProv();//Actualizar la tabla con el nuevo registro 
                Limpiar();//Limpiar los campos para nuevas interacciones
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos :)");// En caso de error se dezpliega el mensage
            }
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvProveedor.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            txtNumero.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
            txtEmpresa.Text = dgvProveedor.CurrentRow.Cells[3].Value.ToString();

            Activar();
        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != "" && txtNumero.Text != "" && txtEmpresa.Text != "")
            {
                Modificar();//Se manda llamar al metodo 
                MostrarProv();//Se actualiza la tabla con el registro modificado
                Limpiar();//Se limpian las celdas para reutilizarlas
                Desactivar();//Se desactivan los botones no necesarios
            }
            else
            {
                MessageBox.Show("Campos vacios favor de llenarlos");
            }
            
        }
        private void txtEliminar_Click(object sender, EventArgs e)
        {
            //Se elimina el registro seleccionado
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var Prov = context.Proveedores.First(x => x.Id == id);
                    if (Prov != null)
                    {
                        context.Remove(Prov);
                        context.SaveChanges();
                    }
                }
            }
            MostrarProv();//Se actualiza la tabla con el registro eliminado 
            Desactivar();//Se desactivan los botones no necesarion 
            Limpiar();//Se limpian las celdas para reutilizarlas
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var Prov = context.Proveedores.Where(x => x.Nombre.Contains(txtBuscar.Text)).ToList();
                dgvProveedor.DataSource = Prov;
            }

        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtNumero.Text = "";
            txtEmpresa.Text = "";
        }
        private void MostrarProv()
        {
            using (var context = new ApplicationDbContext())
            {
                var Prov = context.Proveedores.ToList();
                dgvProveedor.DataSource = Prov;
            }

        }

        private void RegistrarProv()
        {
            using (var context = new ApplicationDbContext())
            {
                //Crear el objeto
                var Prov = new Proveedores();
                Prov.Nombre = txtNombre.Text;
                Prov.Numero = txtNumero.Text;
                Prov.Empresa = txtEmpresa.Text;
                

                //Notificamos a EFC el agregar un cliente
                context.Proveedores.Add(Prov);

                //Guardamos los cambios
                context.SaveChanges();
            }

        }

        public void Modificar()
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var Prov = context.Proveedores.First(x => x.Id == id);
                    if (Prov != null)
                    {
                        Prov.Nombre = txtNombre.Text;
                        Prov.Numero = txtNumero.Text;
                        Prov.Empresa = txtEmpresa.Text;
                        context.SaveChanges();
                    }
                }
            }
        }
        public void Activar()// Activar botones de Modificar y eliminar 
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        public void Desactivar() //Desactivar los botones de modificar y eliminar
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void horayfecha_Tick(object sender, EventArgs e)
        {
            lblH.Text = DateTime.Now.ToString("H:mm:ss");
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblF.Text = DateTime.Now.ToString("d/MM/yyyy");

          
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {

        }

        private void pbMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
