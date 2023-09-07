using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ClaseBase;

namespace Vistas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Boolean bUserFoud = false;
            User User1 = new User("admin","admin");
            User User2 = new User("nata","nata"); 
            FormMain formMain = new FormMain(); 

            if (User1.User_Username==txtUsername.Text && User1.User_Password == txtPassword.Text)
            {
                bUserFoud=true;
            }
            else if(User2.User_Username == txtUsername.Text && User2.User_Password == txtPassword.Text) {
                bUserFoud = true;
            }

            if (bUserFoud)
            {
                MessageBox.Show("Bienvenido/a: "+txtUsername.Text, "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos de Acceso Incorrectos","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
