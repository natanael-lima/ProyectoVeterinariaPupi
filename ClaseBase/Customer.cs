using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Customer
    {
        private string cus_Nombre;
        public string Cus_Nombre
        {
            get { return cus_Nombre; }
            set { cus_Nombre = value; }
        }

        private string cus_Apellido;

        public string Cus_Apellido
        {
            get { return cus_Apellido; }
            set { cus_Apellido = value; }
        }


        private int cus_Telefono;

        public int Cus_Telefono {
            get { return cus_Telefono; }
            set { cus_Telefono = value; }
        }

        private int cus_DNI;
        public int Cus_DNI {
            get { return cus_DNI; }
            set { cus_DNI = value; }
        }

        private string cus_Email;

        public string Cus_Email
        {
            get { return cus_Email; }
            set { cus_Email = value; }
        }

        public Customer()
        {
           
        }
    }
}
