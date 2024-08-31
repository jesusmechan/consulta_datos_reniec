using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        Metodos cls = null;
        respuestaDNI response = null;
        respuestaSunat responseSunat = null;
        string tipDocSel = "";

        public Form1()
        {
            InitializeComponent();
            inicializarObjetos();
        }

        void inicializarObjetos()
        {
            cls = new Metodos();
            response = new respuestaDNI();
            responseSunat = new respuestaSunat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckSelectedRadioButton();
            //iniciaBusqueda();
        }


        private void CheckSelectedRadioButton()
        {
            if (rbtnDni.Checked)
                tipDocSel = "DNI";
            else if (rbtnRuc.Checked)
                tipDocSel = "RUC";


            switch (tipDocSel)
            {
                case "DNI":
                    habilitarCampos(true);
                    break;
                case "RUC":
                    habilitarCampos(true);
                    break;
            }
        }

        void habilitarCampos(bool habilitar)
        {

            //switch (tipDocSel)
            //{
            //    case "DNI":
            //        habilitarCamposDNI(true);
            //        habilitarCamposRUC(false);
            //        break;
            //    case "RUC":
            //        habilitarCamposDNI(false);
            //        habilitarCamposRUC(true);
            //        break;
            //}
            switch (tipDocSel)
            {
                case "DNI":
                    panelDNI.Visible = true;
                    panelRUc.Visible = false;
                    //habilitarCamposDNI(false);
                    //habilitarCamposRUC(true);
                    break;
                case "RUC":
                    panelDNI.Visible = false;
                    panelRUc.Visible = true;
                    break;
            }

        }


        void habilitarCamposDNI(bool habilitar)
        {

            lblNombres.Visible = habilitar;
            lblApellidoPaterno.Visible = habilitar;
            lblApellidoMaterno.Visible = habilitar;
            txtNombres.Visible = habilitar;
            txtApePaterno.Visible = habilitar;
            txtApMaterno.Visible = habilitar;
        }

        void habilitarCamposRUC(bool habilitar)
        {

            lblRazonSocial.Visible = habilitar;
            lblDirección.Visible = habilitar;
            lblDepartamento.Visible = habilitar;
            lblProvincia.Visible = habilitar;
            lblDistrito.Visible = habilitar;
            lblUbigeo.Visible = habilitar;
            lblEstado.Visible = habilitar;
            lblCondicion.Visible = habilitar;
            txtRazonSocial.Visible = habilitar;
            txtDireccion.Visible = habilitar;
            txtDepartamento.Visible = habilitar;
            txtProvincia.Visible = habilitar;
            txtDistrito.Visible = habilitar;
            txtUbigeo.Visible = habilitar;
            txtEstado.Visible = habilitar;
            txtCondicion.Visible = habilitar;
        }

        public async void iniciaBusqueda()
        {
            if (!validarCampos()) return;



            switch (tipDocSel)
            {
                case "DNI":
                    response = await consultarDatosReniec();
                    break;
                case "RUC":
                    responseSunat = await consultarDatosSunat();
                    break;

            }

            if (tipDocSel == "DNI")
            {
                txtNombres.Text = response.nombres;
                txtApePaterno.Text = response.apellidoPaterno;
                txtApMaterno.Text = response.apellidoMaterno;
            }
            else
            {
                txtRazonSocial.Text = responseSunat.razonSocial;
            }
        }

        public async Task<respuestaDNI> consultarDatosReniec()
        {
            respuestaDNI datosReniec = new respuestaDNI();
            datosReniec = await cls.ConsultaDatosReniec(txtNroDoc.Text.ToString());

            return datosReniec;
        }

        public async Task<respuestaSunat> consultarDatosSunat()
        {
            respuestaSunat datosSunat = new respuestaSunat();
            datosSunat = await cls.ConsultaDatosSunat(txtNroDoc.Text.ToString());
            return datosSunat;
        }


        public bool validarCampos()
        {
            bool validar = true;

            switch (tipDocSel)
            {
                case "DNI":
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
                    break;
                case "RUC":
                    if (txtNroDoc.Text.Length == 0)
                    {
                        MessageBox.Show("Ingrese el número de documento");
                        return false;
                    }

                    if (txtNroDoc.Text.Length < 11)
                    {
                        MessageBox.Show("El número de documento debe tener 11 dígitos ");
                        return false;
                    }
                    break;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

    }
}