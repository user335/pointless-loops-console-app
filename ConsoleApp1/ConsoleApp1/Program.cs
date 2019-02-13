using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] stringArray = {
                "one ",
                "two ",
                "three ",
                "four ",
                "five "
            };
            Console.Write("Welcome to pointless loops. It begins. Give me some text: ");
            var answer1 = Console.ReadLine();
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + answer1;
            }
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.WriteLine("Had enough yet?");
                        Console.ReadLine();
            //2
            //while (true)
            //{
            //    Console.WriteLine("Enjoy this infinite loop. Alt + f4 to exit.");
            //}

            //3
            bool booly = false;
            while (booly == false)
            {
                booly = true;
                Console.WriteLine("Have no fear, this is not an infinite loop.");
            }
                        Console.ReadLine();
            //4
            Console.WriteLine("Get looped!");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
                        Console.ReadLine();
            Console.WriteLine("And another!");
            //5
            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
                        Console.ReadLine();
            //6
            List<string> stringList = new List<string>
            {
                "five ",
                "four ",
                "three ",
                "two ",
                "one "
            };
            Console.WriteLine("Now give me some text to search for. I've only got five short strings though so keep it simple");
            Console.Write("search text = ");
            var answer2 =             Console.ReadLine();
            bool foundResult = false;
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Contains(answer2))
                {
                    foundResult = true;
                    Console.WriteLine("Text found in index " + i);
                    break;
                }
                //7
            }
            if (foundResult == false) Console.WriteLine("Your text was not found in the list.");

            Console.WriteLine("Ok, last one I promise");
                        Console.ReadLine();
            //9
            List<string> stringList2 = new List<string>
            {
                "five ",
                "four ",
                "three ",
                "two ",
                "one ",
                "two ",
                "one ",
                "three ",
                "four ",
                "five "
            };
            Console.WriteLine("Try another text to search for and this time we'll return all matches");
            Console.Write("search text = ");
            var answer3 = Console.ReadLine();
            bool foundAnswer3 = false;
            StringBuilder answer3ReplyBuilder = new StringBuilder("Your text was found in indices: ");
            for (int i = 0; i < stringList2.Count; i++)
            {
                if (stringList2[i].Contains(answer3))
                {
                    answer3ReplyBuilder.Append(" " + i);
                    foundAnswer3 = true;
                }                
            }
            if (foundAnswer3) Console.WriteLine(answer3ReplyBuilder);
            //10
            else Console.WriteLine("Your text was not found in the list.");

                        Console.ReadLine();
            Console.WriteLine("For reals this time, last one");
            //11
            List<string> stringList3 = new List<string>
            {
                "five ",
                "four ",
                "two ",
                "one ",
                "three ",
                "four ",
                "five "
            };
            Console.WriteLine("Last thing to do is show you how many repeats are in stringList3.");
            var stringliststorer = new List<string>();
            for (int i = 0; i < stringList3.Count; i++)
            {
                if (stringliststorer.Contains(stringList3[i]) == false)
                {
                    Console.WriteLine("String at index " + i + " = " + stringList3[i] + ", already seen this string = false");
                    stringliststorer.Add(stringList3[i]);
                }
                else
                {
                    Console.WriteLine("String at index " + i + " = " + stringList3[i] + ", already seen this string = true");
                }
            }

            Console.WriteLine("\r\nI believe we're done here.");
                        Console.ReadLine();
        }
    }
}
