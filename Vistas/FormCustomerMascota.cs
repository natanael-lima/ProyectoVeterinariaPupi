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
    public partial class FormCustomerMascota : Form
    {
        public FormCustomerMascota()
        {
            InitializeComponent();

        }

        private void load_customer()
        {
            dgvCustomer.DataSource = WorkCustomer.exec_listar_customer();
            dgvCustomer.Columns["cus_id"].Visible = false;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            load_customer();
            //this.BackgroundImage = Properties.Resources._2; // Reemplaza con la imagen que desees
            //this.BackgroundImageLayout = ImageLayout.Zoom; // Otra configuración si es necesaria
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            load_customer();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Oculta FormCustomer
            //this.Hide();

            // Crea y muestra FormCustomerChild como un formulario de diálogo
            FormMascotaEdit formChild = new FormMascotaEdit();
            formChild.ShowDialog();

            // Después de cerrar FormCustomerChild, muestra FormCustomer nuevamente
            load_customer();
            this.Show();
        }

        private void btnAgregarPet_Click(object sender, EventArgs e)
        {
            // Crea y muestra FormCustomerChild como un formulario de diálogo
            FormMascotaNew formChild = new FormMascotaNew();
            formChild.ShowDialog();

            // Después de cerrar FormCustomerChild, muestra FormCustomer nuevamente
            load_customer();
            this.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Oculta FormCustomer
            //this.Hide();

            // Crea y muestra FormCustomerChild como un formulario de diálogo
            FormCustomerNew formChild = new FormCustomerNew();
            formChild.ShowDialog();

            // Después de cerrar FormCustomerChild, muestra FormCustomer nuevamente
            load_customer();
            this.Show();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            // Crea y muestra FormCustomerChild como un formulario de diálogo
            FormCustomerEdit formChild = new FormCustomerEdit();
            formChild.ShowDialog();

            // Después de cerrar FormCustomerChild, muestra FormCustomer nuevamente
            load_customer();
            this.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            // Crea y muestra FormCustomerChild como un formulario de diálogo
            FormMascotaNew formChild = new FormMascotaNew();
            formChild.ShowDialog();

            // Después de cerrar FormCustomerChild, muestra FormCustomer nuevamente
            load_customer();
            this.Show();
        }

        private void btnEditarMascota_Click(object sender, EventArgs e)
        {
            // Crea y muestra FormCustomerChild como un formulario de diálogo
            FormMascotaEdit formChild = new FormMascotaEdit();
            formChild.ShowDialog();

            // Después de cerrar FormCustomerChild, muestra FormCustomer nuevamente
            load_customer();
            this.Show();
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {

        }

    }
}
