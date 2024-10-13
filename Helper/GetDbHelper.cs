using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagerWithDB.Entity;

namespace UniversityManagerWithDB.Helper
{
    public class GetDbHelper
    {
        public static UniversityDBEntities db = new UniversityDBEntities();
    }
}
