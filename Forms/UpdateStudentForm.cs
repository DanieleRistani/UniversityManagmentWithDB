﻿using System;
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
using UniversityManagerWithDB.Validation;

namespace UniversityManagerWithDB.Forms
{
    public partial class UpdateStudentForm : Form
    {
        public Students student= null;
        public StudentsValidation studentsValidation =new() ;
        public UpdateStudentForm()
        {
            InitializeComponent();
            List<string> options = ["Nome", "Cognome", "Età", "Data iscrizione"];
            options.ForEach(o => this.comboBox1.Items.Add(o));
            this.comboBox1.SelectedItem = "Nome";

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string newValue=textBox2.Text;
            StudentsValidation studentsValidation = new();  
            string attribute = comboBox1.Text;



            if (student != null)
            {
                if(GetDbHelper.db.Students.Find(student.student_id).student_faculty_id==comboBox2.SelectedIndex){}else{GetDbHelper.db.Students.Find(student.student_id).student_faculty_id = comboBox2.SelectedIndex;MessageBox.Show("Facoltà modificata"); }
            
                if (Maschio.Checked){GetDbHelper.db.Students.Find(student.student_id).student_gender = Maschio.Text;}
                else if(Femmina.Checked){GetDbHelper.db.Students.Find(student.student_id).student_gender = Femmina.Text;}


                if (attribute == "Nome" && studentsValidation.ValidationName(newValue)==newValue)
                {
                       GetDbHelper.db.Students.Find(student.student_id).student_name=newValue;
                       GetDbHelper.db.SaveChanges();
                       MessageBox.Show("Nome modificato");
                    
                }else if(attribute == "Nome" && studentsValidation.ValidationName(newValue) != newValue){ MessageBox.Show(studentsValidation.ValidationName(newValue));}


                if (attribute == "Cognome" && studentsValidation.ValidationSurname(newValue) == newValue)
                {
                       GetDbHelper.db.Students.Find(student.student_id).student_surname = newValue;
                       GetDbHelper.db.SaveChanges();
                       MessageBox.Show("Cognome modificato");


                }
                else if (attribute == "Cognome" && studentsValidation.ValidationSurname(newValue) != newValue) { MessageBox.Show(studentsValidation.ValidationSurname(newValue)); }

                if (attribute == "Età" && studentsValidation.ValidationAge(newValue) == newValue)
                {
                    GetDbHelper.db.Students.Find(student.student_id).student_age = int.Parse(newValue);
                    GetDbHelper.db.SaveChanges();
                    MessageBox.Show("Età modificata");


                }
                else if (attribute == "Età" && studentsValidation.ValidationAge(newValue) != newValue) { MessageBox.Show(studentsValidation.ValidationAge(newValue)); }

                if (attribute == "Data iscrizione" && studentsValidation.ValidationDate(newValue) == newValue)
                {
                    GetDbHelper.db.Students.Find(student.student_id).student_date_of_enrollment = DateTime.Parse(newValue);
                    GetDbHelper.db.SaveChanges();
                    MessageBox.Show("Data iscrizione modificata");


                }
                else if (attribute == "Data iscrizione" && studentsValidation.ValidationDate(newValue) != newValue) { MessageBox.Show(studentsValidation.ValidationDate(newValue)); }

            }
            else
            {
                MessageBox.Show("Nessun Studente selezionato");
            }
                



                    
                
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string matForm=textBox3.Text.ToUpper();
            string errorMessage = string.Empty;


            
            int rowsAffected = GetDbHelper.db.Students.SqlQuery("SELECT * FROM Students WHERE student_mat = @mat",
            new SqlParameter("@mat", matForm)).Count();

            if (rowsAffected > 0) { } else { errorMessage+="Studente non presente"; }


            if (errorMessage==string.Empty)
            {
                long StudentId=GetDbHelper.db.Students.SqlQuery("SELECT * FROM Students WHERE student_mat = @mat", new SqlParameter("@mat", matForm)).Select(s=>s.student_id).FirstOrDefault();
                student=GetDbHelper.db.Students.Find(StudentId);
                this.comboBox2.SelectedIndex =(int)student.student_faculty_id;
                if (student.student_gender.StartsWith("M"))
                {
                    this.Maschio.Checked= true;
                    this.Femmina.Checked = false;
                }
                else
                {
                    this.Maschio.Checked = false;
                    this.Femmina.Checked= true;
                }
                
                
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student = null;
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.comboBox2.SelectedIndex = 0;
            this.comboBox1.SelectedIndex = 0;
            this.Femmina.Checked = false;
            this.Maschio.Checked = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (student == null)
            {
              
            }
            else
            {
                string attribute=comboBox1.Text;

                if (attribute=="Nome")
                {

                    textBox1.Text = student.student_name;

                }else if (attribute == "Cognome")
                {
                    textBox1.Text = student.student_surname;
                }
                else if (attribute == "Età")
                {
                    textBox1.Text = student.student_age.ToString();
                }
                else if (attribute == "Genere")
                {
                    textBox1.Text = student.student_gender;
                }
                else if (attribute == "Data iscrizione")
                {
                    textBox1.Text = student.student_date_of_enrollment.ToString();
                }
                
            }
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'universityDBDataSet.Faculties'. È possibile spostarla o rimuoverla se necessario.
            this.facultiesTableAdapter.Fill(this.universityDBDataSet.Faculties);

        }
    }

}
