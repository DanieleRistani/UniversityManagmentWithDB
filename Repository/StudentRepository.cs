using System;
using System.Data.Entity;
using UniversityManagerWithDB.Entity;
using UniversityManagerWithDB.Helper;

namespace University.Repository; 

public class StudentRepository
{
   public  DbSet<Students> Students { get; set; } = GetDbHelper.db.Students;



}
