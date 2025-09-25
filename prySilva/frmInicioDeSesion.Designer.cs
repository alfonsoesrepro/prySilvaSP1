namespace prySilva
{
    partial class frmInicioDeSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            cmdAceptar = new Button();
            cmdCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(27, 49);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += label1_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(27, 99);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(134, 41);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(114, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(134, 99);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(114, 23);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // cmdAceptar
            // 
            cmdAceptar.Location = new Point(309, 41);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(75, 23);
            cmdAceptar.TabIndex = 4;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = true;
            cmdAceptar.Click += cmdAceptar_Click;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(309, 98);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 23);
            cmdCancelar.TabIndex = 5;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // frmInicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 199);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "frmInicioDeSesion";
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button cmdAceptar;
        private Button cmdCancelar;
    }
}
