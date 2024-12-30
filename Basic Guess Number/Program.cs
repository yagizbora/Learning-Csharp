using System;

namespace Basic_Guess_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomnumber = random.Next(1, 101);
            int guess;
            int attempts = 0;
            bool isValidInput = false;

            Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin!");

            do
            {
                isValidInput = false;
                Console.Write("Tahmininiz: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    attempts++;
                    isValidInput = true;

                    if (attempts == 5)
                    {
                        Console.WriteLine($"Maalesef bilemediniz, doğru sayı {randomnumber}");
                        break; 
                    }

                    if (guess < randomnumber)
                        Console.WriteLine("Daha büyük bir sayı deneyin.");
                    else if (guess > randomnumber)
                        Console.WriteLine("Daha küçük bir sayı deneyin.");
                    else
                        Console.WriteLine($"Tebrikler! {attempts} tahminde doğru bildiniz.");
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı girin.");
                }

            } while (guess != randomnumber && attempts < 5); 
        }
    }
}
