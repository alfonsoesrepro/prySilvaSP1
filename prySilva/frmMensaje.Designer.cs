namespace prySilva
{
    partial class frmMensaje
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
            label1 = new Label();
            cmdCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label1.Location = new Point(63, 53);
            label1.Name = "label1";
            label1.Size = new Size(333, 74);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido!";
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(177, 188);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 23);
            cmdCancelar.TabIndex = 1;
            cmdCancelar.Text = "Aceptar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // frmMensaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 251);
            Controls.Add(cmdCancelar);
            Controls.Add(label1);
            Name = "frmMensaje";
            Text = "Mensaje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button cmdCancelar;
    }
}