using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Problems
{

    public class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1. Display FriendsNames\n2. SquareMethod\n3. StringMethod\n4. NumberRepeat by 10times\n" +
                            "5. PrintName\n6. Average of 5 RandomNumbers\n7. Find perimeter and area of circle\n8. NextDate\n9. executionTime Method\n" +
                            "10. Multiply of 7 but not divide by 5\n11. Factorial of number\n12. Printing number without using loop\n" +
                            "13. roots of Quadratic equation\n14. NumberMethod by 3,5 & 7\n15. Characters check method");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: DisplayFriendsNames();
                    break;
                case 2: SquareMethod();
                    break;
                case 3: StringMethod();
                    break;
                case 4: Console.WriteLine(NumberRepeat());
                    break;
                case 5: PrintName();
                    break;
                case 6: RandomNumberAvg();
                    break;
                case 7:
                    {
                        Console.WriteLine("Enter the diagram of circle");
                        int diameter = Convert.ToInt32(Console.ReadLine());
                        CircleMethod(diameter);
                        break;
                    }
                case 8: NextDate();
                    break;
                case 9: ExecutionTime();
                    break;
                case 10: Multiply7Method();
                    break;
                case 11:
                    {
                        Console.Write("Enter the number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Factorial(num));
                        break;
                    }
                case 12:
                    {
                        int start = 1;
                        PrintNumbers(start);
                        break;
                    }
                case 13: RootsQuadratic();
                    break;
                case 14:
                    {
                        Console.Write("Enter the number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        string str = NumberGame(number);
                        Console.WriteLine(str);
                        break;
                    }
                case 15:
                    {
                        Console.WriteLine("Enter a String");
                        string? str = Console.ReadLine();
                        CharacterCheckMethod(str);
                        break;
                    }
                default: Console.WriteLine("Invalid Choice");
                    break;
            }

        }
        public static List<int> EvenNumberOnly(int[] nums)
        {
            List<int> result = new List<int>();
            foreach (int num in nums)
            {
                if(num%2==0) { result.Add(num); }
            }
            return result;
        }
        public static string CharacterCheckMethod(string str)
        {
            
            if (str is not null && str.IndexOf('a') != -1 && str.IndexOf('e') != -1 && str.IndexOf('p') != -1)
            {
                return "All Present";
            }
            else if(str is not null && (str.IndexOf('a') != -1 || str.IndexOf('e') != -1 || str.IndexOf('p') != -1))
            {
                return "One or More - Present";
            }
            else
            {
                return "None Present";
            }
        }

        static string NumberGame(int num)
        {
            string res = "";
            if (num % 3 == 0) res += "Pling";
            if (num % 5 == 0) res += "Plang";
            if (num % 7 == 0) res += "Plong";
            return res == "" ? Convert.ToString(num) : res;
        }

        static void RootsQuadratic()
        {
            Console.WriteLine("Enter the value of a, b, c for quadratic equation");
            int a = Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            int c= Convert.ToInt32(Console.ReadLine());
            int discrimant = b * b - (4 * a * c);
            if(discrimant > 0)
            {
                double root1= (-b + Math.Sqrt(discrimant))/(2*a);
                double root2 = (-b - Math.Sqrt(discrimant))/(2*a);
                Console.WriteLine($"The roots of the quadratic equation is {root1} and {root2}");
            }
            else if(discrimant == 0)
            {
                double root = -b/(2*a);
                Console.WriteLine($"In this quadratic equation roots are same, the number is: {root} ");
            }
            else
            {
                double realnumber=-b/(2*a);
                double imaginarynumber = Math.Round(Math.Sqrt(-discrimant)/(2*a),3);
                Console.WriteLine(imaginarynumber);
                Console.WriteLine($"The roots of the quadratic equation is {realnumber} + {imaginarynumber}i and {realnumber} - {imaginarynumber}i");
            }
        }

        static void PrintNumbers(int num)
        {
            if (num > 100) return;
            Console.Write(num+", ");
            PrintNumbers(++num);
        }
        public static bool Prime(int num)
        {
            if(num<=1) return false;
            for(int i = 2; i <= num/2; i++)
            {
                if(num%i==0) return false;
            }
            return true;
        }
        public static long Factorial(int num)
        {
            try
            {
                if (num < 0) throw new NegativeNumberException();
                if (num == 0) return 1;
                return num*Factorial(num-1);
            }
            catch (NegativeNumberException)
            {
                return -1;
            }
        }

        static void Multiply7Method()
        {
            for(int i = 2000; i <= 3200; i++)
            {
                if(i%7==0 && i%5!=0)
                {
                    Console.Write(i+", ");
                }

            }
        }
        static void ExecutionTime()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            for(int i = 0; i <=100;i++)
            {
                Console.Write(i+", ");
            }
            stopwatch.Stop();
            Console.WriteLine($"\n{stopwatch.ElapsedMilliseconds} ms");
        }
        static void NextDate()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter a month [1-12]: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter a date[1-31]: ");
            int date = Convert.ToInt32(Console.ReadLine());
            DateTime date1 = new(year, month, date);
            DateTime date2 = date1.AddDays(1);
            Console.WriteLine($"The next day is {date2.Year}-{date2.Month}-{date2.Day}");
        }

        static void CircleMethod(int diameter)
        {
            double perimeter = Math.Round(diameter * Math.PI, 2);
            Console.WriteLine($"The perimeter of circle is {perimeter}");
            double area = Math.Round(Math.PI * Math.Pow(diameter / 2, 2), 2);
            Console.WriteLine("The area of circle is "+area);
        }

        static void RandomNumberAvg()
        {
            int[] nums = new int[5];
            Random random = new();
            int sum = 0;
            Console.Write("The Array values are ");
            for(int i=0;i<5;i++)
            {
                nums[i] = random.Next(10,51);
                sum += nums[i];
                Console.Write(nums[i]+" ");
            }
            float avg = sum/ nums.Length;
            Console.WriteLine();
            Console.WriteLine($"The Average of array is {avg}");
        }

        static void PrintName()
        {
            Console.WriteLine("Enter your First, Last and Middle names");
            string? name = Console.ReadLine();
            if (name is not null)
            {
                foreach (string value in name.Split())
                {
                    Console.WriteLine(value);
                }
            }
        }

        static string NumberRepeat()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string ans = "";
            for(int i = 0; i < 3; i++)
            {
                ans += num;
            }
            return ans;
        }

        static void StringMethod()
        {
            Console.WriteLine("Enter your Favourite place");
            string? place = Console.ReadLine();
            if (place is not null)
            {
                Console.WriteLine(place.ToUpper());
                Console.WriteLine(place.ToLower());
            }
        }

        static void SquareMethod()
        {
            Console.WriteLine("Enter the Two numbers:");
            double first = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());
            double sum = first + second;
            Console.WriteLine("Square of sum of Two numbers is "+(sum*sum));
            double diffofSquare = Math.Pow(first - second,2);
            Console.WriteLine($"Square of difference of Two numbers is {diffofSquare}");
        }

        static void DisplayFriendsNames()
        {
            string[] names = [ "Dileep", "Rahman", "Ajith", "Dhanunjay", "Chethan" ];
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
    class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
            Console.WriteLine("Negative number not applicable for this method");
        }
    }
}