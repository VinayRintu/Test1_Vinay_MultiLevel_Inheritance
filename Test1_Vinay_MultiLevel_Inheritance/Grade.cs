using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Vinay_MultiLevel_Inheritance
{
    public class Grade: Marks
    {
        double averageMarks;
        public void CheckGrade()
        {
            averageMarks = TotalMarks/6;

            if(averageMarks >= 60)            
                Console.WriteLine("Grade is 'A' ");  
            
            else if(averageMarks < 60 && averageMarks >= 50)            
                Console.WriteLine("Grade is 'B' ");   
            
            else if(averageMarks >= 35 && averageMarks < 50)
                Console.WriteLine("Grade is 'C");
        }

    }
}
