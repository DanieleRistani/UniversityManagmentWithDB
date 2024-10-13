using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;
using UniversityManagerWithDB.Entity;
using UniversityManagerWithDB.Enum;
using UniversityManagerWithDB.Helper;
using UniversityManagerWithDB.Interface;

namespace University.Repository; 

public class StudentRepository : StudentCRUD
{
    public  DbSet<Students> Students { get; set; } = GetDbHelper.db.Students;

    public bool Insert(string mat,string name,string surname,int age,string gender,DateTime dataTime,long facultyId)
    {
        
        try
        {
        Students s = new Students();  

        s.student_mat = mat;
        s.student_name = name;
        s.student_surname = surname;
        s.student_age = age;
        s.student_gender = gender;
        s.student_date_of_enrollment = dataTime;
        s.student_faculty_id = facultyId;

        GetDbHelper.db.Students.Add(s);
        GetDbHelper.db.SaveChanges();

         return true;

        }
        catch (Exception ex) { 

         Console.WriteLine(ex.Message); 
         return false;
        
        }
        
    }
    public bool Delete(string mat)
    {
        try
        {
            int rowsAffected = GetDbHelper.db.Database.ExecuteSqlCommand(
                "DELETE FROM Students WHERE Students.student_mat = @mat",
                new SqlParameter("@mat", mat.ToUpper())
            );

            return rowsAffected > 0; 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
    public bool UpdateName(string mat, string name)
    {
        long studentId = GetDbHelper.db.Database.SqlQuery<long>(
                "SELECT Students.student_id FROM Students WHERE Students.student_mat = @mat",
                new SqlParameter("@mat", mat.ToUpper())
        ).FirstOrDefault();

        if (studentId == 0)
        {
            return false;
        }
        else
        {
        GetDbHelper.db.Students.Find(studentId).student_name = name;
        GetDbHelper.db.SaveChanges();
        return true;
        }
        
    }
    public bool UpdateSurname(string mat, string surname)
    {
        long studentId = GetDbHelper.db.Database.SqlQuery<long>(
                 "SELECT Students.student_id FROM Students WHERE Students.student_mat = @mat",
                 new SqlParameter("@mat", mat.ToUpper())
         ).FirstOrDefault();

        if (studentId == 0)
        {
            return false;
        }
        else
        {
            GetDbHelper.db.Students.Find(studentId).student_surname = surname;
            GetDbHelper.db.SaveChanges();
            return true;
        }
    } 
    public bool UpdateFacultyId(string mat, long facultyId)
    {
        long studentId = GetDbHelper.db.Database.SqlQuery<long>(
                "SELECT Students.student_id FROM Students WHERE Students.student_mat = @mat",
                new SqlParameter("@mat", mat.ToUpper())
        ).FirstOrDefault();

        if (studentId == 0)
        {
            return false;
        }
        else
        {
            GetDbHelper.db.Students.Find(studentId).student_faculty_id = facultyId;
            GetDbHelper.db.SaveChanges();
            return true;
        }
    }
    public bool UpdateDateOfEnv(string mat, DateTime dataTime)
    {
        long studentId = GetDbHelper.db.Database.SqlQuery<long>(
                "SELECT Students.student_id FROM Students WHERE Students.student_mat = @mat",
                new SqlParameter("@mat", mat.ToUpper())
        ).FirstOrDefault();

        if (studentId == 0)
        {
            return false;
        }
        else
        {
            GetDbHelper.db.Students.Find(studentId).student_date_of_enrollment = dataTime;
            GetDbHelper.db.SaveChanges();
            return true;
        }
    }
    public bool UpdateGender(string mat, string gender)
    {
        long studentId = GetDbHelper.db.Database.SqlQuery<long>(
                "SELECT Students.student_id FROM Students WHERE Students.student_mat = @mat",
                new SqlParameter("@mat", mat.ToUpper())
        ).FirstOrDefault();

        if (studentId == 0)
        {
            return false;
        }
        else
        {
            GetDbHelper.db.Students.Find(studentId).student_gender = gender;
            GetDbHelper.db.SaveChanges();
            return true;
        }
    }
    public bool UpdateAge(string mat, int age)
    {
        long studentId = GetDbHelper.db.Database.SqlQuery<long>(
                 "SELECT Students.student_id FROM Students WHERE Students.student_mat = @mat",
                 new SqlParameter("@mat", mat.ToUpper())
         ).FirstOrDefault();

        if (studentId == 0)
        {
            return false;
        }
        else
        {
            GetDbHelper.db.Students.Find(studentId).student_age = age;
            GetDbHelper.db.SaveChanges();
            return true;
        }
    }

    
}
