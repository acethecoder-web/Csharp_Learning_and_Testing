namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String StudFirstName, StudMiddleName, StudLastName, StudCourse, StudBirthYear ;
            int RealStudAge, YearNow = 2025, ConvertedBirthYear;

            Console.WriteLine();
            Console.WriteLine("========== ENROLLMENT SYSTEM V.01  =========="); 
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("========   PRESS ENTER TO CONTINUE ....   ========");
            Console.ReadKey();
            Console.WriteLine();

            //=====================================================================//

            Console.Write("\nEnter Student First Name       : ");
            StudFirstName = Console.ReadLine();

            Console.Write("Enter Student Middle Name      : ");
            StudMiddleName = Console.ReadLine();

            Console.Write("Enter Student Last Name        : ");
            StudLastName = Console.ReadLine();

            Console.Write("Enter Student Birthyear        : ");
            StudBirthYear = Console.ReadLine();

            ConvertedBirthYear = Convert.ToInt32(StudBirthYear);
          
            Console.Write("Enter Student Preferred Course : ");
            StudCourse = Console.ReadLine();

            RealStudAge = YearNow - ConvertedBirthYear;
            //======================================================================//

            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine();
            Console.WriteLine("Your full name is " + StudLastName + ", " + StudFirstName + " " + StudMiddleName + " , You are " + RealStudAge + ", and you're interested to enroll in " + StudCourse );
            Console.WriteLine();
            Console.WriteLine("is this Correct? Y OR N");
            Console.ReadKey();

        }
    }
}
