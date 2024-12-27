using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Enter a Number ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number);

            #endregion

            #region Q2
            //Console.WriteLine("Enter string to convert it into integer : ");
            //Console.ReadLine();
            //int Result;
            //bool success = int.TryParse(Console.ReadLine(), out Result);
            //Console.WriteLine(Result);
            #endregion

            #region Q3
            //float x = 1.5f , y = 2.5f;
            //float Result = x + y;
            //Console.WriteLine(Result);
            #endregion


            #region Q4
            //string text = "Hello, World!";
            //string substring = text.Substring(7, 5);
            //Console.WriteLine(substring);

            #endregion

            #region Q5
            //int x = 5;
            //int y = x;
            //y = 10;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            #endregion

            #region Q6
            //Person person1 = new Person();
            //Person person2 = person1;
            //Console.WriteLine(person1);
            //Console.WriteLine(person2);

            #endregion


            #region Q7
            //string str = "Mohammed";
            //string str2 = "Magdy";
            //string Result = str + " " + str2;
            //Console.WriteLine(Result);
            #endregion

            #region Q8
            //Console.Write("Enter Principal: ");
            //double principal = double.Parse(Console.ReadLine());
            //Console.Write("Enter Rate: ");
            //double rate = double.Parse(Console.ReadLine());
            //Console.Write("Enter Time: ");
            //double time = double.Parse(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine(interest);

            #endregion

            #region Q9
            //Console.WriteLine("Enter Your weight in kilograms");
            //double weight = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Your height in meters");
            //double height = double.Parse(Console.ReadLine());
            //double BMI = weight / (height * height ) ;
            //Console.WriteLine(BMI);

            #endregion

            #region Q10
            //Console.Write("Enter Temperature: ");
            //int temperature = int.Parse(Console.ReadLine());

            //string result = temperature < 10 ? "Just Cold" :
            //                temperature > 30 ? "Just Hot" :
            //                "Just Good";

            //Console.WriteLine(result);

            #endregion


            #region Q11
            //Console.Write("Enter Date (dd/MM/yyyy): ");
            //DateTime date = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine($"Today’s date: {date:dd , MM , yyyy}");
            //Console.WriteLine($"Today's date: {date:dd / MM / yyyy}");
            //Console.WriteLine($"Today's date: {date:dd – MM – yyyy}");

            #endregion

            #region Q12
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //// the answer : The event is on 06/14/2024
            #endregion

            #region Q13
            int d;
            d = Convert.ToInt32(!(30 < 20));
            //the answer is : A value 1 will be assigned to d.

            #endregion

            #region Q14
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            //the answer : 6 1

            #endregion


            #region Q15
            //int num = 1, z = 5;


            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            ////the answer : 7 7



            #endregion


        }
    }
}
