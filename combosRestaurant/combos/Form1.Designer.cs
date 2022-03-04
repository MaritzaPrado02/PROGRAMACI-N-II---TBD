
namespace combos
{
    partial class frmCine
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCombo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grbCombo = new System.Windows.Forms.GroupBox();
            this.grbSeleccionProductos = new System.Windows.Forms.GroupBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCrearCombo = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.btnRegistrarCosto = new System.Windows.Forms.Button();
            this.btnVisualizarCombos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.grbCombo.SuspendLayout();
            this.grbSeleccionProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del combo";
            // 
            // txtNombreCombo
            // 
            this.txtNombreCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCombo.Location = new System.Drawing.Point(170, 41);
            this.txtNombreCombo.Name = "txtNombreCombo";
            this.txtNombreCombo.Size = new System.Drawing.Size(170, 26);
            this.txtNombreCombo.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(362, 36);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(104, 37);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // grbCombo
            // 
            this.grbCombo.Controls.Add(this.label1);
            this.grbCombo.Controls.Add(this.btnRegistrar);
            this.grbCombo.Controls.Add(this.txtNombreCombo);
            this.grbCombo.Location = new System.Drawing.Point(12, 12);
            this.grbCombo.Name = "grbCombo";
            this.grbCombo.Size = new System.Drawing.Size(495, 99);
            this.grbCombo.TabIndex = 3;
            this.grbCombo.TabStop = false;
            this.grbCombo.Text = "Combo";
            // 
            // grbSeleccionProductos
            // 
            this.grbSeleccionProductos.Controls.Add(this.nudCantidad);
            this.grbSeleccionProductos.Controls.Add(this.lblCantidad);
            this.grbSeleccionProductos.Controls.Add(this.btnAgregar);
            this.grbSeleccionProductos.Controls.Add(this.cmbProductos);
            this.grbSeleccionProductos.Location = new System.Drawing.Point(12, 118);
            this.grbSeleccionProductos.Name = "grbSeleccionProductos";
            this.grbSeleccionProductos.Size = new System.Drawing.Size(495, 165);
            this.grbSeleccionProductos.TabIndex = 4;
            this.grbSeleccionProductos.TabStop = false;
            this.grbSeleccionProductos.Text = "Seleccione productos";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Items.AddRange(new object[] {
            "Palomitas Ch",
            "Palomitas Md",
            "Palomitas Gd",
            "Ice",
            "Refresco Md",
            "Refresco Gd",
            "Nachos",
            "Hot Dog",
            "M&M´s",
            "Corneto",
            "Papas",
            "Helado Micha \"Holanda\" ",
            "Magnum",
            "Crepa",
            "",
            "",
            ""});
            this.cmbProductos.Location = new System.Drawing.Point(58, 42);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(226, 28);
            this.cmbProductos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(362, 72);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCrearCombo
            // 
            this.btnCrearCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCombo.Location = new System.Drawing.Point(195, 304);
            this.btnCrearCombo.Name = "btnCrearCombo";
            this.btnCrearCombo.Size = new System.Drawing.Size(112, 41);
            this.btnCrearCombo.TabIndex = 5;
            this.btnCrearCombo.Text = "Crear Combo";
            this.btnCrearCombo.UseVisualStyleBackColor = true;
            this.btnCrearCombo.Click += new System.EventHandler(this.btnCrearCombo_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(269, 390);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(101, 26);
            this.txtCosto.TabIndex = 6;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(39, 393);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(216, 20);
            this.lblCosto.TabIndex = 7;
            this.lblCosto.Text = "Ingrese el costo del combo: $";
            // 
            // btnRegistrarCosto
            // 
            this.btnRegistrarCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCosto.Location = new System.Drawing.Point(387, 387);
            this.btnRegistrarCosto.Name = "btnRegistrarCosto";
            this.btnRegistrarCosto.Size = new System.Drawing.Size(91, 32);
            this.btnRegistrarCosto.TabIndex = 8;
            this.btnRegistrarCosto.Text = "Registrar";
            this.btnRegistrarCosto.UseVisualStyleBackColor = true;
            this.btnRegistrarCosto.Click += new System.EventHandler(this.btnRegistrarCosto_Click);
            // 
            // btnVisualizarCombos
            // 
            this.btnVisualizarCombos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarCombos.Location = new System.Drawing.Point(167, 456);
            this.btnVisualizarCombos.Name = "btnVisualizarCombos";
            this.btnVisualizarCombos.Size = new System.Drawing.Size(170, 44);
            this.btnVisualizarCombos.TabIndex = 9;
            this.btnVisualizarCombos.Text = "Visualizar Combos";
            this.btnVisualizarCombos.UseVisualStyleBackColor = true;
            this.btnVisualizarCombos.Click += new System.EventHandler(this.btnVisualizarCombos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(54, 102);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(144, 100);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(110, 26);
            this.nudCantidad.TabIndex = 3;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 543);
            this.Controls.Add(this.btnVisualizarCombos);
            this.Controls.Add(this.btnRegistrarCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.btnCrearCombo);
            this.Controls.Add(this.grbSeleccionProductos);
            this.Controls.Add(this.grbCombo);
            this.Name = "frmCine";
            this.Text = "Cine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbCombo.ResumeLayout(false);
            this.grbCombo.PerformLayout();
            this.grbSeleccionProductos.ResumeLayout(false);
            this.grbSeleccionProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCombo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grbCombo;
        private System.Windows.Forms.GroupBox grbSeleccionProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Button btnCrearCombo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Button btnRegistrarCosto;
        private System.Windows.Forms.Button btnVisualizarCombos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
    }
}

