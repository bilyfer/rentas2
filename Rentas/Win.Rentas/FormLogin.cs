using BL.Rentas;
using System;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormLogin : Form
    {
        public FormMenu MenuPrincipal { get; set; }
        SeguridadBL _seguridad;

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            button1.Enabled = false;
            button1.Text = "Verificando...";
            Application.DoEvents();

            var resultado = _seguridad.Autorizar(usuario, contrasena);
            
            if (resultado.Exitoso == true)
            {
                MenuPrincipal.Autorizar(resultado.Usuario);
                this.Close();
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

            button1.Enabled = true;
            button1.Text = "Aceptar";
        }
    }
}
