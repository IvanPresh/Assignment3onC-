using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assigment3
{
    public class Student    {
        /// <summary>
        /// creating a property for the students biodata information
        /// </summary>
        public  string? Name {  get; set; } //making the string properting nullable
        public int Age { get; set; }
        public int Id { get; set; }
        public int Grade { get; set; }
        public string? Gender { get; set; }
        public static void studentsbiodata(List<Student> studentslist) 
        {
            foreach (var student in studentslist) 
            {
                if (student.Grade >= 7)    // printing out names of students using their grades as base reference.
                {
                    Console.WriteLine(student.Name);

                }
               
            }
        
        
        }

    }
}
