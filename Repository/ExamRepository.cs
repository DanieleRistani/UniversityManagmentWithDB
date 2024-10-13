using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using UniversityManagerWithDB.Entity;
using UniversityManagerWithDB.Helper;


namespace University.Repository;

public class ExamRepository
{
    
  public DbSet<Exames> exames { get; set; } = GetDbHelper.db.Exames;

}
