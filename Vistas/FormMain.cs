using ClaseBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FormMain : Form
    {
        //Fields
        Form customer;
        
        
        public FormMain()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
            
        }
         private void OpenForm(Form childForm)
        {
            customer = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag=childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClientess_Click(object sender, EventArgs e)
        {
            OpenForm(new FormCustomerMascota());
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            OpenForm(new FormTurn());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenForm(new FormInventory());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            OpenForm(new FormUser());
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            OpenForm(new FormReport());
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Después de guardar o realizar alguna acción en el formulario de cliente.

            // Cierra el formulario de cliente.
            this.Close();

            // Luego, crea una instancia del formulario principal.
            FormMain formMain = new FormMain();

            // Muestra el formulario principal.
            formMain.Show();
        }

        private void CambiarColorBotonHover(Button boton)
        {
            // Cambiar el color del texto cuando el cursor entra en el botón
            boton.ForeColor = Color.White; // Puedes cambiar el color a tu preferencia
        }

        private void RestaurarColorBotonLeave(Button boton)
        {
            // Cambiar el color del texto cuando el cursor sale del botón
            boton.ForeColor = Color.FromArgb(0x241A22); // Puedes restaurar el color original
        }

        private void btnClientes_MouseEnter(object sender, EventArgs e)
        {
            CambiarColorBotonHover(btnClientess);
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            RestaurarColorBotonLeave(btnClientess);
        }

        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            CambiarColorBotonHover(btnCerrarSesion);
        }

        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            RestaurarColorBotonLeave(btnCerrarSesion);
        }
        private void btnTurno_MouseEnter(object sender, EventArgs e)
        {
            CambiarColorBotonHover(btnTurno);
        }

        private void btnTurno_MouseLeave(object sender, EventArgs e)
        {
            RestaurarColorBotonLeave(btnTurno);
        }
        private void btnInventario_MouseEnter(object sender, EventArgs e)
        {
            CambiarColorBotonHover(btnInventario);
        }

        private void btnInventario_MouseLeave(object sender, EventArgs e)
        {
            RestaurarColorBotonLeave(btnInventario);
        }
        private void btnReporte_MouseEnter(object sender, EventArgs e)
        {
            CambiarColorBotonHover(btnReporte);
        }

        private void btnReporte_MouseLeave(object sender, EventArgs e)
        {
            RestaurarColorBotonLeave(btnReporte);
        }
        private void btnPago_MouseEnter(object sender, EventArgs e)
        {
            CambiarColorBotonHover(btnPagos);
        }

        private void btnPago_MouseLeave(object sender, EventArgs e)
        {
            RestaurarColorBotonLeave(btnPagos);
        }
        private void btnUsuario_MouseEnter(object sender, EventArgs e)
        {
            CambiarColorBotonHover(btnUsuario);
        }

        private void btnUsuario_MouseLeave(object sender, EventArgs e)
        {
            RestaurarColorBotonLeave(btnUsuario);
        }




        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
