using System;
using EFExample.DataModels;
using EFExample.Enums;
using System.Collections.Generic;
using System.Linq;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            // INSERT
            // context.Students.Add(new Student() {
            //     StudentName = "Oso Garza",
            //     Classes = new List<Class>() {
            //         new Class() {
            //             ClassName = "Spanish",
            //             ClassLanguage = Language.Spanish,
            //             MaxClassSize = 23
            //         },
            //         new Class() {
            //             ClassName = "English II",
            //             ClassLanguage = Language.English,
            //             MaxClassSize = 31
            //         }
            //     }
            // });

            // context.SaveChanges();

            // SELECT
            // List<Class> classes = context
            //     .Classes
            //     .Where(c => c.ClassName.Equals("English II"))
            //     .ToList();

            // foreach (Class c in classes)
            // {
            //     Console.WriteLine(c.ClassName);
            // }

            // UPDATE
            // Student student = context.Students
            //     .Where(student => student.StudentId == 1)
            //     .FirstOrDefault();

            // Console.WriteLine($"ID:{student.StudentId} Name:{student.StudentName} Age:{student.Age}");

            // student.Age = 13;
            // student.StudentName = "Oso Garza Pardo";

            // context.Students.Update(student);
            // context.SaveChanges();

            // DELETE
            List<Class> classes = context.Classes
                .Where(cl => cl.ClassId > 0)
                .ToList();

            Console.WriteLine("Actual classes");
            foreach (Class cl in classes)
            {
                Console.WriteLine($"ID: {cl.ClassId} Name: {cl.ClassName} Language: {cl.ClassLanguage} Max Class Size: {cl.MaxClassSize}");
            }

            context.Classes.Add(new Class() {
                ClassName = "Historia",
                MaxClassSize = 34,
                ClassLanguage = Language.French
            });

            context.SaveChanges();

            classes = context.Classes.ToList();

            Console.WriteLine("Actual classes");
            foreach (Class cl in classes)
            {
                Console.WriteLine($"ID: {cl.ClassId} Name: {cl.ClassName} Language: {cl.ClassLanguage} Max Class Size: {cl.MaxClassSize}");
            }

            context.Classes.Remove(
                context.Classes
                .Where(c => c.ClassName.Equals("Historia"))
                .FirstOrDefault());

            context.SaveChanges();

            classes = context.Classes.ToList();

            Console.WriteLine("Actual classes");
            foreach (Class cl in classes)
            {
                Console.WriteLine($"ID: {cl.ClassId} Name: {cl.ClassName} Language: {cl.ClassLanguage} Max Class Size: {cl.MaxClassSize}");
            }

        }
    }
}
