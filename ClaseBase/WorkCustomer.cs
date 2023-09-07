using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ClaseBase
{
    public class WorkCustomer
    {
        public static void exec_add_customer(Customer customer)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.basedatosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "create_customer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ape", customer.Cus_Apellido);
            cmd.Parameters.AddWithValue("@dni", customer.Cus_DNI); 
            cmd.Parameters.AddWithValue("@email", customer.Cus_Email);
            cmd.Parameters.AddWithValue("@nom", customer.Cus_Nombre);
            cmd.Parameters.AddWithValue("@tel", customer.Cus_Telefono); 


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static DataTable exec_listar_customer()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.basedatosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_customer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


    }
}
