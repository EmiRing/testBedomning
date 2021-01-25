using System;

namespace TestBedomningEmil
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems =
            {
                "1: Säg hej till världen!",
                "2: Ange namn",
                "3: Färgändring av konsol",
                "4: Dagens datum",
                "5: Vilket är störst? ",
                "6: Gissa talet.",
                "7: Spara en fil",
                "8: Läsa från en fil",
                "9: Matematiska operationer",
                "10: Multiplikationstabeller",
                "11: Sortera en array.",
                "12: Palindrom",
                "13: Räkna tal",
                "14: Jämna och ojämna tal",
                "15: Summera tal",
                "16: Skapa karaktärer",
                "0: Avsluta "

            };

            do
            {
                Console.Clear();
                Console.WriteLine("Meny");
                foreach (string item in menuItems)
                {
                    Console.WriteLine(item);
                }
                
                Console.Write("\nAnge ditt val: ");

                switch(Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Hello World!");
                        Console.ReadKey();
                        break;
                    case "2":
                        uppgifter.GreetUser();
                        break;
                    case "3":
                        uppgifter.ChangeConsoleColor();
                        break;
                    case "4":
                        uppgifter.DateToday();
                        break;
                    case "5":
                        uppgifter.MaxValue();
                        break;
                    case "6":
                        uppgifter.GuessingGame();
                        break;
                    case "7":
                        uppgifter.WriteToFile();
                        break;
                    case "8":
                        uppgifter.ReadFromFile();
                        break;
                    case "9":
                        uppgifter.MathOperations();
                        break;
                    case "10":
                        uppgifter.MultiplicationTable();
                        break;
                    case "11":
                        uppgifter.SortArray();
                        break;
                    case "12":
                        uppgifter.Palindrom();
                        break;
                    case "13":
                        uppgifter.CountNumbers();
                        break;
                    case "14":
                        uppgifter.OddOrEven();
                        break;
                    case "15":
                        uppgifter.AddingNumbers();
                        break;
                    case "16":
                        uppgifter.MyCharacters();
                        break;
                    case "0":
                        Environment.Exit(0);
                        continue;
                    default:
                        Console.WriteLine("Felaktig inmatning.");
                        Console.ReadKey();
                        break;
                }

            } while (true);
        }
    }
}
