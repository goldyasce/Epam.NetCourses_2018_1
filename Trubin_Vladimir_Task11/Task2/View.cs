using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class View : IView
    {
        public void Streaming()
        {
            Console.Write("Включить режим набледение? Y\\N: ");
        }

        public void Logging()
        {
            Console.Write("Откатиться на предыдущую верисию? Y\\N");
        }

        public void ViewLogs(string pathLog, int i)
        {
            Console.WriteLine($"Log{i} date and time: " +
                            $"{Directory.GetCreationTime(pathLog + i)}");
        }

        public void Reloading()
        {
            Console.Write("Введите дату и время отката: ");
        }

        public void Exept()
        {
            Console.WriteLine("Не выбран ни один режим.");
        }

        public void OnChanged(object sourse, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.Name + " " + e.ChangeType);
        }

        public void OnRenamed(object sourse, RenamedEventArgs e)
        {
            Console.WriteLine($"File: {e.OldName} renamed to {e.Name}");
        }

    }
}
