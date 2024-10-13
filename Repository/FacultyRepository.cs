using System;
using System.Configuration;
using System.Data.Entity;
using UniversityManagerWithDB.Entity;
using UniversityManagerWithDB.Helper;
using UniversityManagerWithDB.Interface;


namespace University;

public class FacultyRepository
{
 public  DbSet<Faculties> faculties { get; set; } =GetDbHelper.db.Faculties;   

}
