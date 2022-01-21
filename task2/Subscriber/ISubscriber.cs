using System;

namespace task2.Subscriber
{
    public interface ISubscriber
    {
        void Update(double temperature, double humidity, double pressure);
    }
}
