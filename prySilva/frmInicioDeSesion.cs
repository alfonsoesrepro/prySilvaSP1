namespace prySilva
{
    public partial class frmInicioDeSesion : Form
    {
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido " + txtNombre + "!", "Mensaje");

            if ((txtNombre.Text == "Alfo" && txtContraseña.Text == "tuputamadre"))
            {
                this.Hide();
                frmMensaje f = new frmMensaje();
                f.Text = txtNombre.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                int intentos = 0;
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
