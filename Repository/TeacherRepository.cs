using System;
using System.Configuration;
using System.Data.Entity;
using UniversityManagerWithDB.Entity;
using UniversityManagerWithDB.Helper;


namespace University.Repository;

public class TeacherRepository
{
  public DbSet<Teachers> teachers { get; set; } = GetDbHelper.db.Teachers;
   

}
