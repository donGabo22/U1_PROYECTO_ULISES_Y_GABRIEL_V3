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
    public partial class FormInventario2 : Form
    {
        public int id = 0;
        public FormInventario2()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var producto = context.Inventarios2.First(x => x.Id == id);
                    if (producto != null)
                    {

                        producto.Nombre = txbNombre.Text;
                        producto.tipoProducto = cbTipo.SelectedItem.ToString(); 
                        producto.Cantidad = txbCantidad.Text;
                        producto.Empresa= cbTipo.SelectedItem.ToString();
                        producto.precio = txbprecio.Text;
                        producto.Zona = txbZona.Text;
                        context.SaveChanges();
                        // todoProducto(); ?
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //AgregarProducto();
            //todoProducto();
            Limpiar();
        }
        private void Limpiar()
        {
            txbNombre.Text = "";
            cbTipo.Text = "";
            txbCantidad.Text = "";
            txbprecio.Text = "";
            txbZona.Text = "";
        }

        private void BuscarProducto()
        {
            using (var context = new ApplicationDbContext())
            {
                var emp = context.Inventarios2.Where(x => x.Nombre.Contains(txbBusqueda.Text)).ToList();
                dgvinventario.DataSource = emp; //2
            }
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var p = context.Inventarios2.Where(x => x.Nombre.Contains(txbprecio.Text)).ToList();
                dgvinventario.DataSource = p;
            }
        }

        private void dgvinventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvinventario.CurrentRow.Cells[0].Value.ToString());
            txbNombre.Text = dgvinventario.CurrentRow.Cells[1].Value.ToString();
            cbTipo.Text = dgvinventario.CurrentRow.Cells[2].Value.ToString();
            txbCantidad.Text = dgvinventario.CurrentRow.Cells[3].Value.ToString();
           
            FormProveedores frmprov = new FormProveedores();
            //cbEmpresa.Text =frmprov.empresa

           txbprecio.Text = dgvinventario.CurrentRow.Cells[5].Value.ToString();
            txbZona.Text = dgvinventario.CurrentRow.Cells[6].Value.ToString();
            lblHoraandFecha.Text = (dgvinventario.CurrentRow.Cells[7].Value.ToString());

        }

        private void AgregarProducto()
        {
            using (var context = new ApplicationDbContext())
            {
                //paso 1 crear el objeto 
            var Inventario1 = new Inventario2();
                Inventario1.Nombre = txbNombre.Text;
                Inventario1.tipoProducto = cbTipo.SelectedItem.ToString();
                Inventario1.Cantidad = txbCantidad.Text;
                Inventario1.Empresa = cbEmpresa.SelectedItem.ToString();
                Inventario1.precio = txbprecio.Text;
                Inventario1.Zona = txbZona.Text;
                Inventario1.fecha = lblHoraandFecha.Text;




                context.Inventarios2.Add(Inventario1);



                context.SaveChanges();

            }
        }
        private void todoProducto()
        {
            using (var context = new ApplicationDbContext())
            {
                var inv = context.Inventarios2.ToList();
                dgvinventario.DataSource = inv;
            }
        }

        private void FormInventario2_Load(object sender, EventArgs e)
        {
            todoProducto();
        }
    }




}
