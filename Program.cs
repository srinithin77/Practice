using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Reversestring
    {
        public void reverse()
        {
            string str = "Hello, World!";
            string reversedStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }

            Console.WriteLine(reversedStr);
        }
        public void replaceint()
        {
            int num = 1213232002;
            string str = num.ToString();
            string replace = str.Replace("0", "1");
            int val =int.Parse(replace);
            Console.WriteLine(val);


        }
        public void leafyear()
        {
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {

                Console.WriteLine("leaf Year");
            }
            else
            {
                Console.WriteLine("not Leaf year");
            }
        }
        public void Primenum()

        {
            int flag = 0;
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0) 
                {
                    flag = 1;
                    break;
            
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("not Prime");

            }
            else
            {
                Console.WriteLine(" Prime");

            }

        }
        public void brinaytodecimal()
        {

            int N = int.Parse(Console.ReadLine());

            int a = 1;
            int ans = 0;
            while (N != 0)
            {
                int b = N % 10;
                ans = ans + b * a;
                N = N / 10;
                a = a * 2;
            }
            Console.WriteLine(ans);
        }
        public void maxminequal()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if ((num1 ^ num2) == 0)
            {
                Console.WriteLine($"{num1} and {num2} are equal using bitwise XOR operator.");
            }



            // Find maximum without built-in functions
            int max = num1 - ((num1 - num2) & ((num1 - num2) >> 31));
            // Find minimum without built-in functions
            int min = num2 + ((num1 - num2) & ((num1 - num2) >> 31));

            // Output the results
            Console.WriteLine($"Maximum of {num1} and {num2} is: {max}");
            Console.WriteLine($"Minimum of {num1} and {num2} is: {min}");
        }
        public void listaverage()
        {
            var list = new List<int>() {1,5,6,73,9 };
            int sum = 0;


            foreach (var i in list)
            {
                 sum += i;
            }
            double avrege = (double)sum % list.Count;
            }
        public void arraymax()
        {
            Console.WriteLine("enter array size");
            int Size = int.Parse(Console.ReadLine());
            int[] arr = new int[Size];
            for(int i = 0; i < Size; i++)
            {

                Console.WriteLine("enter the {0} element" + i);
                arr[i] = int.Parse(Console.ReadLine()); 

            
            }
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];

                }
                
            }
            Console.WriteLine(max);
        }
        public void stringcharater()
        {
            string str=Console.ReadLine();
            char sin = char.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (sin == i)
                {
                    count++;
               
                }

            }

        }
        public void palidornestring()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            string result = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                result += str[i];
            }
            if (str == result)
            {
                Console.WriteLine("palidrome");
            }

        }
        public void vovel()
        {
            string value = Console.ReadLine().ToLower();
            int vowelsCount = 0;
            int consonantsCount = 0;
            foreach(char i in value)
            {
                if (char.IsLetter(i))
                {
                    if (vov(i))
                    {
                        vowelsCount++;

                    }
                    else
                    {
                        consonantsCount++;
                    }

                }

            }
            Console.WriteLine($"Number of vowels: {vowelsCount}");
            Console.WriteLine($"Number of consonants: {consonantsCount}");
        }
        public bool vov(char ch)
        {
            ch = char.ToLower(ch); // Convert character to lowercase for case insensitivity

            // Check if character is a vowel
            return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';

        }
    }



    }


