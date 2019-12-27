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
            MPPStatus mapperStatus = new MPPStatus();
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
                    student.Status = mapperStatus.ReturnStatus(fila["Status"].ToString());
                }
            }
            return student;
        }

        public void CreateStudent(Student student)
        {
            Access access = new Access();
            List<Parameter> parameters = new List<Parameter>();

            string query = "INSERT INTO [Student] (StudentID,UniversityID,NameAndSurname,Email,Status) VALUES (@StudentID,@UniversityID,@NameAndSurname,@Email,@Status)";

            try
            {
                parameters.Add(new Parameter("@StudentID", student.StudentID));
                parameters.Add(new Parameter("@UniversityID", student.UniversityID));
                parameters.Add(new Parameter("@NameAndSurname", student.NameAndSurname));
                parameters.Add(new Parameter("@Email", student.Email));
                parameters.Add(new Parameter("@Status", student.Status.status));

                access.Write(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public void LinkStudentWithUser(Student student, User user)
        {
            Access access = new Access();
            List<Parameter> parameters = new List<Parameter>();
            string query = "INSERT INTO StudentUser (U_StudentID,U_Username) VALUES (@U_StudentID,@U_Username)";
            try
            {
                parameters.Add(new Parameter("@U_StudentID", student.StudentID));
                parameters.Add(new Parameter("@U_Username", user.Username));
                access.Write(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
