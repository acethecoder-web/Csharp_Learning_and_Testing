using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String StudFirstName, StudMiddleName, StudLastName, StudCourse;
            int RealStudAge, YearNow = 2025, StudBirthYear, index;
            float EnglishGrade, MathGrade, ScienceGrade, IctGrade, AveGrade;

            string[] email = {"aceshapiz6@gmail.com",
                             "gerickvelasquez@gmail.com",
                             "realsullera@gmail.com",
                             "cherwinrabang@gmail.com",
                             "markasuncion@gmail.com" };

            string[] username = { "ace", "gerick", "real", "cherwin", "mark" };
            string[] password = { "123", "456", "789", "1011", "1213" };

            //=====================================================================//

            Console.WriteLine("]\n  ========== ENROLLMENT SYSTEM V.01  =========="); 
            Console.Write("\n \n ========   PRESS ENTER TO CONTINUE ....   ========");
            Console.ReadKey();

            //=====================================================================//

            Console.Write("\nEnter Student First Name       : ");
            StudFirstName = Console.ReadLine();

            Console.Write("Enter Student Middle Name      : ");
            StudMiddleName = Console.ReadLine();

            Console.Write("Enter Student Last Name        : ");
            StudLastName = Console.ReadLine();
            
            Console.Write("Enter Student Birthyear        : ");
            StudBirthYear = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("Enter Student Preferred Course : ");
            StudCourse = Console.ReadLine();

            RealStudAge = YearNow - StudBirthYear;
            //======================================================================//
             
            Console.WriteLine("\n=============================================");
            Console.WriteLine("\nYour full name is " + StudLastName + ", " 
                                                     + StudFirstName + " "  
                                                     + StudMiddleName + " , You are "
                                                     + RealStudAge + ", and you're interested to enroll in " 
                                                     + StudCourse );

            Console.WriteLine("\nis this Correct? Y OR N");
            Console.ReadKey();

            //======================================================================//

            Console.WriteLine("\nSTUDENT'S GRADE LAST SCHOOL YEAR");
            Console.WriteLine("\n \n=============================================");
            Console.Write("Enter Student's Grade in Math       : ");
            MathGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Student's Grade in English    : ");
            EnglishGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Student's Grade in Science    : ");
            ScienceGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Student's Grade in Ict        : ");
            IctGrade = Convert.ToSingle(Console.ReadLine());
            AveGrade = (MathGrade + EnglishGrade + ScienceGrade + IctGrade) / 4;
            Console.WriteLine("\n TOTAL AVERAGE OF THE GRADES  : " + AveGrade);
            Console.WriteLine("=============================================");

            //======================================================================//

            Console.Write("\n Enter an index: ( Limit is 0-4): ");
            index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=============================================");

            Console.Write("\nINDEX    : " + index);
            Console.Write("\nEMAIL    : " + email[index]);
            Console.Write("\nUSERNAME : " + username[index]);
            Console.Write("\nPASSWORD : " + password[index]);

            Console.WriteLine("\n=============================================");

            //======================================================================//


        }
    }
}
