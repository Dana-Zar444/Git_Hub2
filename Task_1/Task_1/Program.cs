using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "output.txt";

            var exception = new ArgumentException("*Exception*");

            LocalFileLoggerTest.TestLogging<MyClass>(path, "*Message*", exception);
            LocalFileLoggerTest.TestLogging<MyStruct>(path, "*Message*", exception);
            LocalFileLoggerTest.TestLogging<MyEnum>(path, "*Message*", exception);
        }
    }
}
