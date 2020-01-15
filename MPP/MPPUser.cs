using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EE;
using Data;
using System.Data;

namespace MPP
{
    public class MPPUser
    {
        public bool LoginQuery(User user, string password)
        {
            Access access = new Access();
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@username", user.Username));
            parameters.Add(new Parameter("@password", password));
            string query = "Select Password from [User] WHERE Username = @username AND Password = @password";
            return access.ReadWithResponse(query, parameters);
        }

        public void CreateUser(User user)
        {
            Access access = new Access();
            List<Parameter> parameters = new List<Parameter>();

            string query = "INSERT INTO [User] (Username,Password) VALUES (@username,@password)";

            try
            {
                parameters.Add(new Parameter("@username", user.Username));
                parameters.Add(new Parameter("@password", user.Password));
                access.Write(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public User SearchUserByUsername(User user)
        {
            Access access = new Access();
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@username", user.Username));
            string query = "SELECT TOP 1 * FROM [User] WHERE Username = @username";
            DataTable dt = default(DataTable);
            dt = access.Read(query, parameters);

            User responseUser = new User();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    responseUser.Username = fila["Username"].ToString();
                }
            }
            try
            {
                responseUser.Role = this.SearchUserRole(responseUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return responseUser;
        }

        public string SearchUserRole(User user)
        {
            Access access = new Access();
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@Username", user.Username));
            string query = "SELECT r.Description FROM [Role] as r, [User] as u, [UserRole] as ur WHERE u.Username = @Username AND u.Username = ur.Username AND r.RoleID = ur.RoleID";
            DataTable dt = default(DataTable);
            dt = access.Read(query, parameters);

            string role = "";

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    role = fila["Description"].ToString();
                }
            }
            return role;
        }
    }
}
