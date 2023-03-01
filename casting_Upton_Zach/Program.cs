using System;

namespace casting_Upton_Zach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter  a whole number!");
            int v = Convert.ToInt32(Console.ReadLine());
            int myFavNum = v;

            Console.WriteLine("Your favorite number is " + myFavNum);

            Console.WriteLine("Do you like video games? (Please enter 'true' or 'false.')");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"It is {isTrue} that I like video games!");

        }
    }
}
