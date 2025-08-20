using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String StudFirstName, StudMiddleName, StudLastName, StudCourse, UserName = "aceshapiz22", PassWord = "hapiz123",
                   UserNameInput, PasswordInput, Date, UserAnswer;

            int RealStudAge, YearNow = 2025, StudBirthYear, index , Year, UserInputDate, UserInputYear, UserInputMonth,
                    Question = (6 * 6) + 5, Life=5;

            float EnglishGrade, MathGrade, ScienceGrade, IctGrade, AveGrade;
            
            string[] email = {"aceshapiz6@gmail.com",
                             "gerickvelasquez@gmail.com",
                             "realsullera@gmail.com",
                             "cherwinrabang@gmail.com",
                             "markasuncion@gmail.com" };

            string[] username = { "ace", "gerick", "real", "cherwin", "mark" };

            string[] password = { "123", "456", "789", "1011", "1213" };

            string[] months = {"january","february","march","april","may","june",
                               "july","august","september", "october", "november","december"};


            //=====================================================================//

            Console.WriteLine("]\n==========           ENROLLMENT SYSTEM V.01        ===========");
            Console.Write("\n \n ========   PRESS ENTER YOUR CREDENTIALS TO CONTINUE   ========");
            Console.ReadKey();
            Console.Write("\n \nENTER YOUR USERNAME: ");

            UserNameInput = Console.ReadLine();
            Console.Write("ENTER YOUR PASSWORD: ");
            PasswordInput = Console.ReadLine();

            if (UserNameInput.Equals(UserName, StringComparison.CurrentCultureIgnoreCase) && PasswordInput.Equals(PassWord))
            {

                //=====================================================================//

                Console.WriteLine("\nWELCOME BACK" + " " + UserNameInput + "!");

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
                                                         + StudCourse);

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

                if (AveGrade >= 96) Console.WriteLine("EXCELLENT");
                else if (AveGrade >= 90) Console.WriteLine("Very Good");
                else if (AveGrade >= 85) Console.WriteLine("GOOD");
                else if (AveGrade >= 80) Console.WriteLine("FAIR");
                else if (AveGrade >= 75) Console.WriteLine("PASSED");
                else Console.WriteLine("FAILED");

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

            Console.Write("\nMONTH: ");
            UserInputMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("DATE: ");
            UserInputDate = Convert.ToInt32(Console.ReadLine());
            Console.Write("YEAR: ");
            UserInputYear = Convert.ToInt32(Console.ReadLine());


            switch (UserInputMonth)
            {
                case 1:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                case 2:
                    Console.Write("February only have 28 days");
                    break;
                case 3:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                case 4:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                case 5:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                case 6:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                case 7:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                case 8:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                case 9:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                case 10:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                case 11:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                case 12:
                    Console.Write(months[UserInputMonth - 1]);
                    Console.Write(" " + UserInputDate + " " + UserInputYear);
                    break;
                default:
                    Console.Write("Invalid month input. Please enter a number between 1 and 12.");
                    break;
            }
            //======================================================================//

            while (Life > 0)
            {
                Console.Write("\nWHAT IS THE ANSWER OF (6 * 6) + 5? : ");
                UserAnswer = Console.ReadLine();
                if (UserAnswer.Equals(Question.ToString()))
                {
                    Console.Write("\nCorrect Answer!\n");
                    break;
                }
                else
                {
                    Life--;
                    Console.Write("\nWrong answer... \n \nYou have " + Life + " life(s) left.\n");
                    if (Life == 0)
                    {
                        Console.WriteLine("\nYou have no more lives left. Exiting the program.");
                        return;
                    }
                }
            }
            //======================================================================//

        }
    }
}
