namespace Primerprograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerMensaje_Click(object sender, EventArgs e)
        {
            // Creacion de variables en C Sebastian Estuvo aqui en c#
            int  valorNumerico = 20;
            valorNumerico = 15; // Modificar el valor de la variable

            MessageBox.Show("Bienvenido Sebastian Urrego y el valor de su variable es: " + valorNumerico);
        }
    }
}
