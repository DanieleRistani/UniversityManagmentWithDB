using System;
using System.Configuration;
using System.Data.Entity;
using UniversityManagerWithDB.Entity;
using UniversityManagerWithDB.Helper;



namespace University.Repository;

public class TeacherRepository
{
  public DbSet<Teachers> teachers { get; set; } = GetDbHelper.db.Teachers;

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
