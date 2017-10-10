using System;
using System.Linq;
using System.Collections;

namespace CodingChallengesCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
        }

        public static int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == target - nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("No two sum solution");
        }

        public static int[] ReverseArray(int[] array)
        {
            //easy way
            var reversedArray = array.Reverse();
            //hard way
            for (int i = 0; i < 5; i++)
            {
                var number = array[i];
                array[i] = array[array.Length -1 - i];
                array[array.Length-1-i] = number;
            }
            return array;
        }

        public static void BinaryTrianglePrint(int number)
        {
            int lastInt = 0;
            for (int i = 0; i < number+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (lastInt == 0)
                    {
                        Console.Write(1);
                        lastInt = 1;
                    }
                    else if (lastInt == 1)
                    {
                        Console.Write(0);
                        lastInt = 0;
                    }
                    
                }
                Console.Write("\n");
            }

            //or set number 1/0 if 1 make 0 if 0 make 1, print number of times... 
            Console.ReadKey();
        }

        public static void DivisonCalcUsingExceptions()
        {
            
            try
            {
                Console.WriteLine("Enter the first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(firstNumber/secondNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
               
            }
           

            Console.ReadKey();

        }

        public static void FizzBuzzBang()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("fizz");
                    
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    
                }
                if (i % 7 == 0)
                {
                    Console.Write("Bang");
                    
                }
                if (i % 3 != 0 || i % 5 != 0 || i % 7 != 0)
                {
                    Console.Write(i);
                }
                Console.Write("\n");

                
            }
            Console.ReadKey();
        }

        public static void StackTest()
        {
            Stack stack = new Stack();
            stack.Push("Hey");
            stack.Push("You");
            Console.WriteLine(stack.Pop());
            Console.ReadKey();
        }
    }
}

