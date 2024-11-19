public class Singleton
{
    private static Singleton _instance;
    private Singleton() { }

    public static Singleton instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        
    }

    public void DisplayMessage()
    {
        Console.WriteLine("Singleton Instance");
    }
}

// Code that violates Singleton pattern
public class CorrectedSingletonExample
{
    public static void Main()
    {
        // Incorrect way: New instances can still be created outside the Singleton class
        Singleton singleton2 = Singleton.instance;
        singleton2.DisplayMessage();
        singleton2.DisplayMessage();
    }
}