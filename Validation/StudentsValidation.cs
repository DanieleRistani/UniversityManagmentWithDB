using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UniversityManagerWithDB.Entity;
using UniversityManagerWithDB.Helper;

namespace UniversityManagerWithDB.Validation
{
    public class StudentsValidation
    {
        public String ValidationMat(string mat)
        {
            if (mat.Length == 4 && char.IsLetter(mat.ToCharArray()[0]))
            {
                int rowsAffected = GetDbHelper.db.Students.SqlQuery("SELECT * FROM Students WHERE student_mat = @mat",
                new SqlParameter("@mat", mat.ToUpper())).Count();

                if (rowsAffected > 0 ) { return "Matricola già esistente"; } else { return mat; }


            }
            else if (mat == string.Empty)
            {
                
                return"Matricola con valore nullo";
              
                
            }
            else if (mat.Length != 4)
            {
                
                return "Matricola non di 4 caratteri";
                
                
            }
            else if (int.TryParse(mat, out _))
            {
                
                return"Matricola con Lettera iniziale non presente";

            }
            else
            {
                return "Matricola non valida";
            }


        }
        public String ValidationName(string name)
        {
            if (int.TryParse(name, out _))
            {


                return"Nome non accetta valori numerici";


            }
            else if (name == string.Empty)
            {

                return"Nome con valore nullo";


            }
            else
            {
                return name;
            }

        }
        public String ValidationSurname(string surname)
        {
            if (int.TryParse(surname, out _))
            {

                return"Cognome non accetta valori numerici";
               

            }
            else if (surname == string.Empty)
            {
                return "Cognome con valore nullo";
                

            }
            else
            {
                
                return surname;
            }

        }
        public string ValidationAge(string age)
        {
            int ageInt;
            if (int.TryParse(age, out ageInt) && ageInt >= 18)
            {
                
                return age;
                

            }
            else if (age == string.Empty)
            {
                
                return "Età non accetta valori nulli";
                
            }
            else if (!int.TryParse(age, out _))
            {
                
                return"Età non accetta valori stringa";
                
            }
            else
            {

               
                return"Età non valida";
                

            }

        }
        public String ValidationDate(string date)
        {
            if (DateTime.TryParse(date, out _))
            {

                return date;

            }
            else if (date == string.Empty)
            {
                
                return"Data non accetta valori nulli";
                

            }
            else
            {
               
                return"Data non valida";
                
            }

        }

    }
}
