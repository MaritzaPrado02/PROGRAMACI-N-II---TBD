using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace combos
{
    public partial class frmCine : Form
    {
        claseCombos objCombo = new claseCombos();
        public frmCine()
        {
            InitializeComponent();
            grbSeleccionProductos.Enabled = false;
            btnCrearCombo.Enabled = false;
            txtCosto.Enabled = false;
            btnRegistrarCosto.Enabled = false;
            btnVisualizarCombos.Enabled = false;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (nudCantidad.Text == "")
            {
                errorProvider1.SetError(nudCantidad, "Ingrese la cantidad");
                nudCantidad.Focus();
                return;
            }
            errorProvider1.SetError(nudCantidad, "");

            objCombo.productosCombos[objCombo.nCombo][objCombo.nProductos] = Convert.ToString(cmbProductos.Text);
            objCombo.cantidadProductos[objCombo.nCombo][objCombo.nProductos] = Convert.ToInt32(nudCantidad.Text);
            MessageBox.Show( objCombo.cantidadProductos[objCombo.nCombo][objCombo.nProductos] + " " + objCombo.productosCombos[objCombo.nCombo][objCombo.nProductos] + " agregado(s) a combo: " + objCombo.nombres[objCombo.nNombres -1]);
            objCombo.capturarProdCombo();
            cmbProductos.SelectedIndex = -1;
            nudCantidad.Value = 1;
            btnCrearCombo.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validaciones
             if (txtNombreCombo.Text == "")
            {
                errorProvider1.SetError(txtNombreCombo, "Debe ingresar un nombre");
                txtNombreCombo.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreCombo, "");

            objCombo.almacenarNombre();
            objCombo.definirArreglosProd();
            objCombo.nombres[objCombo.nNombres- 1] = Convert.ToString(txtNombreCombo.Text);
            objCombo.x = 1;
            grbSeleccionProductos.Enabled = true;
            cmbProductos.SelectedIndex = -1;
            txtNombreCombo.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void btnCrearCombo_Click(object sender, EventArgs e)
        {
            objCombo.agregarColumnas();
            objCombo.crearCombo();
            objCombo.z = 1;
            txtCosto.Enabled = true;
            btnRegistrarCosto.Enabled = true;
        }

        private void btnRegistrarCosto_Click(object sender, EventArgs e)
        {     
            objCombo.costoCombos[objCombo.nCostos] = Convert.ToDouble(txtCosto.Text);
            objCombo.almacenarCostosCombos();

            MessageBox.Show("Combo creado " + objCombo.nombres[objCombo.nNombres - 1] + " exitosamente.");

            txtNombreCombo.Text = "";
            txtCosto.Text = "";
            btnVisualizarCombos.Enabled = true;
            txtNombreCombo.Enabled = true;
            btnRegistrar.Enabled = true;
            grbSeleccionProductos.Enabled = false;
            btnCrearCombo.Enabled = false;
            txtCosto.Enabled = false;
            btnRegistrarCosto.Enabled = false;
        }

        private void btnVisualizarCombos_Click(object sender, EventArgs e)
        {
            objCombo.redimensionarArreglos();
            objCombo.definirValores();
            objCombo.n = 1;
            ImprimirCombos();
        }

        public void ImprimirCombos()
        {
            string datos = "";
            string combos = objCombo.imprimirCombos();
            datos = combos + Environment.NewLine;

            MessageBox.Show(datos, "Combos");
        }
    }
}
