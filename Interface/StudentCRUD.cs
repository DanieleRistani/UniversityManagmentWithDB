using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagerWithDB.Enum;

namespace UniversityManagerWithDB.Interface
{
    internal interface StudentCRUD
    {
        public bool Insert(string mat, string name, string surname, int age, string gender, DateTime dataTime, long facultyId);
        public bool Delete(string mat);
        public bool UpdateName(string mat, string name);
        public bool UpdateSurname(string mat, string surname);
        public bool UpdateFacultyId(string mat, long facultyId);
        public bool UpdateDateOfEnv(string mat, DateTime dataTime);
        public bool UpdateGender(string mat, string gender);
        public bool UpdateAge(string mat, int age);


    }
}
