using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int num1, num2;

             Console.WriteLine("Enter first numbers");
             num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second numbers");
            num2 = Convert.ToInt32(Console.ReadLine());
            //getSum(num1, num2);
            //getChecked(num1, num2);
            //getMultiple(num1);
            //getTemprature(num1, num2);
            //getRange(num1, num2);
            //getSumRange(num1, num2);

        }

        /**1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.

Sample Input:
1, 2
3, 2
2, 2
Expected Output:
3
5
12   
    */
        static void getSum(int a, int b)
        {
            int sum = a + b;

            if (a == b)
            {
                Console.WriteLine((sum)* 3);
            }else
            {
                Console.WriteLine(sum);
            }
        }




        /*2. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

Sample Input:
30, 0
25, 5
20, 30
20, 25
Expected Output:
True
True
True
False*/
        static void getChecked(int a, int b)
        {
            int sum = a + b;
            if ((sum == 30) || (a == 30) || (b == 30))
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
        }




        /*3. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.

Sample Input:
3
14
12
37
Expected Output:
True
True
True
False*/
        static void getMultiple(int a)
        {
            if (a % 3 == 0 || a % 7 == 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }

        }

        /*4. Write a C# Sharp program that checks whether one temperature is less than 0 and another is greater than 100.

Sample Input:
120, -1
-1, 120
2, 120
Expected Output:
True
True
False*/
        static void getTemprature(int a, int b)
        {
            if (((a >= 100) && (b <= 0)) || ((b >= 100) && (a <= 0))) {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        /*5.  Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.

Sample Input:
100, 199
250, 300
105, 190
Expected Output:
True
False
True*/
        static void getRange(int a, int b)
        {
            if (((a >= 100) && (a <= 200)) || ((b >= 100) && (b <= 200)))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
        /*6. Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30.

Sample Input:
12, 17
2, 17
22, 17
20, 0
Expected Output:
29
30
39
30
*/
        static void getSumRange(int a, int b)
        {
            int sum = a + b;
            
            if ((sum >= 10) && (sum <= 20)) 
            {
                Console.WriteLine("30");    
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}