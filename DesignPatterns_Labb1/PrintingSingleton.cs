using DesignPatterns_Labb1.Interfaces;

namespace DesignPatterns_Labb1;


public static class PrintingSingleton
{
    public static IPrintingStrategy Instance { get; }

    static PrintingSingleton()
    {
        Instance = new ConsolePrintingStrategy();
    }
}