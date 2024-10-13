using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using UniversityManagerWithDB.Entity;
using UniversityManagerWithDB.Helper;
using UniversityManagerWithDB.Interface;


namespace University.Repository;

public class ExamRepository
{
  public DbSet<Exames> exames { get; set; } = GetDbHelper.db.Exames;

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Insert()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}
