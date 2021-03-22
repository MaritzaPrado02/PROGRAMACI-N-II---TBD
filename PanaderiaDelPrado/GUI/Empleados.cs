using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private Form activarForm = null;
        private void abrirFormularioHijoEmpleados(Form formularioHijo)
        {
            if (activarForm != null)
                activarForm.Close();
            activarForm = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            contenedorPantHijasEmpleados.Controls.Add(formularioHijo);
            contenedorPantHijasEmpleados.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void tsbRegistroEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormularioHijoEmpleados(new RegistroEmpleados());
        }
    }
}
