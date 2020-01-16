using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLUser
    {

        public bool LoginQuery(User user, string password)
        {
            MPPUser mapper = new MPPUser();
            return mapper.LoginQuery(user, password);
        }

        public bool CreateUser(User user)
        {
            MPPUser mapper = new MPPUser();
            try
            {
                mapper.CreateUser(user);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public User SearchUserByUsername(User user)
        {
            MPPUser mapper = new MPPUser();
            return mapper.SearchUserByUsername(user);
        }

        public string SearchUserRole(User user)
        {
            MPPUser mapper = new MPPUser();
            return mapper.SearchUserRole(user);
        }

    }
}
