﻿using System;
using System.Collections.Generic;
using UniversityManagerWithDB.Enum;

namespace UniversityManagerWithDB.Service
{
    public class AppMenusService
    {

        public void FacultiesList()
        {
            Console.WriteLine("Lista Facolta'");
        }

        public void StudentsManagment()
        {
            bool exitLoop = false;
            while (!exitLoop)
            {
                List<String> options = ["Lista studenti", "Cerca Studente", "Aggiungi studente", "Modifica studente", "Cancella studente", "Esci"];

                int selectedIndex = 0;
                ConsoleKeyInfo key;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Menù Gestione studenti:\n----------------------------------------------");
                    for (int i = 0; i < options.Count; i++)
                    {
                        if (i == selectedIndex)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine(options[i]);
                        Console.ResetColor();
                    }

                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        selectedIndex = (selectedIndex > 0) ? selectedIndex - 1 : options.Count - 1;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        selectedIndex = (selectedIndex < options.Count - 1) ? selectedIndex + 1 : 0;
                    }

                } while (key.Key != ConsoleKey.Enter);

                Console.Clear();


                switch (selectedIndex)
                {
                    case (int)StudentsManagmentEnum.GetAllStudents:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)StudentsManagmentEnum.SearchStudent:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)StudentsManagmentEnum.AddStudent:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)StudentsManagmentEnum.UpdateStudent:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)StudentsManagmentEnum.DeleteStudent:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)StudentsManagmentEnum.Exit:

                        exitLoop = true;
                        break;
                }


                if (exitLoop == false)
                {
                    Console.WriteLine("Premere un tasto per tornare al menù gestione studenti");
                    _ = Console.ReadKey();
                }

            }
            exitLoop = true;
        }

        public void TeachersManagment()
        {
            bool exitLoop = false;
            while (!exitLoop)
            {
                List<String> options = ["Lista Professori", "Cerca Professore", "Aggiungi Professore", "Modifica Professore", "Cancella Professore", "Esci"];

                int selectedIndex = 0;
                ConsoleKeyInfo key;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Menù Gestione Professori:\n----------------------------------------------");
                    for (int i = 0; i < options.Count; i++)
                    {
                        if (i == selectedIndex)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine(options[i]);
                        Console.ResetColor();
                    }

                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        selectedIndex = (selectedIndex > 0) ? selectedIndex - 1 : options.Count - 1;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        selectedIndex = (selectedIndex < options.Count - 1) ? selectedIndex + 1 : 0;
                    }

                } while (key.Key != ConsoleKey.Enter);

                Console.Clear();


                switch (selectedIndex)
                {
                    case (int)TeachersManagmentEnum.GetAllTeachers:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)TeachersManagmentEnum.SearchTeacher:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)TeachersManagmentEnum.AddTeacher:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)TeachersManagmentEnum.UpdateTeacher:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)TeachersManagmentEnum.DeleteTeacher:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)TeachersManagmentEnum.Exit:

                        exitLoop = true;
                        break;
                }


                if (exitLoop == false)
                {
                    Console.WriteLine("Premere un tasto per tornare al menù gestione Professori");
                    _ = Console.ReadKey();
                }

            }
            exitLoop = true;
        }

        public void ExamsManagment()
        {
            bool exitLoop = false;
            while (!exitLoop)
            {
                List<String> options =  ["Lista Esami", "Cerca Esame", "Aggiungi Esame", "Modifica Esame", "Cancella esame", "Esci" ];

                int selectedIndex = 0;
                ConsoleKeyInfo key;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Menù Gestione Esami:\n----------------------------------------------");
                    for (int i = 0; i < options.Count; i++)
                    {
                        if (i == selectedIndex)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine(options[i]);
                        Console.ResetColor();
                    }

                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        selectedIndex = (selectedIndex > 0) ? selectedIndex - 1 : options.Count - 1;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        selectedIndex = (selectedIndex < options.Count - 1) ? selectedIndex + 1 : 0;
                    }

                } while (key.Key != ConsoleKey.Enter);

                Console.Clear();


                switch (selectedIndex)
                {
                    case (int)ExamsManagmentEnum.GetAllExams:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)ExamsManagmentEnum.SearchExam:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)ExamsManagmentEnum.AddExam:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)ExamsManagmentEnum.UpdateExam:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)ExamsManagmentEnum.DeleteExam:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");

                        break;
                    case (int)ExamsManagmentEnum.Exit:

                        exitLoop = true;
                        break;
                }


                if (exitLoop == false)
                {
                    Console.WriteLine("Premere un tasto per tornare al menù gestione Esami");
                    _ = Console.ReadKey();
                }

            }
            exitLoop = true;
        }

    }

}
