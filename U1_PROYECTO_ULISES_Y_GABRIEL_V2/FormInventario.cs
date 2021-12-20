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
    public partial class FormInventario : Form
    {
        public int id = 0;

        public FormInventario()
        {
            InitializeComponent();
        }

        private void horayfecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("H:mm:ss");
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToString("d/MM/yyyy");
            lblHoraandFecha.Text = DateTime.Now.ToString();


        }
        private void pbMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            todoProducto();
            Limpiar();

        }
        private void Limpiar()
        {
         txbNombre.Text="";
         cbTipo.Text="";
         txbCantidad.Text="";
         txbprecio.Text="";
         txbZona.Text="";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var producto = context.Inventarios.First(x => x.Id == id);
                    if (producto != null)
                    {

                        producto.Nombre = txbNombre.Text;
                        producto.tipoProducto = cbTipo.SelectedItem.ToString(); ;
                        producto.Cantidad = txbCantidad.Text;
                        producto.precio = txbprecio.Text;
                        producto.Zona = txbZona.Text;
                        context.SaveChanges();
                        // todoProducto(); ?
                    }
                }
            }
            Limpiar();
            todoProducto();
            Desactivar();

        }




        private void BuscarProducto()
        {
            using (var context = new ApplicationDbContext())
            {
                var emp = context.Inventarios.Where(x => x.Nombre.Contains(txbBusqueda.Text)).ToList();
                dgvinventario.DataSource = emp;
            }
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var p = context.Inventarios.Where(x => x.Nombre.Contains(txbprecio.Text)).ToList();
                dgvinventario.DataSource = p;
            }
        }

        private void dgvinventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvinventario.CurrentRow.Cells[0].Value.ToString());
            txbNombre.Text = dgvinventario.CurrentRow.Cells[1].Value.ToString();
            cbTipo.Text = dgvinventario.CurrentRow.Cells[2].Value.ToString();
            txbCantidad.Text = dgvinventario.CurrentRow.Cells[3].Value.ToString();
            txbprecio.Text = dgvinventario.CurrentRow.Cells[4].Value.ToString();
            txbZona.Text = dgvinventario.CurrentRow.Cells[5].Value.ToString();
            lblHoraandFecha.Text = (dgvinventario.CurrentRow.Cells[6].Value.ToString());

            Activar();
        }



        private void AgregarProducto()
        {
            using (var context = new ApplicationDbContext())
            {
                //paso 1 crear el objeto 
                var Inventario1 = new Inventario();
                Inventario1.Nombre = txbNombre.Text;
                Inventario1.tipoProducto = cbTipo.SelectedItem.ToString();
                Inventario1.Cantidad = txbCantidad.Text;
                Inventario1.precio = txbprecio.Text;
                Inventario1.Zona = txbZona.Text;
                Inventario1.fecha = lblHoraandFecha.Text;
    



                context.Inventarios.Add(Inventario1);



                context.SaveChanges();

            }
        }

        public  void Activar()
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        public void Desactivar()
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }





        private void todoProducto()
        {
            using (var context = new ApplicationDbContext())
            {
                var inv = context.Inventarios.ToList();
                dgvinventario.DataSource = inv;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var producto = context.Inventarios.First(x => x.Id == id);
                    if (producto != null)
                    {
                        context.Remove(producto);
                        context.SaveChanges();
                        todoProducto(); //?
                    }
                }

            }
            Limpiar();
            todoProducto();
            Desactivar();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            todoProducto();
            Desactivar();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}