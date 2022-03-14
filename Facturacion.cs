using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISEÑO_NOMINA
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        List<Producto> listaProductos = new List<Producto>();

        private void Facturacion_Load(object sender, EventArgs e)
        {
            txtCant.Text = "";
            txtCodig.Text = "";
            txtIVA.Text = "";
            txtPrecioUni.Text = "";
            txtProduc.Text = "";
            txtTotalaP.Text = "";
            txtUsua.Text = "";
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            String ProductoNombre;
            double PrecioUnitario;
            int Cantidad;
            double IVA;
            double TotalaPagar;
            int Usuario;
            String codigo;

            ProductoNombre = txtProduc.Text;
            codigo = txtCodig.Text;
            PrecioUnitario = Convert.ToInt32(txtPrecioUni.Text);
            Cantidad = Convert.ToInt32(txtCant.Text);
            IVA = Convert.ToInt32(txtIVA.Text);
            
            Producto prod1 = new Producto();
            prod1.Cantidad = Cantidad;
            prod1.codigo = codigo;
            prod1.IVA = IVA;
            prod1.PrecioUnitario = PrecioUnitario;
            prod1.productoNombre = ProductoNombre;

            listaProductos.Add(prod1);
            BindingSource source = new BindingSource();
            source.DataSource = listaProductos;
            gwProductos.DataSource = source;
            gwProductos.AutoGenerateColumns = true;
            gwProductos.Update();
            gwProductos.Refresh();
        }
    }
}
