using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Logger
    {
        private static string pathLog = @"d:\MyFolder\C# projects\Epam\Trubin_Vladimir_Task11\Task2\bin\Debug\Logs\Log";
        private static string pathSystem = @"d:\MyFolder\C# projects\Epam\Trubin_Vladimir_Task11\Task2\bin\Debug\System";
        private static string pathLogs = @"d:\MyFolder\C# projects\Epam\Trubin_Vladimir_Task11\Task2\bin\Debug\Logs";
        private static int index;

        

        private void Streaming()
        {
            FileSystemWatcher watch = new FileSystemWatcher();
            watch.Path = pathSystem;
            watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watch.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size | NotifyFilters.DirectoryName;
            watch.Filter = "*.txt";
            watch.IncludeSubdirectories = true;
            watch.Changed += new FileSystemEventHandler(OnChanged);
            watch.Created += new FileSystemEventHandler(OnChanged);
            watch.Deleted += new FileSystemEventHandler(OnChanged);
            watch.Renamed += new RenamedEventHandler(OnRenamed);
            watch.EnableRaisingEvents = true;
        }

        private void Reload(DateTime dateAndTime)
        {
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

        private void CopyDirectory(string begin_dir, string end_dir)
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

        private void OnChanged(object sourse, FileSystemEventArgs e)
        {
            LogCreation();
            Console.WriteLine("File: " + e.Name + " " + e.ChangeType);
        }

        private void OnRenamed(object sourse, RenamedEventArgs e)
        {
            LogCreation();
            Console.WriteLine($"File: {e.OldName} renamed to {e.Name}");
        }

        private void LogCreation()
        {
            DirectoryInfo dir = new DirectoryInfo(pathLog + index);
            dir.Create();
            CopyDirectory(pathSystem, pathLog + index);
            index++;
        }
    }
}
