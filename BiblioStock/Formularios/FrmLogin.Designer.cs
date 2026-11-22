
namespace BiblioStock.Formularios
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbBibliotecarios;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblMensaje;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlPrincipal = new Panel();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlFormulario = new Panel();
            lblUsuario = new Label();
            cmbBibliotecarios = new ComboBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            lblMensaje = new Label();
            pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.FromArgb(24, 42, 72);
            pnlPrincipal.Controls.Add(picLogo);
            pnlPrincipal.Controls.Add(lblTitulo);
            pnlPrincipal.Controls.Add(lblSubtitulo);
            pnlPrincipal.Dock = DockStyle.Left;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Margin = new Padding(3, 4, 3, 4);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(380, 725);
            pnlPrincipal.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.Logo_moderno_BiblioStock_para_bibliotecas;
            picLogo.Location = new Point(90, 105);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 150);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 281);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 69);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "BIBLIOSTOCK";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(210, 220, 235);
            lblSubtitulo.Location = new Point(25, 356);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(330, 75);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Sistema inteligente de gestion bibliotecaria";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.White;
            pnlFormulario.Controls.Add(lblUsuario);
            pnlFormulario.Controls.Add(cmbBibliotecarios);
            pnlFormulario.Controls.Add(lblContrasena);
            pnlFormulario.Controls.Add(txtContrasena);
            pnlFormulario.Controls.Add(btnIngresar);
            pnlFormulario.Controls.Add(lblMensaje);
            pnlFormulario.Location = new Point(440, 106);
            pnlFormulario.Margin = new Padding(3, 4, 3, 4);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(390, 512);
            pnlFormulario.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(45, 55, 72);
            lblUsuario.Location = new Point(35, 112);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(207, 23);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Seleccionar bibliotecario";
            // 
            // cmbBibliotecarios
            // 
            cmbBibliotecarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBibliotecarios.Font = new Font("Segoe UI", 11F);
            cmbBibliotecarios.FormattingEnabled = true;
            cmbBibliotecarios.Location = new Point(38, 150);
            cmbBibliotecarios.Margin = new Padding(3, 4, 3, 4);
            cmbBibliotecarios.Name = "cmbBibliotecarios";
            cmbBibliotecarios.Size = new Size(310, 33);
            cmbBibliotecarios.TabIndex = 0;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContrasena.ForeColor = Color.FromArgb(45, 55, 72);
            lblContrasena.Location = new Point(35, 219);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(99, 23);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contrasena";
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Font = new Font("Segoe UI", 11F);
            txtContrasena.Location = new Point(38, 256);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(310, 32);
            txtContrasena.TabIndex = 1;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(37, 99, 235);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(38, 331);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(310, 56);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.Font = new Font("Segoe UI", 9F);
            lblMensaje.ForeColor = Color.Gray;
            lblMensaje.Location = new Point(30, 412);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(330, 50);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "Acceso exclusivo para bibliotecarios";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 248);
            ClientSize = new Size(900, 725);
            Controls.Add(pnlFormulario);
            Controls.Add(pnlPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BiblioStock - Acceso al sistema";
            pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            ResumeLayout(false);
        }
    }
}
