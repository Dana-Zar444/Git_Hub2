using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bars
{
    /// <summary>
    /// Считывает символ с консоли.
    /// </summary>
    class KeyReader 
    {
        /// <summary>
        /// Обработчик нажатия клавиши.
        /// </summary>
        public event EventHandler<char> OnKeyPressed;

        /// <summary>
        /// Считывает введенный в консоли символ в цикле.
        /// </summary>
        public void Run()
        {
            for(;;)
            {
                Console.Write("Введите символ: ");
                var ch = Console.ReadKey();
                if (ch.Key == ConsoleKey.C)
                {
                    break;
                }
                
                OnKeyPressed?.Invoke(this, ch.KeyChar);
            }
        }
    }
}
