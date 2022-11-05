using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Vinay_MultiLevel_Inheritance
{
    public class Marks: Student
    {
        public int Telugu { get; set; }
        public int Hindi { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }
        public double TotalMarks { get; set; }

        public void DisplayAllSubjectsMarks()
        {
            Console.WriteLine("Telugu Marks  : "+ Telugu);
            Console.WriteLine("Hindi Marks  : " + Hindi);
            Console.WriteLine("English Marks  : " + English);
            Console.WriteLine("Maths Marks  : " + Maths);
            Console.WriteLine("Science Marks  : " + Science);
            Console.WriteLine("Social Marks  : " + Social);
        }

        public void CalculateTotalMarks()
        {
            TotalMarks = Telugu + English + Maths + Hindi + Science + Social;
            Console.WriteLine("Total Marks  : " + TotalMarks);
            //Console.WriteLine("Total Marks  : "+totalMarks);
        }
    }
}
