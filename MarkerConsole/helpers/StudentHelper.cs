﻿using Library.MarkerApp.Models;
using Library.MarkerApp.Services;

namespace MarkerConsole.helpers
{
    internal class StudentHelper
    {
        private StudentService studentSvc = StudentService.Current;
        public void AddStudent()
        {
            Console.WriteLine("Enter Student Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Classification ((F)reshman, (SO)phomore, (J)unior, (SE)nior): ");
            string? classificationStr = Console.ReadLine();

            Guid guid = Guid.NewGuid();

            ClassificationType? classification;
            switch (classificationStr)
            {
                case "F":
                case "f":
                    classification = ClassificationType.Freshman;
                    break;
                case "SO":
                case "so":
                    classification = ClassificationType.Sophomore;
                    break;
                case "J":
                case "j":
                    classification = ClassificationType.Junior;
                    break;
                case "SE":
                case "se":
                    classification = ClassificationType.Senior;
                    break;
                default:
                    classification = null;
                    break;
            }

            Student newStudent = new Student { Name = name, Classification = classification, ID = guid };

            studentSvc.Add(newStudent);
        }
        public void ListStudents()
        {
            studentSvc.Students.ToList().ForEach(Console.WriteLine);
        }
    }
}
