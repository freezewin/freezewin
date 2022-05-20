using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static int[] RandomArray(int length, int min, int max)
        {
            Random random = new Random();

            int[] array = new int [length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(min, max);
            }

            return array;
        }


        static void Main(string[] args)
        {
            int elementCount = 0;
            int answer = 0;
            //bool answerValid;
            int min = 0;
            int max = 0;
            int correct = 0;
            int wrong = 0;
            int fuckups = 0;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("WELCOME TO NUMBER GUESS!!! Rules are simple: just do what you are told to and how to!");

                try
                {
                    System.Threading.Thread.Sleep(3000);
                    Console.Write("\nChoose difficulty(amount of generated numbers(lower number will increase it)): ");
                    elementCount = int.Parse(Console.ReadLine());
                    int[] Myarray = new int[elementCount];

                    Console.Write("Choose minimal number: ");
                    min = int.Parse(Console.ReadLine());

                    Console.Write("Choose maximal number: ");
                    max = int.Parse(Console.ReadLine());

                    for (int i = 0; i < Myarray.Length; i++)
                    {
                        Myarray = RandomArray(elementCount, min, max);
                    }

                    Console.Write("Now try to guess any number: ");
                    answer = int.Parse(Console.ReadLine());

                    for (int i = 0; i < Myarray.Length; i++)
                    {
                        if (Myarray[i] == answer)
                        {
                            //answerValid = true;
                            //Console.WriteLine("You guessed it!");
                            correct++;
                        }
                        else
                        {
                            //Console.WriteLine("You didn't guess it");
                            wrong++;
                        }
                    }

                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine("\nTimes you guessed: " + correct);

                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine("\nTimes you missed: " + wrong);

                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine("\nGenerated numbers are: ");

                    if (elementCount == 0)
                    {
                        Console.WriteLine("None, stoopid");
                    }

                    System.Threading.Thread.Sleep(1000);
                    for (int i = 0; i < Myarray.Length; i++)
                    {
                        Console.WriteLine(Myarray[i]);
                    }
                }
                catch
                {
                    fuckups++;

                    if (fuckups == 1)
                    {
                        System.Threading.Thread.Sleep(2000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("Are you dumb?");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("How did you proceed to fuck up such an easy task?");
                        System.Threading.Thread.Sleep(4000);
                        continue;
                    }

                    if (fuckups == 2)
                    {
                        System.Threading.Thread.Sleep(2000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(2000);
                        Console.Write("Bro");
                        System.Threading.Thread.Sleep(2000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(".");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("How did you manage to make this far in your life being so fucking stoopid?");
                        System.Threading.Thread.Sleep(6000);
                        continue;
                    }

                    if (fuckups == 3)
                    {
                        System.Threading.Thread.Sleep(2000);
                        Console.Write("A");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write("W");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write("W");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine(" BRUH");
                        System.Threading.Thread.Sleep(2000);
                        Console.Write("H");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write("E");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write("L");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write("L");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine(" NAH");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("Get your goofy shit-ass away from me you retarded turdface!");
                        System.Threading.Thread.Sleep(6000);
                        Environment.Exit(0);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
