using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Repository;
using UniversityManagerWithDB.Entity;
using UniversityManagerWithDB.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace UniversityManagerWithDB.Forms
{
    public partial class DeleteStudentForm : Form
    {
        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {
            this.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentRepository studentRepository = new StudentRepository();

            string matForm = textBox1.Text.ToUpper();
            int rowsAffected = GetDbHelper.db.Students.SqlQuery("SELECT * FROM Students WHERE student_mat = @mat",
            new SqlParameter("@mat", matForm)).Count();
    
            Console.WriteLine(rowsAffected);
            if (rowsAffected >0 ) { studentRepository.Delete(matForm); MessageBox.Show("Studento cancellato"); } else { MessageBox.Show("Studente non presente"); }

        }

        
    }
}
