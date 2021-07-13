using System;
using System.Collections.Generic;

namespace EFExample.DataModels 
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public List<Class> Classes { get; set; }
    }
}