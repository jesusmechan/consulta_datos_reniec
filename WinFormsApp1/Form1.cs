using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        Metodos cls = null;
        respuestaDNI response = null;

        public Form1()
        {
            InitializeComponent();
            inicializarObjetos();
        }

        void inicializarObjetos()
        {
            cls = new Metodos();
            response = new respuestaDNI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciaBusqueda();
        }


        public async void iniciaBusqueda()
        {
            if (!validarCampos()) return;
            response = await cls.ConsultaDatosReniec(txtNroDoc.Text.ToString());

            if (response == null) return;

            txtNombres.Text = response.nombres;
            txtApePaterno.Text = response.apellidoPaterno;
            txtApMaterno.Text = response.apellidoMaterno;
        }

        public bool validarCampos()
        {
            bool validar = true;
            if (txtNroDoc.Text.Length == 0)
            {
                MessageBox.Show("Ingrese el número de documento");
                return false;
            }

            if (txtNroDoc.Text.Length < 8)
            {
                MessageBox.Show("El número de documento debe tener 8 dígitos ");
                return false;
            }

            return validar;
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            iniciaBusqueda();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNroDoc.Text = "";
            txtNombres.Text = "";
            txtApePaterno.Text = "";
            txtApMaterno.Text = "";
        }
    }
}