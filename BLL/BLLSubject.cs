﻿using System;
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

        public List<Subject> ListActiveSubjects()
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListActiveSubjects();
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

        public Subject ListApprovedSubjectBySubjectID(Student student, int SubjectID)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListApprovedSubjectBySubjectID(student,SubjectID);
        }

        public List<Subject> ListCorrelativeSubjects(Subject subject)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListCorrelativeSubjects(subject);
        }

        public List<Subject> ListUnlockSubjectsBySubject(Subject subject)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListUnlockSubjectsBySubject(subject);
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

        public bool NewStudentInscription(Inscription inscription)
        {
            MPPSubject mapper = new MPPSubject();
            try
            {
                mapper.NewStudentInscription(inscription);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Inscription> ListStudentInscriptionHistory(Student student,Status status)
        {
            MPPSubject mapper = new MPPSubject();
            return mapper.ListStudentInscriptionHistory(student,status);
        }

        public bool CancelStudentInscription(Inscription inscription)
        {
            MPPSubject mapper = new MPPSubject();
            try
            {
                mapper.CancelStudentInscription(inscription);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool ChangeSubjectStatus(Subject subject, Status status)
        {
            MPPSubject mapper = new MPPSubject();
            try
            {
                mapper.ChangeSubjectStatus(subject, status);
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
