using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Vinay_MultiLevel_Inheritance
{
    public class Student
    {
        public int studentId { get; set; }
        public string? studentName { get; set; }
        public string? gender { get; set; }
        public string? address { get; set; }
        public int standard { get; set; }
        public string? section { get; set; }

        

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Student Id :"+ studentId);
            Console.WriteLine("Student Student Name :" + studentName);
            Console.WriteLine("Student Gender :" + gender);
            Console.WriteLine("Student Address :" + address);
            Console.WriteLine("Student Standard :" + standard);
            Console.WriteLine("Student Section :" + section);
        }

    }
}
