using DesignPatterns_Labb1.Interfaces;

namespace DesignPatterns_Labb1;

public class MessageEmitter : IMessageObservable
{
    private List<IMessageObserver> _subscribers;

    public MessageEmitter()
    {
        _subscribers = new List<IMessageObserver>();
    }

    public void Subscribe(IMessageObserver observer)
    {
        _subscribers.Add(observer);
    }

    public void Emit(string message)
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Handle(message);
        }
    }
}