// See https://aka.ms/new-console-template for more information
using Assigment3;
using System.Linq.Expressions;


List<Student> Astudent = new List<Student>();
Astudent.Add(new Student() { Id = 001, Name = "Justlin", Age = 7, Grade = 12, Gender = "female" });

Astudent.Add(new Student() { Id = 002, Name = "Esther", Age = 10, Grade = 15, Gender = "female" });

Astudent.Add(new Student() { Id = 020, Name = "Harold", Age = 9, Grade = 19, Gender = "male" });

Astudent.Add(new Student() { Id = 015, Name = "Pius", Age = 15, Grade = 07, Gender = "male" });

Astudent.Add(new Student() { Id = 011, Name = "Zendaya", Age = 14, Grade = 21, Gender = "female" });

Astudent.Add(new Student() { Id = 008, Name = "Josh", Age = 9, Grade = 12, Gender = "male" });

Astudent.Add(new Student() { Id = 017, Name = "Funke", Age = 6, Grade = 20, Gender = "female" });

Astudent.Add(new Student() { Id = 013, Name = "Justin", Age = 13, Grade = 11, Gender = "male" });

Astudent.Add(new Student() { Id = 005, Name = "Pritya", Age = 12, Grade = 08, Gender = "female" });

Astudent.Add(new Student() { Id = 007, Name = "Gold", Age = 11, Grade = 13, Gender = "female" });



//Student.studentsbiodata(Astudent);



///using Lambda Expressions => to Print out names of the Ten Students

var studentnames = Astudent.Select(x => x.Name); // Lambda Expression being used.

foreach (var student in studentnames)
{

    Console.WriteLine(student);

}



// using lambda expression to print out Id, Name, Gender and Age where AGE is greater than 12


var studentdata = Astudent.FindAll(x => x.Age >12).ToList();

foreach (var student in studentdata) // creating a variable upon which the function is run
{
    Console.WriteLine("ID ~ {0}, Name ~ {1}, Age ~ {2}, Gender ~ {3}", student.Id, student.Name, student.Age, student.Gender); // using place holder concatenation in string format 

}



/*using lambda expression to print out age,gender ,name and grades where y is records of students with grades <= 14 */


var studentrecord = Astudent.FindAll(y => y.Grade <= 14); /*Lambda Expression*/

foreach (var student in studentrecord)
{

    Console.WriteLine(string.Format("Name: {0}, Age: {1}, Grade: {2}, Gender: {3}", student.Name, student.Age, student.Grade, student.Gender)); // using place holder concatenation with string format
}



Console.ReadKey();
