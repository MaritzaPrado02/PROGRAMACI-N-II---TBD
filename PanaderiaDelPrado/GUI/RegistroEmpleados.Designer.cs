
namespace GUI
{
    partial class RegistroEmpleados
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
            this.components = new System.ComponentModel.Container();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreObligatorio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbDireccion = new System.Windows.Forms.GroupBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblObligatorioApPat = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.txtNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.lblObligatorioTelefono = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.grbTipoPago = new System.Windows.Forms.GroupBox();
            this.lblSeleccionPago = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.txtCasa = new System.Windows.Forms.TextBox();
            this.lblObligatorioCalle = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblObligatorioSeleccion = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblObligatorioNumero = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblObligatorioColonia = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lblObligatorioEstado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblObligatorioLocalidad = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.grbDireccion.SuspendLayout();
            this.grbTipoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(47, 61);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(236, 25);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro de empleado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(139, 153);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreObligatorio
            // 
            this.lblNombreObligatorio.AutoSize = true;
            this.lblNombreObligatorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreObligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreObligatorio.Location = new System.Drawing.Point(209, 153);
            this.lblNombreObligatorio.Name = "lblNombreObligatorio";
            this.lblNombreObligatorio.Size = new System.Drawing.Size(16, 21);
            this.lblNombreObligatorio.TabIndex = 2;
            this.lblNombreObligatorio.Text = "*";
            this.toolTip1.SetToolTip(this.lblNombreObligatorio, "*OBLIGATORIO");
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(231, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 20);
            this.txtNombre.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNombre, "Ingrese nombre de empleado ");
            // 
            // grbDireccion
            // 
            this.grbDireccion.Controls.Add(this.cmbLocalidad);
            this.grbDireccion.Controls.Add(this.cmbEstado);
            this.grbDireccion.Controls.Add(this.lblObligatorioLocalidad);
            this.grbDireccion.Controls.Add(this.lblLocalidad);
            this.grbDireccion.Controls.Add(this.lblObligatorioEstado);
            this.grbDireccion.Controls.Add(this.lblEstado);
            this.grbDireccion.Controls.Add(this.txtLocalidad);
            this.grbDireccion.Controls.Add(this.lblObligatorioColonia);
            this.grbDireccion.Controls.Add(this.lblColonia);
            this.grbDireccion.Controls.Add(this.textBox2);
            this.grbDireccion.Controls.Add(this.lblObligatorioNumero);
            this.grbDireccion.Controls.Add(this.lblNumero);
            this.grbDireccion.Controls.Add(this.txtCasa);
            this.grbDireccion.Controls.Add(this.lblObligatorioCalle);
            this.grbDireccion.Controls.Add(this.lblCalle);
            this.grbDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDireccion.ForeColor = System.Drawing.Color.White;
            this.grbDireccion.Location = new System.Drawing.Point(13, 348);
            this.grbDireccion.Name = "grbDireccion";
            this.grbDireccion.Size = new System.Drawing.Size(651, 310);
            this.grbDireccion.TabIndex = 4;
            this.grbDireccion.TabStop = false;
            this.grbDireccion.Text = "Dirección";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(302, 201);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(196, 20);
            this.txtApellidoPaterno.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtApellidoPaterno, "Ingrese apellido paterno del empleado");
            // 
            // lblObligatorioApPat
            // 
            this.lblObligatorioApPat.AutoSize = true;
            this.lblObligatorioApPat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioApPat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObligatorioApPat.Location = new System.Drawing.Point(280, 198);
            this.lblObligatorioApPat.Name = "lblObligatorioApPat";
            this.lblObligatorioApPat.Size = new System.Drawing.Size(16, 21);
            this.lblObligatorioApPat.TabIndex = 6;
            this.lblObligatorioApPat.Text = "*";
            this.toolTip1.SetToolTip(this.lblObligatorioApPat, "*OBLIGATORIO");
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.ForeColor = System.Drawing.Color.White;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(139, 200);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(144, 21);
            this.lblApellidoPaterno.TabIndex = 5;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(302, 252);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(196, 20);
            this.txtApellidoMaterno.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtApellidoMaterno, "Ingresar apellido materno del empleado");
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.ForeColor = System.Drawing.Color.White;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(139, 252);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(150, 21);
            this.lblApellidoMaterno.TabIndex = 8;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(680, 486);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(255, 40);
            this.btnRegistrarEmpleado.TabIndex = 11;
            this.btnRegistrarEmpleado.Text = "REGISTRAR";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = false;
            // 
            // txtNumeroTelefonico
            // 
            this.txtNumeroTelefonico.Location = new System.Drawing.Point(237, 300);
            this.txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            this.txtNumeroTelefonico.Size = new System.Drawing.Size(261, 20);
            this.txtNumeroTelefonico.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtNumeroTelefonico, "Ingrese número telefónico (10 dígitos)");
            // 
            // lblObligatorioTelefono
            // 
            this.lblObligatorioTelefono.AutoSize = true;
            this.lblObligatorioTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObligatorioTelefono.Location = new System.Drawing.Point(215, 300);
            this.lblObligatorioTelefono.Name = "lblObligatorioTelefono";
            this.lblObligatorioTelefono.Size = new System.Drawing.Size(16, 21);
            this.lblObligatorioTelefono.TabIndex = 14;
            this.lblObligatorioTelefono.Text = "*";
            this.toolTip1.SetToolTip(this.lblObligatorioTelefono, "*OBLIGATORIO");
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(139, 300);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(80, 21);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // grbTipoPago
            // 
            this.grbTipoPago.Controls.Add(this.lblObligatorioSeleccion);
            this.grbTipoPago.Controls.Add(this.cmbTipoPago);
            this.grbTipoPago.Controls.Add(this.lblSeleccionPago);
            this.grbTipoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTipoPago.ForeColor = System.Drawing.Color.White;
            this.grbTipoPago.Location = new System.Drawing.Point(691, 180);
            this.grbTipoPago.Name = "grbTipoPago";
            this.grbTipoPago.Size = new System.Drawing.Size(234, 141);
            this.grbTipoPago.TabIndex = 5;
            this.grbTipoPago.TabStop = false;
            this.grbTipoPago.Text = "Tipo de pago";
            // 
            // lblSeleccionPago
            // 
            this.lblSeleccionPago.AutoSize = true;
            this.lblSeleccionPago.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionPago.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionPago.Location = new System.Drawing.Point(40, 44);
            this.lblSeleccionPago.Name = "lblSeleccionPago";
            this.lblSeleccionPago.Size = new System.Drawing.Size(154, 16);
            this.lblSeleccionPago.TabIndex = 16;
            this.lblSeleccionPago.Text = "Seleccione el tipo de pago";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Diario",
            "Semanal"});
            this.cmbTipoPago.Location = new System.Drawing.Point(43, 82);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(151, 29);
            this.cmbTipoPago.TabIndex = 17;
            // 
            // txtCasa
            // 
            this.txtCasa.Location = new System.Drawing.Point(230, 49);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(261, 27);
            this.txtCasa.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtCasa, "Ingrese calle");
            // 
            // lblObligatorioCalle
            // 
            this.lblObligatorioCalle.AutoSize = true;
            this.lblObligatorioCalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObligatorioCalle.Location = new System.Drawing.Point(187, 49);
            this.lblObligatorioCalle.Name = "lblObligatorioCalle";
            this.lblObligatorioCalle.Size = new System.Drawing.Size(16, 21);
            this.lblObligatorioCalle.TabIndex = 17;
            this.lblObligatorioCalle.Text = "*";
            this.toolTip1.SetToolTip(this.lblObligatorioCalle, "*OBLIGATORIO");
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.ForeColor = System.Drawing.Color.White;
            this.lblCalle.Location = new System.Drawing.Point(132, 49);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(54, 21);
            this.lblCalle.TabIndex = 16;
            this.lblCalle.Text = "Calle:";
            // 
            // lblObligatorioSeleccion
            // 
            this.lblObligatorioSeleccion.AutoSize = true;
            this.lblObligatorioSeleccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioSeleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObligatorioSeleccion.Location = new System.Drawing.Point(191, 39);
            this.lblObligatorioSeleccion.Name = "lblObligatorioSeleccion";
            this.lblObligatorioSeleccion.Size = new System.Drawing.Size(16, 21);
            this.lblObligatorioSeleccion.TabIndex = 16;
            this.lblObligatorioSeleccion.Text = "*";
            this.toolTip1.SetToolTip(this.lblObligatorioSeleccion, "*OBLIGATORIO");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 27);
            this.textBox2.TabIndex = 21;
            this.toolTip1.SetToolTip(this.textBox2, "Ingrese número de la calle");
            // 
            // lblObligatorioNumero
            // 
            this.lblObligatorioNumero.AutoSize = true;
            this.lblObligatorioNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObligatorioNumero.Location = new System.Drawing.Point(208, 99);
            this.lblObligatorioNumero.Name = "lblObligatorioNumero";
            this.lblObligatorioNumero.Size = new System.Drawing.Size(16, 21);
            this.lblObligatorioNumero.TabIndex = 20;
            this.lblObligatorioNumero.Text = "*";
            this.toolTip1.SetToolTip(this.lblObligatorioNumero, "*OBLIGATORIO");
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(132, 99);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(76, 21);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "Número:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(230, 151);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(261, 27);
            this.txtLocalidad.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtLocalidad, "Ingrese colonia");
            // 
            // lblObligatorioColonia
            // 
            this.lblObligatorioColonia.AutoSize = true;
            this.lblObligatorioColonia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObligatorioColonia.Location = new System.Drawing.Point(203, 151);
            this.lblObligatorioColonia.Name = "lblObligatorioColonia";
            this.lblObligatorioColonia.Size = new System.Drawing.Size(16, 21);
            this.lblObligatorioColonia.TabIndex = 23;
            this.lblObligatorioColonia.Text = "*";
            this.toolTip1.SetToolTip(this.lblObligatorioColonia, "*OBLIGATORIO");
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonia.ForeColor = System.Drawing.Color.White;
            this.lblColonia.Location = new System.Drawing.Point(132, 151);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(74, 21);
            this.lblColonia.TabIndex = 22;
            this.lblColonia.Text = "Colonia:";
            // 
            // lblObligatorioEstado
            // 
            this.lblObligatorioEstado.AutoSize = true;
            this.lblObligatorioEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObligatorioEstado.Location = new System.Drawing.Point(197, 207);
            this.lblObligatorioEstado.Name = "lblObligatorioEstado";
            this.lblObligatorioEstado.Size = new System.Drawing.Size(16, 21);
            this.lblObligatorioEstado.TabIndex = 26;
            this.lblObligatorioEstado.Text = "*";
            this.toolTip1.SetToolTip(this.lblObligatorioEstado, "*OBLIGATORIO");
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(132, 207);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 21);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado:";
            // 
            // lblObligatorioLocalidad
            // 
            this.lblObligatorioLocalidad.AutoSize = true;
            this.lblObligatorioLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObligatorioLocalidad.Location = new System.Drawing.Point(220, 260);
            this.lblObligatorioLocalidad.Name = "lblObligatorioLocalidad";
            this.lblObligatorioLocalidad.Size = new System.Drawing.Size(16, 21);
            this.lblObligatorioLocalidad.TabIndex = 29;
            this.lblObligatorioLocalidad.Text = "*";
            this.toolTip1.SetToolTip(this.lblObligatorioLocalidad, "*OBLIGATORIO");
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.White;
            this.lblLocalidad.Location = new System.Drawing.Point(132, 260);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(91, 21);
            this.lblLocalidad.TabIndex = 28;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(230, 204);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(261, 29);
            this.cmbEstado.TabIndex = 31;
            this.toolTip1.SetToolTip(this.cmbEstado, "Seleccione estado");
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(243, 257);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(248, 29);
            this.cmbLocalidad.TabIndex = 32;
            this.toolTip1.SetToolTip(this.cmbLocalidad, "Seleccione localidad");
            // 
            // RegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(947, 701);
            this.Controls.Add(this.grbTipoPago);
            this.Controls.Add(this.txtNumeroTelefonico);
            this.Controls.Add(this.lblObligatorioTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.lblApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lblObligatorioApPat);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.grbDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreObligatorio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRegistro);
            this.Name = "RegistroEmpleados";
            this.Text = "RegistroEmpleados";
            this.grbDireccion.ResumeLayout(false);
            this.grbDireccion.PerformLayout();
            this.grbTipoPago.ResumeLayout(false);
            this.grbTipoPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreObligatorio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grbDireccion;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblObligatorioApPat;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.TextBox txtNumeroTelefonico;
        private System.Windows.Forms.Label lblObligatorioTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox grbTipoPago;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label lblSeleccionPago;
        private System.Windows.Forms.TextBox txtCasa;
        private System.Windows.Forms.Label lblObligatorioCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblObligatorioSeleccion;
        private System.Windows.Forms.Label lblObligatorioLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblObligatorioEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblObligatorioColonia;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblObligatorioNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}