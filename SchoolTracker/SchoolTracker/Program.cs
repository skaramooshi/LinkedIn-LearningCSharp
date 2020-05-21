﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            
            var adding = true;

            while(adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.Address = Util.Console.Ask("Student Address: ");

                    newStudent.Phone = Util.Console.AskInt("Student Phone number: ");

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, please try again");
                }
                

            }

            foreach (var student in students)
            {

            
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);

            }
        }
    
        static void Import()
        {
            var importedStudent = new Student("jenny", 86, "Birthday", "Address", 123456);
            Console.WriteLine(importedStudent.Name);
        }
    
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }

    }
    class Student : Member
    {
        static public int Count = 0;
        
        public int Grade;
        public string Birthday;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }

    class Teacher : Member
    {
        public string Subject;
    }
}
