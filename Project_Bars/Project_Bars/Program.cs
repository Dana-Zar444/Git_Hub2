using System;

namespace Project_Bars
{
    class Program
    {
        static void Main(string[] args)
        {
            var charWriter = new KeyReader();
            charWriter.OnKeyPressed += (sender, ch) => Console.WriteLine("\n" + ch);
            charWriter.Run();
        }
    }
}
