using DesignPatterns_Labb1.Interfaces;

namespace DesignPatterns_Labb1;

public class ConsolePrintingStrategy : IPrintingStrategy
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}