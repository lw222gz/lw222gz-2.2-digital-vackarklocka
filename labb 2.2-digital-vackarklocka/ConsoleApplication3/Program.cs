using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test 1
            AlarmClock test1 = new AlarmClock();
            ViewTestHeader("Test 1: test utav standardkonstruktorn.\n");
            Console.WriteLine(test1.ToString());

            //Test 2
            AlarmClock test2 = new AlarmClock(9, 42);
            ViewTestHeader("Test 2: test utav konstruktorn med 2 parametrar.\n");
            Console.WriteLine(test2.ToString());
             
            //Test 3
            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("Test 3: test utav konstruktorn med 4 parametrar.\n");
            Console.WriteLine(test3.ToString());

            //Test 4
            AlarmClock test4 = new AlarmClock(23, 58, 7, 35);
            ViewTestHeader("Test 4: test utav TickTock Metoden så att klockan går 13 minuter.\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║ Väckarklocka, en vacker uppfinning som alla hatar på måndag. ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝ ");
            Console.ResetColor();
            Run(test4, 13);
            
            //Test 5
            AlarmClock test5 = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader("Test 5: test så av alarmet\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║ Väckarklocka, en vacker uppfinning som alla hatar på måndag. ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝ ");
            Console.ResetColor();  
            Run(test5, 6);

            //Test 6
            AlarmClock test6 = new AlarmClock();
            ViewTestHeader("Test 6: test så att man inte kan ange för höga variabler.\n");
            

            try
            {
                test6.Hour = 45;
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }

            try
            {
                test6.Minute = 70;
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }

            try
            {
                test6.AlarmHour = 42;
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }
            try
            {
                test6.AlarmMinute = 70;
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }
                
            //Test 7
            ViewTestHeader("Test 7: test som kollar så att när tid/ alarmtid blir tilldelade felaktiga värden.\n");
            try
            {
                AlarmClock test7 = new AlarmClock(42, 0);
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }
            try
            {
                AlarmClock test7 = new AlarmClock(0, 0, 42, 0);
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }
        }

        //metoder
        static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; minutes > i; ++i)
            {
                if (ac.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("♫");
                    Console.WriteLine(ac.ToString() + "Tjut tjut tjut!");
                }
                else
                {
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.WriteLine(ac.ToString());
                }
            }
        }

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine();
            Console.WriteLine(Line);
            Console.WriteLine(header);
        }

        private static string Line = "-------------------------------------------------------------";
    }
}
