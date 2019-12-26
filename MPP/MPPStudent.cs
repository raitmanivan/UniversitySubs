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
    public class MPPStudent
    {
        public Student SearchStudentByUser(User user)
        {
            Access access = new Access();
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@username", user.Username));
            string query = "SELECT StudentID, UniversityID, NameAndSurname, Email, Status FROM Student as student, [User] as userb, StudentUser as studentuser WHERE studentuser.U_Username = @username AND student.StudentID = studentuser.U_StudentID AND studentuser.U_Username = userb.Username";
            DataTable dt = default(DataTable);
            dt = access.Read(query, parameters);

            Student student = new Student();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    student.StudentID = fila["StudentID"].ToString();
                    student.UniversityID = fila["UniversityID"].ToString();
                    student.NameAndSurname = fila["NameAndSurname"].ToString();
                    student.Email = fila["Email"].ToString();
                    student.Status = fila["Status"].ToString();
                }
            }
            return student;
        }
    }
}
