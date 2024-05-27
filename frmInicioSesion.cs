using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryInicioSesionLogs
{
    public partial class frmInicioSesion : Form
    {
        private clsUsuario Usuario; // Declaro la variable 'usuario'

        public frmInicioSesion()
        {
            InitializeComponent();
            Usuario = new clsUsuario(); // Instancio 'clsUsuario'
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text; // Asigno el valor de 'txtUsuario' a una variable
            string claveUsuario = txtContraseña.Text; // Asigno el valor de 'txtContraseña' a una variable

            Usuario.ValidarUsuario(nombreUsuario, claveUsuario); // Llamo al método 'ValidarUsuario'

            if (Usuario.estadoConexion == "Usuario EXISTE") // Verifico el estado de conexión
            {
                MessageBox.Show("Inicio de sesión exitoso");

                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecta"); // Mensaje de error
            }
        }
    }
 
}
