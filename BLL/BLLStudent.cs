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

        public bool CreateStudent(Student student)
        {
            MPPStudent mapper = new MPPStudent();
            try
            {
                mapper.CreateStudent(student);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool LinkStudentWithUser(Student student, User user)
        {
            MPPStudent mapper = new MPPStudent();
            try
            {
                mapper.LinkStudentWithUser(student,user);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
