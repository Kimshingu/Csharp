using System; 

public delegate void EventHandler();

class Program
{
    public static event EventHandler _show;

    static void Main()
    {
        // Add event handlers to Show event. 
        _show += Cat;
        _show += Dog;
        _show += Mouse;
        _show += Mouse;

        // Invoke the event. 
        _show.Invoke();
    }

    static void Cat()
    {
        Console.WriteLine("Cat");
    }

    static void Dog()
    {
        Console.WriteLine("Dog");
    }

    static void Mouse()
    {
        Console.WriteLine("Mouse");
    }
}
