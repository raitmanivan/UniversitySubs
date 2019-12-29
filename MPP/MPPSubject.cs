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
    public class MPPSubject
    {
        #region Querys...
        string QuerySelectAll = "Select * FROM Subject";
        string QuerySelectStudentSubjects = "SELECT subject.SubjectID, subject.Name,subject.Year, studentsubject.Status, studentsubject.Qualification FROM Subject as subject, StudentSubject as studentsubject WHERE subject.SubjectID = studentsubject.SubjectID AND studentsubject.StudentID = @StudentID";
        string QuerySelectApprovedStudentSubjects = "SELECT subject.SubjectID, subject.Name,subject.Year, studentsubject.Status, studentsubject.Qualification FROM Subject as subject, StudentSubject as studentsubject WHERE subject.SubjectID = studentsubject.SubjectID AND studentsubject.StudentID = @StudentID AND studentsubject.Status  = 'Aprobada'";
        string QuerySelectPendingStudentSubjects = "SELECT subject.SubjectID, subject.Name,subject.Year, studentsubject.Status, studentsubject.Qualification FROM Subject as subject, StudentSubject as studentsubject WHERE subject.SubjectID = studentsubject.SubjectID AND studentsubject.StudentID = @StudentID AND studentsubject.Status  = 'En curso'";
        string QuerySelectPendingExamStudentSubjects = "SELECT subject.SubjectID, subject.Name,subject.Year, studentsubject.Status, studentsubject.Qualification FROM Subject as subject, StudentSubject as studentsubject WHERE subject.SubjectID = studentsubject.SubjectID AND studentsubject.StudentID = @StudentID AND studentsubject.Status  = 'En final'";
        string QuerySelectPendingStudentSubjectsByYear = "SELECT subject.SubjectID, subject.Name,subject.Year, studentsubject.Status, studentsubject.Qualification  FROM Subject as subject, StudentSubject as studentsubject WHERE subject.SubjectID = studentsubject.SubjectID AND studentsubject.StudentID = @StudentID AND (studentsubject.Status  = 'No cursada' OR studentsubject.Status = 'En final') AND subject.Year = ";
        string QuerySelectPendingAndPendingExamStudentSubjects = "SELECT subject.SubjectID, subject.Name,subject.Year, studentsubject.Status, studentsubject.Qualification  FROM Subject as subject, StudentSubject as studentsubject WHERE subject.SubjectID = studentsubject.SubjectID AND studentsubject.StudentID = @StudentID AND (studentsubject.Status  = 'No cursada' OR studentsubject.Status = 'En final')";
        string QueryInsertSubject = "INSERT INTO Subject (SubjectID,Name,Year,Status,PeriodType,CorrespondingPeriod) VALUES (@SubjectID,@Name,@Year,@Status,@PeriodType,@CorrespondingPeriod)";
        string QueryInsertStudentSubject = "INSERT INTO StudentSubject (StudentID,SubjectID,Status,Qualification) VALUES (@StudentID,@SubjectID,@Status,@Qualification)";
        #endregion

        public List<Subject> ListSubjects()
        {
            Access access = new Access();
            MPPStatus mapperStatus = new MPPStatus();
            DataTable dt = default(DataTable);
            dt = access.Read(QuerySelectAll, new List<Parameter>());

            List<Subject> subjectList = new List<Subject>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Subject subject = new Subject();
                    subject.SubjectID = Convert.ToInt32(fila["SubjectID"]);
                    subject.Name = fila["Name"].ToString();
                    subject.Year = Convert.ToInt32(fila["Year"]);
                    subject.Status = mapperStatus.ReturnStatus(fila["Status"].ToString());
                    subject.PeriodType = fila["PeriodType"].ToString();
                    subject.CorrespondingPeriod = Convert.ToInt32(fila["CorrespondingPeriod"]);
                    subjectList.Add(subject);
                }
            }
            return subjectList;
        }

        private string SelectQuery(string query)
        {
            if (query == "All student subjects")
                return QuerySelectStudentSubjects;
            else if (query == "Only approved student subjects")
                return QuerySelectApprovedStudentSubjects;
            else if (query == "Only pending exam student subjects")
                return QuerySelectPendingStudentSubjects;
            else if (query == "Only pending and pending exam student subjects")
                return QuerySelectPendingAndPendingExamStudentSubjects;
            else if (query == "Only pending student subjects")
                return QuerySelectPendingExamStudentSubjects;
            else return string.Empty;
        }

        public List<StudentSubject> ListStudentSubjects(Student student, string query)
        {
            Access access = new Access();        
            MPPStatus mapperStatus = new MPPStatus();
            DataTable dt = default(DataTable);
            int ? qualification = null;
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@StudentID", student.StudentID));
            dt = access.Read(SelectQuery(query), parameters);

            List<StudentSubject> subjectList = new List<StudentSubject>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Subject subject = new Subject();
                    subject.SubjectID = Convert.ToInt32(fila["SubjectID"]);
                    subject.Name = fila["Name"].ToString();
                    subject.Year = Convert.ToInt32(fila["Year"]);

                    if (fila["Qualification"] == DBNull.Value)
                        qualification = null;
                    else
                        qualification = Convert.ToInt32(fila["Qualification"]);
          
                    StudentSubject information = new StudentSubject(subject, mapperStatus.ReturnStatus(fila["Status"].ToString()), qualification);
                    subjectList.Add(information);
                    qualification = -1;
                }
            }
            return subjectList;
        }

        public List<StudentSubject> ListPendingStudentSubjectsByYear(Student student, string year)
        {
            Access access = new Access();
            MPPStatus mapperStatus = new MPPStatus();
            DataTable dt = default(DataTable);
            int? qualification = null;
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@StudentID", student.StudentID));
            dt = access.Read(QuerySelectPendingStudentSubjectsByYear + "'" + year + "'", parameters);

            List<StudentSubject> subjectList = new List<StudentSubject>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Subject subject = new Subject();
                    subject.SubjectID = Convert.ToInt32(fila["SubjectID"]);
                    subject.Name = fila["Name"].ToString();
                    subject.Year = Convert.ToInt32(fila["Year"]);

                    if (fila["Qualification"] == DBNull.Value)
                        qualification = null;
                    else
                        qualification = Convert.ToInt32(fila["Qualification"]);

                    StudentSubject information = new StudentSubject(subject, mapperStatus.ReturnStatus(fila["Status"].ToString()), qualification);
                    subjectList.Add(information);
                    qualification = -1;
                }
            }
            return subjectList;
        }

        public void CreateSubject(Subject subject)
        {
            Access access = new Access();
            List<Parameter> parameters = new List<Parameter>();

            try
            {
                parameters.Add(new Parameter("@SubjectID", subject.SubjectID));
                parameters.Add(new Parameter("@Name", subject.Name));
                parameters.Add(new Parameter("@Year", subject.Year));
                parameters.Add(new Parameter("@Status", subject.Status));
                parameters.Add(new Parameter("@PeriodType", subject.PeriodType));
                parameters.Add(new Parameter("@CorrespondingPeriod", subject.CorrespondingPeriod));

                access.Write(QueryInsertSubject, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public void LinkSubjectWithStudent(StudentSubject information)
        {
            Access access = new Access();
            List<Parameter> parameters = new List<Parameter>();
            try
            {
                parameters.Add(new Parameter("@StudentID", information.Student.StudentID));
                parameters.Add(new Parameter("@SubjectID", information.Subject.SubjectID));
                parameters.Add(new Parameter("@Status", information.Status));
                parameters.Add(new Parameter("@Qualification", information.Qualification));
                access.Write(QueryInsertStudentSubject, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

    }
}
