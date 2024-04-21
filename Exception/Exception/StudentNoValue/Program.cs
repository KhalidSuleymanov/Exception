 using System;
using System.Text.RegularExpressions;

namespace StudentNoValue
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Student stud = new Student();
            Student stud1= new Student();
            Student stud2= new Student();
            Student stud3= new Student();
            Student stud4= new Student();

            Console.WriteLine(stud.No);
            Console.WriteLine(stud1.No);
            Console.WriteLine(stud2.No);
            Console.WriteLine(stud3.No);
            Console.WriteLine(stud4.No);

            stud1.FullName = "Resul Efendiyev";
            stud2.FullName = "Xalid Suleymanov";

            Console.WriteLine(stud1.FullName);
            Console.WriteLine(stud2.FullName);

            Console.WriteLine(Student.TotalCount);

            string password;
            do
            {
                Console.WriteLine("Zehmet olmasa password daxil edin:");
                password = Console.ReadLine();

            } while (!Student.PassWord(password));


            string groupNo;
            do
            {
                Console.WriteLine("GroupNo daxil edin:");
                groupNo = Console.ReadLine();

            } while (CheckGroupNo(groupNo) == false);

            Student student = new Student
            {
                GroupNo = groupNo,
            };
        }
        static bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrWhiteSpace(groupNo) || groupNo.Length != 4)
            {
                return false;
            }
            if (!char.IsUpper(groupNo[0]))
            {
                return false; 
            }
            for (int i = 1; i < groupNo.Length; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
