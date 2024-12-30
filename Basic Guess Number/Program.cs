using System;

namespace Basic_Guess_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startTime = DateTime.Now;

            Random random = new Random();
            Console.WriteLine("Zorluk seçin: 1 - Kolay, 2 - Orta, 3 - Zor");
            int difficulty = int.Parse(Console.ReadLine());
            int range = difficulty == 1 ? 50 : difficulty == 2 ? 100 : 200;
            int randomnumber = random.Next(1, range + 1);
            int guess;
            int attempts = 0;
            bool isValidInput = false;
            Console.WriteLine("Bir hazineyi bulmaya çalışıyorsunuz! Doğru sayıyı tahmin edebilir misiniz?");
            Console.WriteLine($"1 ile {(difficulty == 1 ? 50 : difficulty == 2 ? 100 : 200)} arasında bir sayı tahmin edin!");

            do
            {
                isValidInput = false;
                Console.Write("Tahmininiz: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    attempts++;
                    isValidInput = true;

                    if (attempts == 5 && guess != randomnumber)
                    {
                        Console.WriteLine($"Maalesef bilemediniz, doğru sayı {randomnumber}");
                        break; 
                    }

                    if (guess != randomnumber)
                    {
                        int difference = Math.Abs(randomnumber - guess);
                        Console.WriteLine($"Tahmininiz bu kadar sayı uzaklıkta: {difference}");
                        if (guess < randomnumber)
                            Console.WriteLine("Daha büyük bir sayı deneyin.");
                        if (attempts % 3 == 0)
                        {
                            Console.WriteLine("İpucu: Sayı çift mi, tek mi?");
                            Console.WriteLine(randomnumber % 2 == 0 ? "Sayı çifttir." : "Sayı tektir.");
                        }
                        else if (guess > randomnumber)
                            Console.WriteLine("Daha küçük bir sayı deneyin.");
                    }
                    else if (attempts == 1)
                    {
                        Console.WriteLine($"Harika! İlk tahminde doğru bildiniz.");
                    }
                    else
                    {
                        var elapsedtime = DateTime.Now - startTime;
                        Console.WriteLine($"Tebrikler! {attempts} tahmininde ve {elapsedtime} kadar saniyede doğru bildiniz.");
                    }

                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı girin.");
                }

            } while (guess != randomnumber && attempts < 5); 
        }
    }
}
