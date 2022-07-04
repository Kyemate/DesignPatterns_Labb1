using DesignPatterns_Labb1.Interfaces;

namespace DesignPatterns_Labb1;

public static class ObserverFactory
{
    public static MessageEmitter CreateObservable()
    {
        return new MessageEmitter();
    }

    public static IMessageObserver CreateObserver()
    {
        return new PrintingMessageObserver();
    }
}