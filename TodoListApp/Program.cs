using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;  // JSON işlemleri için, NuGet'ten Newtonsoft.Json paketini ekleyin.

namespace ToDoListApp
{
    class Program
    {
        static string filePath = "todoList.json"; // Görevlerin kaydedileceği dosya

        static void Main(string[] args)
        {
            List<Task> tasks = LoadTasks(); // Görevleri dosyadan yükle
            int choice;

            do
            {
                Console.WriteLine("Yapılacaklar Listesi");
                Console.WriteLine("1. Görev Ekle");
                Console.WriteLine("2. Görevleri Görüntüle");
                Console.WriteLine("3. Görev Tamamla");
                Console.WriteLine("4. Çık");
                Console.Write("Seçiminizi yapın: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTask(tasks);
                        break;
                    case 2:
                        DisplayTasks(tasks);
                        break;
                    case 3:
                        CompleteTask(tasks);
                        break;
                    case 4:
                        Console.WriteLine("Çıkılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, tekrar deneyin.");
                        break;
                }

            } while (choice != 4);
        }

        static void AddTask(List<Task> tasks)
        {
            Console.Write("Yeni görev adı: ");
            string taskName = Console.ReadLine();
            tasks.Add(new Task { Name = taskName, IsCompleted = false });
            SaveTasks(tasks);
        }

        static void DisplayTasks(List<Task> tasks)
        {
            Console.WriteLine("Görevler:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Name} - {(task.IsCompleted ? "Tamamlandı" : "Tamamlanmadı")}");
            }
        }

        static void CompleteTask(List<Task> tasks)
        {
            Console.Write("Tamamlanan görev numarasını girin: ");
            int taskNumber = int.Parse(Console.ReadLine());
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks[taskNumber - 1].IsCompleted = true;
                SaveTasks(tasks);
                Console.WriteLine("Görev tamamlandı.");
            }
            else
            {
                Console.WriteLine("Geçersiz görev numarası.");
            }
        }

        static void SaveTasks(List<Task> tasks)
        {
            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(filePath, json); 
        }

        static List<Task> LoadTasks()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Task>>(json);
            }
            return new List<Task>();
        }
    }

    class Task
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
    }
}
