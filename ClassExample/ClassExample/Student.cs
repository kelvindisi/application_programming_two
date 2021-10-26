using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Student
    {
        string regNo, gender, name;
        int age;
        DateTime dob;

        public void getDetails()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter registration no: ");
            regNo = Console.ReadLine();
            Console.Write("Enter gender: ");
            gender = Console.ReadLine();
            Console.Write("Enter date of birth: ");
            dob = Convert.ToDateTime(Console.ReadLine());
        }
        public int getAge()
        {
            age = DateTime.Now.Year - dob.Year;
            return age;
        }
        public void print()
        {
            Console.WriteLine("Name: {0}\nGender: {1}\nReg No: {2}\nAge: {3}",
                name, gender, regNo, getAge());
        }
    }
}
