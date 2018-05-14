using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IView
    {
        void Streaming();
        void Logging();
        void ViewLogs(string pathLog, int i);
        void Reloading();
        void Exept();
        void OnChanged(object sourse, FileSystemEventArgs e);
        void OnRenamed(object sourse, RenamedEventArgs e);
    }
}
