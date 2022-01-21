using System;
using task2.Subscriber;

namespace task2.Publisher
{
    public interface IPublisher
    {
        void AddSubscriber(ISubscriber subscriber);
        void DeleteSubscriber(ISubscriber subscriber);
    }
}
