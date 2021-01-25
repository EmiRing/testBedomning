using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace TestBedomningEmil
{
    public class uppgifter
    {
        // Uppgift 2
        public static void GreetUser()
        {
            Console.Clear();
            Console.Write("Hej! Vad heter du i förnamn? ");
            string firstName = Console.ReadLine();
            firstName = firstName.Trim();

            Console.Write("Vad heter du i efternamn? ");
            string lastName = Console.ReadLine();
            lastName = lastName.Trim();

            Console.Write("Hur gammal är du? ");
            string age = Console.ReadLine();
            age = age.Trim();

            Console.WriteLine($"Hej {firstName} {lastName}, {age}år. Välkommen till kursen!");
            Console.ReadKey();
        }

        // Uppgift 3
        public static void ChangeConsoleColor()
        {
            if (Console.ForegroundColor == ConsoleColor.Red)
                Console.ResetColor();
            else
                Console.ForegroundColor = ConsoleColor.Red;
        }

        // Uppgift 4
        public static void DateToday()
        {
            Console.Clear();
            string dateToday = DateTime.Now.ToString("dd'/'MM'-'yyyy"); 
            Console.WriteLine($"Dagens datum är: {dateToday}, och det är en {DateTime.Now.ToString("dddd")}");
            Console.ReadKey();
        }

        // Uppgift 5
        public static void MaxValue()
        {
            Console.Clear();
            int tal1, tal2;
            Console.WriteLine("Skriv två heltal. ");
            Console.Write("Ange första talet: ");
            while (!int.TryParse(Console.ReadLine(), out tal1)) { Console.Write("Ej ett giltigt tal. Skriv ett nytt: "); }
            
            Console.Write("Ange andra talet: ");
            
            while (!int.TryParse(Console.ReadLine(), out tal2)) { Console.Write("Ej ett giltigt tal. Skriv ett nytt: "); }

            Console.WriteLine("Det största av talen är: " + Math.Max(tal1, tal2));
            

            Console.ReadKey();

        }

        // Uppgift 6
        public static void GuessingGame()
        {
            Random rnd = new Random();
            int hemligtTal = rnd.Next(1, 101);
            int counter = 0;
            int guess;
            bool incorrect = true;
            Console.Clear();
            Console.WriteLine("Ett tal mellan 1 och 100 har genererats. Kan du gissa vilket?");

            while (incorrect)
            {
                while(!Int32.TryParse(Console.ReadLine(),out guess))
                {
                    Console.WriteLine("Inget giltigt nummer. Gissa igen!");
                }
                
                if (guess==hemligtTal)
                {
                    Console.WriteLine("Grattis du har gissat rätt!");
                    incorrect = false;
                }
                else if (guess<hemligtTal && guess > 1)
                {
                    Console.WriteLine("Gissa igen, det ska vara högre!");
                    
                }
                else if (guess > hemligtTal && guess < 100)
                {
                    Console.WriteLine("Försök igen, det ska vara lägre!");
                    
                }
                else
                {
                    Console.WriteLine("Felaktig gissning, försök igen");
                }
                counter++;
            }
            if (counter<=5)
                Console.WriteLine("Du behövde endast {0} försök att hitta rätt, Fantastiskt", counter);
            else if(counter <= 10)
                Console.WriteLine("Du behövde {0} försök att hitta rätt, Bra jobbat", counter);
            else
                Console.WriteLine("Du behövde {0} försök att hitta rätt, Bättre lycka nästa gång", counter);

            Console.ReadKey();
        }

        // Uppgift 7
        public static void WriteToFile()
        {
            Console.Clear();
            Console.Write("Skriv en textrad som du vill spara i en fil: ");
            string input = Console.ReadLine();
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "testfile.txt"), input);
            Console.ReadKey();
        }

        // Uppgift 8
        public static void ReadFromFile()
        {
            Console.Clear();

            try
            {
                var data = File.ReadAllText($"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}testfile.txt");
                Console.WriteLine(data);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Filen fanns inte. Du måste skapa en först i uppg 7.");
            }
                                    
            Console.ReadKey();
        }

        // Uppgift 9
        public static void MathOperations()
        {
            Console.Clear();
            Console.Write("Skriv ett decimaltal: ");
            //string input; // = Console.ReadLine();
            double result;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Ej giltigt tal, försök igen: ");
                //input = Console.ReadLine();
            }
            Console.WriteLine($"Roten ur {result} är: {Math.Sqrt(result)},  Kvadraten är { Math.Pow(result, 2)} och upphöjt till 10 blir det { Math.Pow(result, 10)}");
            //Console.WriteLine("Giltigt");
            Console.ReadKey();
        }
        // Uppgift 10
        public static void MultiplicationTable()
        {
            Console.Clear();
            Console.WriteLine("Ettans till tians gångertabeller:");

            for (int i = 1; i<= 10; i++)
            {
                
                for (int j= 1; j<= 10; j++)
                {
                    Console.Write(i*j + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        // Uppgift 11
        public static void SortArray()
        {
            int[] newArray = new int[10];
            Console.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                newArray[i] = rnd.Next(1, 101);
            }

            int[] sortedArray = (int[])newArray.Clone();
            Array.Sort(sortedArray);

            Console.WriteLine("Slumpmässig Array:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(newArray[i] + "\t");

            }

            Console.WriteLine("\nSorterad Array:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(sortedArray[i] + "\t");

            }
            Console.WriteLine();
            Console.ReadKey();
        }

        // Uppgift 12
        public static void Palindrom()
        {
            Console.Clear();
            Console.Write("Ange ett ord: ");
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            string reverseString = new string(array);
            bool result = input.Equals(reverseString, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"Ordet är {(result ? "ett palindrom" : "inte ett palindrom")}");
            Console.ReadKey();

        }

        // Uppgift 13
        public static void CountNumbers()
        {
            Console.Clear();
            bool valid = false;
            int[] number = new int[2];

            while (!valid)
            {
                Console.Write("Ange två tal: ");
                
                string s = Console.ReadLine();
                string[] parts = s.Split(' ', ',', '.');
                
                if (parts.Length == 2)
                { 
                    for (int i= 0; i<parts.Length;i++)
                    {
                        valid = Int32.TryParse(parts[i],out number[i]);
                        if (!valid)
                        {
                            Console.WriteLine("Minst ett av de angivna talen är inte ett giltigt tal.");
                            break;
                        }

                    }
                }
                else
                    Console.WriteLine("Två tal ska skrivas. Ej fler eller färre.");

                Array.Sort(number);
            }

            Console.WriteLine("\nTalen mellan de angivna är:");
            for (int i= number[0]; i<=number[1]; i++)
            {
                Console.Write(i+"  ");
            }
            Console.ReadKey();
        }

        // Uppgift 14
        public static void OddOrEven()
        {
            Console.Clear();
            bool valid = false;
            List<int> number = new List<int>();
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            while (!valid)
            {
                Console.Write("Ange en serie nummer separerat med mellanrum eller komma: ");

                string s = Console.ReadLine();
                s = s.Trim();
                
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);
                s = regex.Replace(s, " ");

                string[] parts = s.Split(' ', ',', '.');

                foreach (var part in parts)
                {
                    valid = Int32.TryParse(part, out int output);
                    if (!valid)
                    {
                        Console.WriteLine("Not valid");
                        number.Clear();
                        break;
                    }
                    
                    number.Add(output);
                }
            }
            number.Sort();
            
            foreach (int num in number)
            {
                if (num % 2 == 0)
                    evens.Add(num);
                else
                    odds.Add(num);
            }
            Console.WriteLine("\nDe jämna talen är:");
            foreach (int even in evens)
                Console.Write(even + "  ");
            Console.WriteLine("\nDe ojämna talen är:");
            foreach (int odd in odds)
                Console.Write(odd + "  ");

            Console.ReadKey();
        }
        
        // Uppgift 15
        public static void AddingNumbers()
        {
            Console.Clear();
            bool valid = false;
            List<int> number = new List<int>();
            int sum = 0;
            
            while (!valid)
            {
                Console.Write("Ange en serie nummer separerat med mellanrum eller komma: ");

                string s = Console.ReadLine();
                s = s.Trim();

                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);
                s = regex.Replace(s, " ");

                string[] parts = s.Split(' ', ',', '.');

                foreach (var part in parts)
                {
                    valid = Int32.TryParse(part, out int output);
                    if (!valid)
                    {
                        Console.WriteLine("Not valid");
                        number.Clear();
                        break;
                    }
                    sum = sum + output;
                    
                }
            }

            Console.WriteLine($"Summan av angivna tal är: {sum}");
            Console.ReadKey();
        }
        
        // Uppgift 16
        public static void MyCharacters()
        {
            Console.Clear();
            Console.Write("Ange din hjältes namn: ");
            string heroName = Console.ReadLine();
            Character hero = new Character(heroName);

            Console.Write("Ange motståndarens namn: ");
            string oppName = Console.ReadLine();
            Character opponent = new Character(oppName);

            Console.WriteLine("\nSlår tärningar...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Din hjältes namn är: {0}", hero.getName());
            Console.WriteLine("Hälsa: {0}", hero.getHealth());
            Console.WriteLine("Styrka: {0}", hero.getStrength());
            Console.WriteLine("Tur: {0}", hero.getluck());

            Console.WriteLine("\nMotståndarens namn är: {0}", opponent.getName());
            Console.WriteLine("Hälsa: {0}", opponent.getHealth());
            Console.WriteLine("Styrka: {0}", opponent.getStrength());
            Console.WriteLine("Tur: {0}", opponent.getluck());
            Console.ReadKey();
        }
    }
}
