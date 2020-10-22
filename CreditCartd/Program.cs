using System;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your personal code:");
            string idCode = Console.ReadLine();
            int idcodelenght = idCode.Length;
            string creditNum = "";
            string CVVNum = "";

            if (AgeCalc(idCode) >= 18 && HelloUser(idCode))
            {
                Console.WriteLine("Hello, Sir!");
                Console.Write("Enter ur Credit card number:");
                creditNum = Console.ReadLine();
                Console.Write("Enter ur CVV number:");
                CVVNum = Console.ReadLine();

            }
            else if (AgeCalc(idCode) >= 18 && !HelloUser(idCode))
            {
                Console.WriteLine("Hello, Madam!");
                creditNum = Console.ReadLine();
                Console.Write("Enter ur CVV number:");
                CVVNum = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry u are not enough old to use this app.");
            }
            if (AgeCalc(idCode) >= 18 && CVVValidator(CVVNum) && CardNumLength(creditNum) && Master(creditNum))
            {
                Console.WriteLine("You card has been accepted.");
            }

        }
        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format = {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool HelloUser(string idCode)
        {
            int firstnum = Int32.Parse(idCode[0].ToString());

            if (firstnum == 1 || firstnum == 3 || firstnum == 5)
            {
                return true;
            }
            else if (firstnum == 2 || firstnum == 4 || firstnum == 6)
            {
                return false;
            }
            else
            {
                return false;
            }

        }
        public static int GetYear(string idcode)
        {
            int firstnum = Int32.Parse(idcode.Substring(0, 1));
            string year = idcode.Substring(1, 2);
            string YearofBirth;
            int YoB = 0;
            if (firstnum == 3 || firstnum == 4)
            {
                YearofBirth = "19" + year;
                YoB = Int32.Parse(YearofBirth);
            }
            else if (firstnum == 5 || firstnum == 6)
            {
                YearofBirth = "20" + year;
                YoB = Int32.Parse(YearofBirth);

            }
            return YoB;

        }
        public static int AgeCalc(string idcode)
        {
            int year = GetYear(idcode);
            DateTime now = DateTime.Now;
            string currentYear = now.Year.ToString();
            int yearNow = Int32.Parse(currentYear);
            int age = yearNow - year;
            return age;
        }
        public static bool CVVValidator(string CVVNum)
        {
            if (CVVNum.Length == 3)
            {
                try
                {
                    Int32.Parse(CVVNum);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format:{e}");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Wrong CVV format.");
                return false;
            }
        }
        public static bool CardNumLength(string creditNum)
        {
            if (creditNum.Length == 16)
            {
                try
                {
                    long.Parse(creditNum);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format = {e}");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Wrong Card number Length.");
                return false;
            }
        }
        public static bool Master(string creditNum)
        {
            string FirstTwoNum = creditNum.Substring(0, 2);
            int intFirstTwoNum = Int32.Parse(FirstTwoNum);
            if (intFirstTwoNum == 51 || intFirstTwoNum == 52 || intFirstTwoNum == 53 || intFirstTwoNum == 54 || intFirstTwoNum == 55)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Its not Mastercard.");
                return false;
            }


        }

    }
}