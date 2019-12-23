using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregado:
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
        public void AbrirConexion()
        {
            con = new SqlConnection();
            //con.ConnectionString = @"Data Source=IVAN-PC;Initial Catalog=Usuarios;Integrated Security=True";
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            con.Open();
        }

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

        public void CerrarConexion()
        {
            con.Close();
            con.Dispose();
            con = null;
            GC.Collect();
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

        public DataTable Leer_Con_Parametros(string consulta, List<Parameter> parametros)
        {
            DataTable tabla = new DataTable();
            try
            {
                AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                if (parametros.Count != 0)
                {
                    foreach (Parameter item in parametros)
                    {
                        da.SelectCommand.Parameters.AddWithValue(item.Nombre, item.Valor);
                    }
                }

                da.Fill(tabla);
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error en la base de datos: " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return tabla;
        }

        public bool Consultar_Con_Parametros(string consulta, List<Parameter> parametros)
        {
            bool status = false;

            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.CommandType = CommandType.Text;

                if (parametros.Count != 0)
                {
                    foreach (Parameter item in parametros)
                    {
                        cmd.Parameters.AddWithValue(item.Nombre, item.Valor);
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

                CerrarConexion();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }
            return status;
        }

        public void Escribir_Con_Parametros(string consulta, List<Parameter> parametros)
        {
            try
            {
                AbrirConexion();
                Transaccion = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand(consulta, con, Transaccion);
                cmd.CommandType = CommandType.Text;

                if (parametros.Count != 0)
                {
                    foreach (Parameter item in parametros)
                    {
                        cmd.Parameters.AddWithValue(item.Nombre, item.Valor);
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
                CerrarConexion();
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
    }
}
