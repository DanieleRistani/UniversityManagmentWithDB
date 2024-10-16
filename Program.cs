﻿using System;
using University.Repository;
using UniversityManagerWithDB.Enum;
using UniversityManagerWithDB.Forms;
using UniversityManagerWithDB.Helper;
using UniversityManagerWithDB.Service;

namespace UniversityManagerWithDB
{

    internal class Program
    {


        public static AppMenusService appMenusService { get;set; }=new AppMenusService();

        static void Main(string[] args) =>AppMenu();

        public static void AppMenu()
        {


            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Menù Principale:\n----------------------------------------------");
                string[] options = { "Gestione Studenti", "Gestione Docenti", "Gestione Esami", "Lista Facoltà", "Esci" };
                int selectedIndex = 0;
                ConsoleKeyInfo key;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Menù Principale:\n----------------------------------------------");
                    for (int i = 0; i < options.Length; i++)
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
                        selectedIndex = (selectedIndex > 0) ? selectedIndex - 1 : options.Length - 1;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        selectedIndex = (selectedIndex < options.Length - 1) ? selectedIndex + 1 : 0;
                    }

                } while (key.Key != ConsoleKey.Enter);

                Console.Clear();

                switch (selectedIndex)
                {
                    case (int)AppMenuEnum.StudentsManagment:

                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");
                        appMenusService.StudentsManagment();

                        break;
                    case (int)AppMenuEnum.TeachersManagment:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");
                        appMenusService.TeachersManagment();

                        break;
                    case (int)AppMenuEnum.ExamsManagment:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");
                        appMenusService.ExamsManagment();
                        break;
                    case (int)AppMenuEnum.Facultieslist:
                        Console.WriteLine($"Hai selezionato: {options[selectedIndex]}");
                        
                        break;
                    case (int)AppMenuEnum.Exit:
                        Console.WriteLine($"Uscita dall' Applicazione");
                        exitLoop = true;
                        break;
                }

                if (exitLoop == false)
                {
                    Console.WriteLine("Premere un tasto per tornare al menù principale");
                    _ = Console.ReadKey();
                }

            }
            exitLoop = true;
        }




    }
}
