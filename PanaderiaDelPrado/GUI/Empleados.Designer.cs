
namespace GUI
{
    partial class Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlsMenuEmpleados = new System.Windows.Forms.ToolStrip();
            this.contenedorPantHijasEmpleados = new System.Windows.Forms.Panel();
            this.tsbRegistroEmpleados = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarEmpleados = new System.Windows.Forms.ToolStripButton();
            this.tsbPagosEmpleados = new System.Windows.Forms.ToolStripButton();
            this.tlsMenuEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsMenuEmpleados
            // 
            this.tlsMenuEmpleados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRegistroEmpleados,
            this.tsbBuscarEmpleados,
            this.tsbPagosEmpleados});
            this.tlsMenuEmpleados.Location = new System.Drawing.Point(0, 0);
            this.tlsMenuEmpleados.Name = "tlsMenuEmpleados";
            this.tlsMenuEmpleados.Size = new System.Drawing.Size(947, 25);
            this.tlsMenuEmpleados.TabIndex = 0;
            this.tlsMenuEmpleados.Text = "toolStrip1";
            // 
            // contenedorPantHijasEmpleados
            // 
            this.contenedorPantHijasEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorPantHijasEmpleados.Location = new System.Drawing.Point(0, 25);
            this.contenedorPantHijasEmpleados.Name = "contenedorPantHijasEmpleados";
            this.contenedorPantHijasEmpleados.Size = new System.Drawing.Size(947, 701);
            this.contenedorPantHijasEmpleados.TabIndex = 1;
            // 
            // tsbRegistroEmpleados
            // 
            this.tsbRegistroEmpleados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRegistroEmpleados.Image = global::GUI.Properties.Resources.icono_registro;
            this.tsbRegistroEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegistroEmpleados.Name = "tsbRegistroEmpleados";
            this.tsbRegistroEmpleados.Size = new System.Drawing.Size(23, 22);
            this.tsbRegistroEmpleados.Text = "Registrar datos de un empleado";
            this.tsbRegistroEmpleados.Click += new System.EventHandler(this.tsbRegistroEmpleados_Click);
            // 
            // tsbBuscarEmpleados
            // 
            this.tsbBuscarEmpleados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscarEmpleados.Image = global::GUI.Properties.Resources.icono_buscar;
            this.tsbBuscarEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarEmpleados.Name = "tsbBuscarEmpleados";
            this.tsbBuscarEmpleados.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscarEmpleados.Text = "Buscar empleado";
            // 
            // tsbPagosEmpleados
            // 
            this.tsbPagosEmpleados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPagosEmpleados.Image = global::GUI.Properties.Resources.icono_pago;
            this.tsbPagosEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPagosEmpleados.Name = "tsbPagosEmpleados";
            this.tsbPagosEmpleados.Size = new System.Drawing.Size(23, 22);
            this.tsbPagosEmpleados.Text = "Pagos de empleados";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(947, 726);
            this.Controls.Add(this.contenedorPantHijasEmpleados);
            this.Controls.Add(this.tlsMenuEmpleados);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.tlsMenuEmpleados.ResumeLayout(false);
            this.tlsMenuEmpleados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsMenuEmpleados;
        private System.Windows.Forms.ToolStripButton tsbRegistroEmpleados;
        private System.Windows.Forms.ToolStripButton tsbBuscarEmpleados;
        private System.Windows.Forms.ToolStripButton tsbPagosEmpleados;
        private System.Windows.Forms.Panel contenedorPantHijasEmpleados;
    }
}