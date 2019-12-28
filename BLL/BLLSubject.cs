using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MPP;
using EE;

namespace BLL
{
    public class BLLSubject
    {
        public List<Subject> ListSubjects()
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListSubjects();
        }

        public List<StudentSubject> ListStudentSubjects(Student student)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListStudentSubjects(student);
        }

        public List<StudentSubject> ListApprovedStudentSubjects(Student student)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListApprovedStudentSubjects(student);
        }

        public List<StudentSubject> ListPendingStudentSubjects(Student student)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListPendingStudentSubjects(student);
        }

        public List<StudentSubject> ListPendingAndPendingExamStudentSubjects(Student student)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListPendingAndPendingExamStudentSubjects(student);
        }

        public List<StudentSubject> ListPendingExamStudentSubjects(Student student)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListPendingExamStudentSubjects(student);
        }

        public List<StudentSubject> ListPendingStudentSubjectsByYear(Student student, string year)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListPendingStudentSubjectsByYear(student, year);
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
    }
}
