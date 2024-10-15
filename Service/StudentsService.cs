using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagerWithDB.Forms;

namespace UniversityManagerWithDB.Service
{
    internal class StudentsService
    {
        public AddStudentForm addStudentForm { get; set; } =new AddStudentForm();
        public DeleteStudentForm deleteStudentForm { get; set; } = new DeleteStudentForm();

        public UpdateStudentForm updateStudentForm { get; set; }=new UpdateStudentForm();
    }
}