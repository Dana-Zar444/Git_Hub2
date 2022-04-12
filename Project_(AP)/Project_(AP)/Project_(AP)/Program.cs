namespace Project_AP;

class Program
{
    private const string ExitCommand = "/exit";
    private const string EndCommand = "/end";
        
    public static void Main(string[] args)
    {
        string? exit = null;
        var handler = new MyRequestHandler();
            
        Console.WriteLine("Приложение запущено");

        while (exit != ExitCommand)
        {
            Run(handler);
            Console.WriteLine($"Для продолжения нажмите 'enter'. " +
                              $"Для выхода введите {ExitCommand}");
            exit = Console.ReadLine();
        }
            
        Console.WriteLine("Приложение завершает работу.");
    }

    private static void Run(IRequestHandler handler)
    {
        Console.WriteLine("Введите текст запроса для отправки.");
        var message = Console.ReadLine();
            
        Console.WriteLine($"Введите аргументы сообщения через пробел. " +
                          $"Если аргументы не нужны, введите {EndCommand}");
            
        var arguments = Console.ReadLine()?.Split(" ");

        if (arguments != null && arguments.Contains(EndCommand))
        {
            arguments = Array.Empty<string>();
        }
            
        ThreadPool.QueueUserWorkItem(callBack => handler.HandleRequest(message, arguments));
    }
}