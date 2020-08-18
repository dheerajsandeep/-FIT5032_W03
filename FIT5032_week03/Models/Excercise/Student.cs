using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows;

namespace FIT5032_week03.Models.Excercise
{
    public class Student
    {
        public String Name { get; set; }
        public String PhoneNumber { get; set; }

        public Student(String name, String phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

    }

    public class ExampleDictionary
    {
        public void Example()
        {
            Dictionary<int, Student> studentDictionary = new Dictionary<int,Student>();
            Student s1 = new Student("Alex", "0456783211");
            Student s2 = new Student("Kim", "0421456789");

            studentDictionary.Add(1, s1);
            studentDictionary.Add(2, s2);

            Student result = new Student("", "");
            studentDictionary.TryGetValue(1, out result);   
        }
        public void displayExample()
        {
            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
            foreach (KeyValuePair<int, Student> kv in studentDictionary)
                Console.WriteLine("Key: {0}, Value: {1}", kv.Key, kv.Value);
        }
    }

    
}