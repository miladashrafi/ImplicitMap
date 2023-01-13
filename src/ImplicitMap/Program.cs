// See https://aka.ms/new-console-template for more information
using TypeConversion;

Console.WriteLine("Hello, World!");

var student = new Student
{
    Name = "Milad Ashrafi",
    Id = 1,
    Code = "1234"
};

StudentDto castedStudent = student;

Console.WriteLine(castedStudent);
Console.Read();