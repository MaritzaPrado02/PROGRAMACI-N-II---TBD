
namespace GUI
{
    partial class Login
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.barraLogin = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lsPass = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lsUser = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkPass = new System.Windows.Forms.LinkLabel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            this.barraLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.panelLogo.Controls.Add(this.pictureBox3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 330);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // barraLogin
            // 
            this.barraLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.barraLogin.Controls.Add(this.lblLogin);
            this.barraLogin.Controls.Add(this.btnCerrar);
            this.barraLogin.Controls.Add(this.btnMinimizar);
            this.barraLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraLogin.Location = new System.Drawing.Point(250, 0);
            this.barraLogin.Name = "barraLogin";
            this.barraLogin.Size = new System.Drawing.Size(530, 30);
            this.barraLogin.TabIndex = 2;
            this.barraLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraLogin_MouseDown);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(224, 5);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 19);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Login";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(117)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(310, 78);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(408, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "USUARIO";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lsPass,
            this.lsUser});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lsPass
            // 
            this.lsPass.Name = "lsPass";
            this.lsPass.X1 = 310;
            this.lsPass.X2 = 717;
            this.lsPass.Y1 = 180;
            this.lsPass.Y2 = 180;
            // 
            // lsUser
            // 
            this.lsUser.Name = "lsUser";
            this.lsUser.X1 = 310;
            this.lsUser.X2 = 717;
            this.lsUser.Y1 = 100;
            this.lsUser.Y2 = 100;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(117)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(310, 158);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(408, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.Text = "CONTRASEÑA";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(311, 228);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(407, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "ACCEDER";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkPass
            // 
            this.linkPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.linkPass.AutoSize = true;
            this.linkPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.linkPass.Location = new System.Drawing.Point(417, 280);
            this.linkPass.Name = "linkPass";
            this.linkPass.Size = new System.Drawing.Size(198, 17);
            this.linkPass.TabIndex = 7;
            this.linkPass.TabStop = true;
            this.linkPass.Text = "¿Ha olvidado la contraseña?";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::GUI.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(507, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::GUI.Properties.Resources.min;
            this.btnMinimizar.Location = new System.Drawing.Point(486, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.Logo_Panaderia_2;
            this.pictureBox3.Location = new System.Drawing.Point(0, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 250);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.linkPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.barraLogin);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.panelLogo.ResumeLayout(false);
            this.barraLogin.ResumeLayout(false);
            this.barraLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel barraLogin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lsPass;
        private Microsoft.VisualBasic.PowerPacks.LineShape lsUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkPass;
    }
}

