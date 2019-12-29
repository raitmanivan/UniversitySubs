using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MPP;
using EE;
using EE.States;

namespace BLL
{
    public class BLLSubject
    {
        public List<Subject> ListSubjects()
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListSubjects();
        }

        public Subject ListSubjectBySubjectID(int subjectID)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListSubjectBySubjectID(subjectID);
        }

        public Subject ListSubjectByName(string name)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListSubjectByName(name);
        }

        public List<StudentSubject> ListStudentSubjects(Student student,string select)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListStudentSubjects(student,select);
        }

        public List<StudentSubject> ListPendingStudentSubjectsByYear(Student student, string year)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListPendingStudentSubjectsByYear(student, year);
        }

        public float GetStudentSubjectAverage(Student student)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.GetStudentSubjectAverage(student);
        }

        public bool CreateSubject(Subject subject)
        {
            MPPSubject mapper = new MPPSubject();
            try
            {
                mapper.CreateSubject(subject);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool LinkSubjectWithStudent(StudentSubject information)
        {
            MPPSubject mapper = new MPPSubject();
            try
            {
                mapper.LinkSubjectWithStudent(information);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool ChangeStudentSubjectStatus(Student student, Subject subject, Status status, int? qualification)
        {
            MPPSubject mapper = new MPPSubject();
            try
            {
                mapper.ChangeStudentSubjectStatus(student,subject,status,qualification);
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
