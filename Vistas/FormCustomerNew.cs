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
using ClaseBase;

namespace Vistas
{
    public partial class FormCustomerNew : Form
    {
        public FormCustomerNew()
        {
            InitializeComponent();
        }

        
        private void btnGuardarNew_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();

            cus.Cus_Apellido = txtApellido.Text;
            cus.Cus_Nombre = txtNombre.Text;
            cus.Cus_Telefono = Convert.ToInt32(txtTelefono.Text);
            cus.Cus_Email = txtEmail.Text;
            WorkCustomer.exec_add_customer(cus);

            MessageBox.Show("Datos guardados correctamente", "OK", MessageBoxButtons.OK);

            // Después de guardar o realizar alguna acción en el formulario de cliente.

            // Cierra el formulario de cliente.
            this.Close();
        }

        private void btnCancelarNew_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
