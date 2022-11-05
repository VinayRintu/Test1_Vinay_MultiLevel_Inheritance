// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Reflection;
using Test1_Vinay_MultiLevel_Inheritance;
using static System.Collections.Specialized.BitVector32;

Console.WriteLine("Hello, World!");


Grade objGrade = new Grade();

//Student
Console.WriteLine("Enter Student Id");
objGrade.studentId = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Student Name");
objGrade.studentName = Console.ReadLine();

Console.WriteLine("Enter Student Gender");
objGrade.gender = Console.ReadLine();

Console.WriteLine("Enter Student Address");
objGrade.address = Console.ReadLine();

Console.WriteLine("Enter Student Standard ");
objGrade.standard = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Student Section");
objGrade.section = Console.ReadLine();

objGrade.DisplayStudentDetails();
Console.WriteLine("************");

//Marks
Console.WriteLine("Enter Telugu Marks");
objGrade.Telugu = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Hindi Marks");
objGrade.Hindi = int.Parse(Console.ReadLine());

Console.WriteLine("Enter English Marks");
objGrade.English = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Maths Marks");
objGrade.Maths = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Science Marks ");
objGrade.Science = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Social Marks");
objGrade.Social = int.Parse(Console.ReadLine());

objGrade.DisplayAllSubjectsMarks();
objGrade.CalculateTotalMarks();

//Grade
objGrade.CheckGrade();