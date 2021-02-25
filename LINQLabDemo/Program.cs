using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLabDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942};

            Console.WriteLine("Minimum Num");
            int minNum = nums.Min();
            Console.WriteLine(minNum);
            Console.WriteLine();

            Console.WriteLine("Maximum Num");
            int maxNum = nums.Max();
            Console.WriteLine(maxNum);
            Console.WriteLine();


            Console.WriteLine("Maximum Num Under 10000");
            int maxNumU10000 = nums.Where(x => x < 10000).Max();
            Console.WriteLine(maxNumU10000);
            Console.WriteLine();


            Console.WriteLine("Nums between 10 and 100");
            List<int> numB10A100 = nums.Where(x => x > 10 && x < 100).ToList();
            foreach(int i in numB10A100)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            Console.WriteLine("Nums between 100000 and 999999");
            List<int> numB100000A999999 = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            foreach(int i in numB100000A999999)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            Console.WriteLine("Count Even Numbers");
            int totalEvans = nums.Where(x => x % 2 == 0).Count();
            Console.WriteLine(totalEvans);
            Console.WriteLine();


            List<Student> students = new List<Student>
            {
                new Student("Jimmy",13),
                new Student("Hannah Banana", 21),
                new Student("Justin", 30),
                new Student("Sarah", 53),
                new Student("Hannibal", 15),
                new Student("Phillip", 16),
                new Student("Maria", 63),
                new Student("Abe", 33),
                new Student("Curtis", 10)
            };
            
            Console.WriteLine("Get me list of all students that can drive");
            List<Student> drivers = students.Where(x => x.CanDrink == true).ToList();
            foreach(Student d in drivers)
            {
                Console.WriteLine(d.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Find the oldest studsent");
            Student old = students.OrderByDescending(x => x.Age).First();
            Console.WriteLine(old.Name);
            Console.WriteLine();

            Console.WriteLine("Find the youngest studsent");
            Student young = students.OrderByDescending(x => x.Age).Last();
            Console.WriteLine(young.Name);
            Console.WriteLine();

            Console.WriteLine("Find oldest student under age of 25");
            Student oldU25 = students.OrderByDescending(x => x.Age < 25).First();
            Console.WriteLine(oldU25.Name);
            Console.WriteLine();

            Console.WriteLine("Find all students over 21 and even ages");
            List<Student> over21Even = students.OrderByDescending(x => x.Age >= 25).Where(x => x.Age % 2 == 0).ToList();
            foreach(Student s in over21Even)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Find all teenage students");
            List<Student> teenagers = students.OrderByDescending(x => x.Age).Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            foreach (Student s in teenagers)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Find all students whose name starts with a vowel");
            List<char> vowels = new List<char>{ 'a', 'e', 'i', 'o', 'u' };
            List<Student> studentVowels = students.Where(x => vowels.Contains(char.ToLower(x.Name[0]))).ToList();

            foreach (Student s in studentVowels)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();
        }
    }
}
