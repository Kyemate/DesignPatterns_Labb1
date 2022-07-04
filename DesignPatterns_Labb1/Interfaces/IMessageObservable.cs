namespace DesignPatterns_Labb1.Interfaces;

public interface IMessageObservable
{
    void Subscribe(IMessageObserver observer);
}