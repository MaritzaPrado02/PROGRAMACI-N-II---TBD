using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void btnReportes_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = true;
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void btnReporteProduccion_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Empleados());
        }

        private Form activarForm = null;

        private void abrirFormularioHijo(Form formularioHijo)
        {
            if (activarForm != null)
                activarForm.Close();
            activarForm = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            contenedorPantallasHijas.Controls.Add(formularioHijo);
            contenedorPantallasHijas.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
    }
}
