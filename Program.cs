
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        public static void Task1()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                if (num % 2 == 0)
                    Console.WriteLine("המספר חיובי וזוגי");
                else
                    Console.WriteLine("המספר חיובי ואי-זוגי");
            }
            else if (num < 0)
            {
                Console.WriteLine("המספר שלילי");
            }
            else
            {
                Console.WriteLine("אפס");
            }
        }

        public static void Task2()
        {
            Console.Write("Enter usage in kWh: ");
            int usage = int.Parse(Console.ReadLine());

            Console.Write("Is it business? (true/false): ");
            bool isBusiness = bool.Parse(Console.ReadLine());

            double pricePerUnit;

            if (usage <= 300)
                pricePerUnit = 0.5;
            else if (usage <= 600)
                pricePerUnit = 0.7;
            else
                pricePerUnit = 1.0;

            double total = usage * pricePerUnit;

            if (isBusiness)
                total += total * 0.15;
            else
                total += total * 0.05;

            Console.WriteLine("Total to pay: " + total + " ₪");
        }

        public static void Task3()
        {
            Console.Write("Enter ride type (city/intercity): ");
            string rideType = Console.ReadLine();

            Console.Write("Enter passenger type (student/guide/regular): ");
            string passenger = Console.ReadLine();

            double price;

            if (rideType == "city")
                price = 6;
            else
                price = 12;

            if (passenger == "student")
                price -= price * 0.20;
            else if (passenger == "guide")
                price -= price * 0.30;

            Console.WriteLine("Final price: " + price + " ₪");
        }

        public static void Task4()
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter status (student / vip / armyRetired / none): ");
            string status = Console.ReadLine();

            double basePrice = 0;
            double total = 0;

            if (age <= 18)
            {
                basePrice = 120;

                if (status == "student")
                    total = basePrice - basePrice * 0.20;
                else
                    total = basePrice;
            }
            else if (age <= 60)
            {
                basePrice = 180;

                if (status == "vip")
                    total = basePrice + basePrice * 0.30;
                else
                    total = basePrice;
            }
            else
            {
                basePrice = 150;

                if (status == "armyRetired")
                    total = basePrice - basePrice * 0.15;
                else
                    total = basePrice;
            }

            Console.WriteLine("Total price: " + total + " ₪");
        }

        public static void Task5()
        {
            Console.Write("Enter room type (regular/suite): ");
            string room = Console.ReadLine();

            Console.Write("Is weekend? (true/false): ");
            bool weekend = bool.Parse(Console.ReadLine());

            Console.Write("Is club member? (true/false): ");
            bool club = bool.Parse(Console.ReadLine());

            double price;

            if (room == "regular")
                price = 400;
            else
                price = 700;

            if (weekend)
                price += price * 0.10;

            if (club)
                price -= price * 0.05;

            Console.WriteLine("Total hotel price: " + price + " ₪");
        }

        public static void Task6()
        {
            int age;
            bool isShabbat, isMember, isVIP;
            double price = 0;

            Console.Write("הכנס גיל: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("האם שבת? (true/false): ");
            isShabbat = bool.Parse(Console.ReadLine());

            Console.Write("האם חבר מועדון? (true/false): ");
            isMember = bool.Parse(Console.ReadLine());

            Console.Write("האם VIP? (true/false): ");
            isVIP = bool.Parse(Console.ReadLine());

            if (age <= 12)
            {
                price = 50;
                if (isShabbat)
                    price += 10;
            }
            else if (age >= 13 && age <= 17)
            {
                price = 70;
                if (isMember)
                    price = price * 1.20;
            }
            else
            {
                price = 100;
                if (isVIP)
                    price = price * 1.30;
            }

            Console.WriteLine("המחיר הוא: " + price + " ש\"ח");
        }

        public static void Task7()
        {
            int age;
            bool isSport, accidentLastYear, carAgeUnder10;
            double price = 0;

            Console.Write("גיל הנהג: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("האם הרכב ספורטיבי? (true/false): ");
            isSport = bool.Parse(Console.ReadLine());

            Console.Write("האם היה תאונה בשנה האחרונה? (true/false): ");
            accidentLastYear = bool.Parse(Console.ReadLine());

            Console.Write("האם הרכב מתחת ל-10 שנים? (true/false): ");
            carAgeUnder10 = bool.Parse(Console.ReadLine());

            if (age >= 24)
            {
                price = 600;
                if (isSport)
                    price = price * 1.25;
            }
            else if (age >= 25 && age <= 50)
            {
                price = 450;
                if (accidentLastYear)
                    price = price * 1.20;
            }
            else
            {
                price = 400;
                if (carAgeUnder10)
                    price = price * 1.10;
            }

            Console.WriteLine("פרמיית הביטוח היא: " + price + " ש\"ח");
        }

        public static void Task8()
        {
            int num;

            Console.Write("הכנס מספר: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                if (num % 4 == 0)
                {
                    Console.WriteLine("המספר זוגי ומתחלק ב-4");
                }
                else
                {
                    Console.WriteLine("המספר זוגי אבל אינו מתחלק ב-4");
                }
            }
            else
            {
                Console.WriteLine("המספר אינו זוגי");
            }
        }

        public static void Task9()
        {
            string username, password;

            Console.Write("הכנס שם משתמש: ");
            username = Console.ReadLine();

            Console.Write("הכנס סיסמה: ");
            password = Console.ReadLine();

            if (username == "admin")
            {
                if (password == "1234")
                {
                    Console.WriteLine("ברוך הבא מנהל!");
                }
                else
                {
                    Console.WriteLine("סיסמה שגויה למנהל");
                }
            }
            else
            {
                Console.WriteLine("שם המשתמש שונה מ-admin");
            }
        }

        public static void Task10()
        {
            double temp;

            Console.Write("הכנס טמפרטורה: ");
            temp = double.Parse(Console.ReadLine());

            if (temp > 0)
            {
                if (temp > 100)
                {
                    Console.WriteLine("קיטור");
                }
                else
                {
                    Console.WriteLine("נוזל");
                }
            }
            else
            {
                Console.WriteLine("קרח");
            }
        }

        static void Main(string[] args)
        {

        }
    }
}

