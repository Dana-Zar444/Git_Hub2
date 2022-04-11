namespace Project_AP;

public class MyRequestHandler : IRequestHandler
{
    public string HandleRequest(string message, string[] arguments)
    {
        var dummyRequestHandler = new DummyRequestHandler();
        var id = Guid.NewGuid().ToString("D");
        Console.WriteLine($"Было отправлено сообщение '{message}'. Присвоен идентификатор {id}");
        try
        {
            var answer = dummyRequestHandler.HandleRequest(message, arguments);
            Console.WriteLine($"Сообщение с идентификатором {id} получило ответ {answer}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Сообщение с идентификатором {id} упало с ошибкой: {e.Message} ");
        }

        return id;
    }
}