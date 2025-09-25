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

        int intentos = 0;

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido " + txtNombre + "!", "Mensaje");

            if ((txtUsuario.Text == "Alfo" && txtContraseña.Text == "profeaprobame"))
            {
                this.Hide();
                frmMensaje f = new frmMensaje();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
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
