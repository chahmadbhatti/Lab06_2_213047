//213047
using System;
using System.Collections.Generic;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Student()
    {
    }

    public Student(int studentId, string firstName, string lastName, DateTime dateOfBirth)
    {
        StudentId = studentId;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
}


class Program
{
    static void Main()
    {
        List<int> intList = new List<int>();
        intList.Add(10);
        intList.Add(20);
        intList.Add(30);
        intList.Add(40);

        List<string> strList = new List<string>();
        strList.Add("one");
        strList.Add("two");
        strList.Add("three");
        strList.Add("four");
        strList.Add(null);
        strList.Add(null);

        List<Student> studentList = new List<Student>();
        studentList.Add(new Student());
        studentList.Add(new Student());
        studentList.Add(new Student());
    }
}
