using System;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation val = new Validation();
            Console.WriteLine("Input email");
            string email = Console.ReadLine();
            Console.WriteLine(val.ValidateEmail(email));
            Console.WriteLine("Input path");
            string path = Console.ReadLine();
            Console.WriteLine(val.ValidatFilePath(path));
            Console.WriteLine("Input url");
            string url = Console.ReadLine();
            Console.WriteLine(val.ValidateURL(url));
            Console.ReadLine();

        }
    }
}
