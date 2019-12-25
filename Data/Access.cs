using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ADD:
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
//---------<

namespace Data
{
    public class Access
    {
        private SqlConnection con;
        private SqlTransaction Transaccion;
        public void OpenConnection()
        {
            con = new SqlConnection();
            //con.ConnectionString = @"Data Source=IVAN-PC;Initial Catalog=UAI_Materias;Integrated Security=True";
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
            con.Dispose();
            con = null;
            GC.Collect();
        }

        public bool ReadWithResponse(string query, List<Parameter> parameters)
        {
            bool status = false;

            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;

                if (parameters.Count != 0)
                {
                    foreach (Parameter item in parameters)
                    {
                        cmd.Parameters.AddWithValue(item.Name, item.Value);
                    }
                }
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                CloseConnection();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error: " + ex.Message);
            }
            return status;
        }

        public DataTable Read(string query, List<Parameter> parameters)
        {
            DataTable table = new DataTable();
            try
            {
                OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                if (parameters.Count != 0)
                {
                    foreach (Parameter item in parameters)
                    {
                        da.SelectCommand.Parameters.AddWithValue(item.Name, item.Value);
                    }
                }

                da.Fill(table);
                CloseConnection();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("General error: " + ex.Message);
            }

            return table;
        }

        public void Write(string query, List<Parameter> parameters)
        {
            try
            {
                OpenConnection();
                Transaccion = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand(query, con, Transaccion);
                cmd.CommandType = CommandType.Text;

                if (parameters.Count != 0)
                {
                    foreach (Parameter item in parameters)
                    {
                        cmd.Parameters.AddWithValue(item.Name, item.Value);
                    }
                }
                int repuesta = cmd.ExecuteNonQuery();
                Transaccion.Commit();
            }
            catch (Exception ex)
            {
                Transaccion.Rollback();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        /*
        public void ExcecuteScript(string[] ScriptSplitter)
        {
            AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            foreach (string str in ScriptSplitter)
            {
                using (cmd = con.CreateCommand())
                {
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                }
            }
            CerrarConexion();
        }


        public bool ProbarConexion()
        {
            try
            {
                AbrirConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (con.State == ConnectionState.Open)
            {

                CerrarConexion();
                return true;
            }

            else
            {
                CerrarConexion();
                return false;
            }
        }



        public int Escribir_W_Con_Parametros(string consulta, List<Parameter> parametros)
        {
            AbrirConexion();
            Transaccion = con.BeginTransaction();
            SqlCommand cmd = new SqlCommand(consulta, con, Transaccion);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            cmd.CommandText = consulta;
            int response = 0;

            try
            {
                if (parametros.Count != 0)
                {
                    foreach (Parameter item in parametros)
                    {
                        cmd.Parameters.AddWithValue(item.Nombre, item.Valor);
                    }
                }
                response = Convert.ToInt32(cmd.ExecuteScalar());
                Transaccion.Commit();
            }
            catch (SqlException sqle)
            {
                Transaccion.Rollback();
                throw sqle;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                Transaccion.Rollback();
                throw ex;
            }

            finally
            {
                CerrarConexion();
            }

            return response;
        }


    */
    }
}
