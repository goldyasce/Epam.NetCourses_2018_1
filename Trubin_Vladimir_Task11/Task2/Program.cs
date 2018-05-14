using System;
using System.IO;

namespace Task2
{
    class Program
    {
        private static string pathLog = @"d:\MyFolder\C# projects\Epam\Trubin_Vladimir_Task11\Task2\bin\Debug\Logs\Log";
        private static string pathSystem = @"d:\MyFolder\C# projects\Epam\Trubin_Vladimir_Task11\Task2\bin\Debug\System";
        private static string pathLogs = @"d:\MyFolder\C# projects\Epam\Trubin_Vladimir_Task11\Task2\bin\Debug\Logs";
        private static int index;

        static void Main(string[] args)
        {
            Console.Write("Включить режим набледение? Y\\N: ");
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.WriteLine();
            if (cki.Key == ConsoleKey.Y)
            {
                FileSystemWatcher watch = new FileSystemWatcher();
                watch.Path = pathSystem;
                watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                    | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                watch.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size | NotifyFilters.DirectoryName;
                watch.Filter = "*.txt";
                watch.IncludeSubdirectories = true;
                watch.Changed += new FileSystemEventHandler(OnChanged);
                watch.Created += new FileSystemEventHandler(OnCreated);
                watch.Deleted += new FileSystemEventHandler(OnDeleted);
                watch.Renamed += new RenamedEventHandler(OnRenamed);
                watch.EnableRaisingEvents = true;

            }
            else if (cki.Key == ConsoleKey.N)
            {
                Console.Write("Откатиться на предыдущую верисию? Y\\N");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Y)
                {
                    for (int i = 0; i < Directory.GetDirectories(pathLogs).Length; i++)
                    {
                        Console.WriteLine($"Log{i} date and time: " +
                            $"{Directory.GetCreationTime(pathLog + i)}");
                    }

                    Console.Write("Введите дату и время отката: ");
                    DateTime dateAndTime = DateTime.Parse(Console.ReadLine());
                    for (int i = 0; i < Directory.GetDirectories(pathLogs).Length; i++)
                    {
                        DateTime accessTime = Directory.GetCreationTime(pathLog + i);
                        if (accessTime.Second == dateAndTime.Second)
                        {
                            if (Directory.Exists(pathSystem))
                            {
                                Directory.Delete(pathSystem, true);
                            }
                            DirectoryInfo dir = new DirectoryInfo(pathSystem);
                            dir.Create();
                            CopyDirectory(pathLog + i, pathSystem);
                        }
                    }
                }
                else if(key.Key == ConsoleKey.N)
                {
                    Console.WriteLine("Не выбран ни один режим.");
                }
            }
            

            Console.ReadKey();
        }

        private static void CopyDirectory(string begin_dir, string end_dir)
        {
            DirectoryInfo dir_inf = new DirectoryInfo(begin_dir);
            foreach (DirectoryInfo dir in dir_inf.GetDirectories())
            {
                if (Directory.Exists(end_dir + "\\" + dir.Name) != true)
                {
                    Directory.CreateDirectory(end_dir + "\\" + dir.Name);
                }

                CopyDirectory(dir.FullName, end_dir + "\\" + dir.Name);
            }

            foreach (string file in Directory.GetFiles(begin_dir))
            {
                string filik = file.Substring(file.LastIndexOf('\\'), file.Length - file.LastIndexOf('\\'));
                File.Copy(file, end_dir + "\\" + filik, true);
            }
        }

        private static void OnChanged(object sourse, FileSystemEventArgs e)
        {
            LogCreation();
            Console.WriteLine("File: " + e.Name + " " + e.ChangeType);
        }

        private static void OnCreated(object sourse, FileSystemEventArgs e)
        {
            LogCreation();
            Console.WriteLine("File: " + e.Name + " " + e.ChangeType);
        }

        private static void OnDeleted(object sourse, FileSystemEventArgs e)
        {
            LogCreation();
            Console.WriteLine("File: " + e.Name + " " + e.ChangeType);
        }

        private static void OnRenamed(object sourse, RenamedEventArgs e)
        {
            LogCreation();
            Console.WriteLine($"File: {e.OldName} renamed to {e.Name}");
        }

        private static void LogCreation()
        {
            DirectoryInfo dir = new DirectoryInfo(pathLog + index);
            dir.Create();
            CopyDirectory(pathSystem, pathLog + index);
            index++;
        }
    }
}
