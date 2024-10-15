using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Repository;
using UniversityManagerWithDB.Validation;

namespace UniversityManagerWithDB.Forms
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ResetText();
            this.facultiesTableAdapter.Fill(this.universityDBDataSet.Faculties);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentRepository studentRepository = new StudentRepository();
            StudentsValidation studentsValidation = new StudentsValidation();
            string errorMessage = string.Empty;
            string female = radioButton1.Text;
            string male = radioButton2.Text;
            int intAge = 0;
            DateTime dateTime = DateTime.Now;


            string matForm= textBox1.Text;
            string nameForm= textBox2.Text;
            string surnameForm = textBox3.Text;
            string ageForm = textBox4.Text;
            string dateForm = textBox5.Text;
            string gender = string.Empty; 

            long facultyId = comboBox1.SelectedIndex + 1;

            if (studentsValidation.ValidationMat(matForm)==matForm){}else{errorMessage += studentsValidation.ValidationMat(matForm)+"\n";}
            if (studentsValidation.ValidationName(nameForm) == nameForm) { } else { errorMessage += studentsValidation.ValidationName(nameForm) + "\n"; }
            if (studentsValidation.ValidationSurname(surnameForm) == surnameForm) { } else { errorMessage += studentsValidation.ValidationSurname(surnameForm) + "\n"; }
            if (studentsValidation.ValidationAge(ageForm) == ageForm) { intAge = int.Parse(ageForm); } else { errorMessage += studentsValidation.ValidationAge(ageForm) + "\n"; }
            if (studentsValidation.ValidationDate(dateForm) == dateForm) { dateTime = DateTime.Parse(dateForm); } else { errorMessage += studentsValidation.ValidationDate(dateForm) + "\n"; }
            if (radioButton1.Checked || radioButton2.Checked) { gender = radioButton1.Checked ? female : male; } else { errorMessage += "Sesso non selezionato\n"; }


            if (errorMessage==string.Empty)
            {
                //Console.WriteLine($"{matForm}, {nameForm}, {surnameForm}, {intAge}, {gender}, {dateTime}, {facultyId}");
                studentRepository.Insert(matForm.ToUpper(), nameForm, surnameForm, intAge,gender,dateTime,facultyId);
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
                this.Refresh();
            }



        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.facultiesTableAdapter.Fill(this.universityDBDataSet.Faculties);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
