﻿using ClaseBase;
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
    public partial class FormCustomerEdit : Form
    {
        public FormCustomerEdit()
        {
            InitializeComponent();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelarEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
