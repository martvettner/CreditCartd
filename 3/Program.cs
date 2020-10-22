using System;
using System.ComponentModel.DataAnnotations;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter your ID code: ");
            string IDcode = Console.ReadLine();
            int IDlength = IDcode.Length;
            
            if (Validate(IDcode))
            {
                HelloUser(IDcode);
                
            }
            else
            {
                Console.WriteLine("Wrong format");
            }
            
            Console.Write("Enter your credit card number: ");
            string credit = Console.ReadLine();
        }
        public static bool Validate(string IDcode)
        {
            if (IDcode.Length == 11)
            {
                try
                {
                    long.Parse(IDcode);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void HelloUser(string IDcode)
        {
            int FirstNum = Int32.Parse(IDcode[0].ToString());
            if (FirstNum == 1 || FirstNum == 3 || FirstNum == 5)
            {
                Console.WriteLine("Hello, Sir!");
            }
            else if (FirstNum == 2 || FirstNum == 4 || FirstNum == 6)
            {
                Console.WriteLine("Hello Madam!");
            }

        }
        public static bool credit(string credit)
        {
            if(credit.Length == 16)
            {
                try
                {
                    long.Parse(credit);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }                
            }
            else
            {
                return false;
            }

        }
        public static bool cvv(string cvv)
        {
            if(cvv.Length == 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
