using DesignPatterns_Labb1.Interfaces;

namespace DesignPatterns_Labb1;

public class PrintingMessageObserver : IMessageObserver
{
    public void Handle(string message)
    {
        PrintingSingleton.Instance.Print(message);
    }
}