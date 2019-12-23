using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EE;
using Data;

namespace MPP
{
    public class MPPUser
    {
        public bool LoginQuery(User user, string password)
        {
            Access access = new Access();
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@Username", user.Username));
            parameters.Add(new Parameter("@Password", password));
            string query = "Select password from Users WHERE usuario = @usuario AND password = @password";
            return access.ReadWithResponse(query, parameters);
        }
    }
}
