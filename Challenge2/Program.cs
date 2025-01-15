using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

public class EventSubscriber
{
    // Event handler method
    public void OnMyEventOccurred(object sender, MyEventArgs e)
    {
        Console.WriteLine($"Event received: {e.Message}");
    }
}

public class MyEventArgs : EventArgs
{
    public string Message { get; }

    // Constructor to initialize the Message
    public MyEventArgs(string message)
    {
        Message = message;
    }
}