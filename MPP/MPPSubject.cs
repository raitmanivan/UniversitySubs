﻿using System;
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
        public List<Subject> ListSubjects()
        {
            Access access = new Access();
            string consulta = "Select * FROM Subject";
            DataTable dt = default(DataTable);
            dt = access.Read(consulta,null);

            List<Subject> subjectList = new List<Subject>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Subject subject = new Subject();
                    subject.SubjectID = Convert.ToInt32(fila["SubjectID"]);
                    subject.Name = fila["Name"].ToString();
                    subject.Year = Convert.ToInt32(fila["Year"]);
                    subject.Status = fila["Status"].ToString();
                    subject.PeriodType = fila["PeriodType"].ToString();
                    subject.CorrespondingPeriod = Convert.ToInt32(fila["CorrespondingPeriod"]);
                    subjectList.Add(subject);
                }
            }
            return subjectList;
        }

        public List<StudentSubject> ListStudentSubjects(Student student)
        {
            Access access = new Access();
            string consulta = "SELECT subject.SubjectID, subject.Name,subject.Year, studentsubject.Status, studentsubject.Qualification FROM Subject as subject, StudentSubject as studentsubject WHERE subject.SubjectID = studentsubject.SubjectID AND studentsubject.StudentID = @StudentID";
            DataTable dt = default(DataTable);
            int ? qualification = null;
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@StudentID", student.StudentID));
            dt = access.Read(consulta, parameters);

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

                    StudentSubject information = new StudentSubject(student, subject, fila["Status"].ToString(), qualification);
                    subjectList.Add(information);
                    qualification = -1;
                }
            }
            return subjectList;
        }

        public void CreateSubject(Subject subject)
        {
            Access access = new Access();
            string query = "INSERT INTO Subject (SubjectID,Name,Year,Status,PeriodType,CorrespondingPeriod) VALUES (@SubjectID,@Name,@Year,@Status,@PeriodType,@CorrespondingPeriod)";
            List<Parameter> parameters = new List<Parameter>();

            try
            {
                parameters.Add(new Parameter("@SubjectID", subject.SubjectID));
                parameters.Add(new Parameter("@Name", subject.Name));
                parameters.Add(new Parameter("@Year", subject.Year));
                parameters.Add(new Parameter("@Status", subject.Status));
                parameters.Add(new Parameter("@PeriodType", subject.PeriodType));
                parameters.Add(new Parameter("@CorrespondingPeriod", subject.CorrespondingPeriod));

                access.Write(query, parameters);
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
            string query = "INSERT INTO StudentSubject (StudentID,SubjectID,Status,Qualification) VALUES (@StudentID,@SubjectID,@Status,@Qualification)";
            List<Parameter> parameters = new List<Parameter>();
            try
            {
                parameters.Add(new Parameter("@StudentID", information.Student.StudentID));
                parameters.Add(new Parameter("@SubjectID", information.Subject.SubjectID));
                parameters.Add(new Parameter("@Status", information.Status));
                parameters.Add(new Parameter("@Qualification", information.Qualification));
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
