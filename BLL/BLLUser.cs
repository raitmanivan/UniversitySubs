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

    }
}
