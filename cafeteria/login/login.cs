using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeteria.login
{
    public partial class login : Form
    {
        private login logi;
        int intento= 3;
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuarios = txtuser.Text;
            string contrasena = txtpasword.Text;

            if (usuarios == "angel" && contrasena == "123456789")
            {
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                this.Hide();
            }
            else 
            {


                lblError.Text= "Usuario o contraseña incorrecto";
                lblError.Visible = true;
                txtuser.Clear();
                txtpasword.Clear(); 

                if (intento==1)
                {
                    MessageBox.Show("Has alcanzado el número máximo de intentos. La aplicación se cerrará.");
                    Application.Exit();
                }
            }


        }
        private void txtuser_TextChanged(object sender, EventArgs e)
        {
          lblError.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       
    }
}
