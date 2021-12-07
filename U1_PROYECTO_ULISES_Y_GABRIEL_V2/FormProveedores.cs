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
            MostrarProv();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarProv();
            MostrarProv();
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvProveedor.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            txtNumero.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
            txtEmpresa.Text = dgvProveedor.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtModificar_Click(object sender, EventArgs e)
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
            MostrarProv();
            Limpiar();
            
        }
        private void txtEliminar_Click(object sender, EventArgs e)
        {
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
            MostrarProv();
            Limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var Prov = context.Proveedores.Where(x => x.Nombre.Contains(txtNombre.Text)).ToList();
                dgvProveedor.DataSource = Prov;
            }

        }
//añslkdfjañlskdjfaldskjfañlskdjfañlskdjfañlskdjfañlskdjf
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

        
    }
}
