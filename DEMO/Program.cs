using System.Drawing;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace Day1Route
    {
        internal class program
        {
            static void Main()
            {
                #region MyRegion
                Console.WriteLine("mo");
                Console.WriteLine("mo");
                Console.WriteLine("mo");
                Console.WriteLine("mo");
                Console.WriteLine("mo");
                #endregion

                #region VariableDeclration
                int Number;
                Number = 5;
                Console.WriteLine(Number);
                int Number2 = 7, Number3 = 6;
                #endregion


                #region Data Type(Value type)
                Int32 Number7;
                Number7 = Number;
                Console.WriteLine(Number7);
                #endregion

                #region Data Value Reference Type
                Point P01; // Declare reference from type Point 
                           //P01 can refere to object from type point 

                P01 = new Point();
                Console.WriteLine(P01.x);
                Console.WriteLine(P01.y);
                Console.WriteLine(P01); // this give me the namespace
                Point P02 = new Point();
                P02.x = 12;
                Console.WriteLine(P01.x);
                Console.WriteLine(P02.x);
                P01 = P02;
                Console.WriteLine(P01.x);
                Console.WriteLine(P02.x);
                #endregion



                #region Object
                P01.GetType();

                P01.ToString();
                #endregion

                //Console.WriteLine("Enter Your Age : ");
                //int age = int.Parse(Console.ReadLine());   
                //Console.WriteLine("Enter Your GPA : ");
                //double GPA = double.Parse(Console.ReadLine());
                //Console.WriteLine(GPA);


                //Console.WriteLine("Enter Your Age : ");
                //int agee = Convert.ToInt32(Console.ReadLine());

                #region Parsing
                Console.WriteLine("Enter Your Age : ");

                int age;
                bool flag = int.TryParse(Console.ReadLine(), out int result);
                #endregion

                #region Fractions and Discards 
                double x = 1.5;
                float y = 1.5f;
                decimal z = 2.5m;


                int l = 1_000_000_000;

                #endregion


                #region Operators 

                int t = 10;
                t++;
                ++t;
                Console.WriteLine(t++);
                Console.WriteLine(++t);
                t--;
                --t;
                Console.WriteLine(t--);
                Console.WriteLine(--t);


                int sum, mul, sub, mod;
                int number1 = 2, number2 = 6;
                sum = number1 + number2;
                mul = number1 * number2;
                sub = number1 - number2;
                mod = number1 % number2;



                int w;
                w = 4;

                w += 2;
                w -= 2;
                w *= 2;
                w /= 2;
                w %= 2;

                int r = 6, n = 5;
                Console.WriteLine(r == n);
                Console.WriteLine(r != n);
                Console.WriteLine(r > n);
                Console.WriteLine(r < n);
                Console.WriteLine(r <= n);
                Console.WriteLine(r <= n);


                Console.WriteLine(!false);
                Console.WriteLine(false && true);
                Console.WriteLine(false || true);

                //Bitwise operators
                Console.WriteLine(!false);
                Console.WriteLine(false & true);
                Console.WriteLine(false | true);


                //ternary operator 

                bool Flag = 4 > 2;
                Console.WriteLine(Flag);


                String flag2 = 4 > 2 ? "true" : "false";
                String flag3 = 4 > 2 ? "Correct" : "Not correct";

                #endregion

            }
        }
    }

}
    }
}
