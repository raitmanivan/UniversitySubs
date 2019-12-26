using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EE;
using MPP;

namespace BLL
{
    public class BLLStudent
    {
        public Student SearchStudentByUser(User user)
        {
            MPPStudent mapper = new MPPStudent();
            return mapper.SearchStudentByUser(user);
        }
    }
}
