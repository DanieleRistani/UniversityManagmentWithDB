using System;
using System.Configuration;
using System.Data.Entity;
using UniversityManagerWithDB.Entity;
using UniversityManagerWithDB.Helper;


namespace University;

public class FacultyRepository
{
 public  DbSet<Faculties> faculties { get; set; } =GetDbHelper.db.Faculties;   

}
