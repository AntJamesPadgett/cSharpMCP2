using System;

namespace cSharpMCP2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Tony";

            string message = "My name is " + myName;

            string capsMessage = message.ToUpper();

            string LowerCaseMessage = message.ToLower();




            Console.WriteLine(LowerCaseMessage);
            Console.WriteLine(capsMessage);
            Console.WriteLine(myName);

            Console.WriteLine($"My name is {myName}");

            Console.Read();



        }
    }
}
