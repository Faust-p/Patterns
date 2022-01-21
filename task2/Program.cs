using System;
using task2.Publisher;
using task2.Subscriber;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather weatherdata = new Weather();
            CurrentDisplay display1 = new CurrentDisplay();
            StatisticsDisplay display2 = new StatisticsDisplay();
            weatherdata.AddSubscriber(display1);
            weatherdata.AddSubscriber(display2);
            weatherdata.NotifySubscriber();
            Console.ReadKey();
        }
    }
}
