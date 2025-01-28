using System;

namespace Basic_Guess_Number
{
    internal class Program
    {
        private const int MaxAttempts = 5;

        static void Main(string[] args)
        {
            Random random = new Random();

            while (true)
            {
                int difficulty = GetDifficultyLevel();
                int maxNumber = GetMaxNumber(difficulty);
                int randomNumber = random.Next(1, maxNumber + 1);
                DateTime startTime = DateTime.Now;

                PlayGame(maxNumber, randomNumber, startTime);

                Console.WriteLine("\nYeniden oynamak ister misiniz? (E/H)");
                if (Console.ReadLine().ToUpper() != "E")
                    break;
            }
        }

        private static int GetDifficultyLevel()
        {
            Console.WriteLine("Zorluk seçin: 1 - Kolay (1-50), 2 - Orta (1-100), 3 - Zor (1-200)");

            while (true)
            {
                Console.Write("Seçiminiz: ");
                if (int.TryParse(Console.ReadLine(), out int difficulty) && difficulty >= 1 && difficulty <= 3)
                    return difficulty;

                Console.WriteLine("Geçersiz giriş! Lütfen 1, 2 veya 3 rakamlarını kullanın.");
            }
        }

        private static int GetMaxNumber(int difficulty)
        {
            return difficulty switch
            {
                1 => 50,
                2 => 100,
                3 => 200,
                _ => 100
            };
        }

        private static void PlayGame(int maxNumber, int randomNumber, DateTime startTime)
        {
            int attempts = 0;
            Console.WriteLine($"\n1 ile {maxNumber} arasında bir sayı tahmin edin!");
            Console.WriteLine("Hazineyi bulmak için 5 deneme hakkınız var!");

            while (attempts < MaxAttempts)
            {
                Console.Write($"\nTahmininiz ({attempts + 1}/{MaxAttempts}): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Lütfen geçerli bir sayı girin.");
                    continue;
                }

                if (guess < 1 || guess > maxNumber)
                {
                    Console.WriteLine($"Lütfen 1 ile {maxNumber} arasında bir sayı girin!");
                    continue;
                }

                attempts++;

                if (CheckGuess(guess, randomNumber, attempts))
                {
                    ShowSuccessMessage(attempts, startTime);
                    return;
                }
            }

            Console.WriteLine($"\nMaalesef bilemediniz. Doğru sayı: {randomNumber}");
        }

        private static bool CheckGuess(int guess, int targetNumber, int attempts)
        {
            if (guess == targetNumber) return true;

            Console.WriteLine(guess < targetNumber
                ? "Daha büyük bir sayı deneyin."
                : "Daha küçük bir sayı deneyin.");

            if (attempts % 3 == 0)
            {
                Console.WriteLine("İpucu: " + (targetNumber % 2 == 0
                    ? "Sayı çifttir."
                    : "Sayı tektir."));
            }

            return false;
        }

        private static void ShowSuccessMessage(int attempts, DateTime startTime)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            string timeInfo = $"{elapsedTime.TotalSeconds:0.0} saniye";

            Console.WriteLine(attempts == 1
                ? $"\nHarika! İlk tahminde bildiniz! ({timeInfo})"
                : $"\nTebrikler! {attempts} denemede ve {timeInfo} sürede bildiniz!");
        }
    }
}