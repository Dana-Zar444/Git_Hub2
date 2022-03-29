using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class LocalFileLogger<T> : ILogger
    {
        private string _path;

        public LocalFileLogger(string path) => _path = path;

        public void LogError(string message, Exception ex)
            => File.AppendAllText(_path, $"[Error]: [{typeof(T).Name}] : {message}.{ex.Message}\n");

        public void LogInfo(string message)
            => File.AppendAllText(_path, $"[Info]: [{typeof(T).Name}] : {message}\n");

        public void LogWarning(string message)
            => File.AppendAllText(_path, $"[Warning]: [{typeof(T).Name}] : {message}\n");
    }
}
