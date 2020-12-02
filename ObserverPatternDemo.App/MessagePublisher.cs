using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo.App
{
    public class MessagePublisher
    {

        private Dictionary<string,Action<string>> subscribers;
        private static object lockObject = new object();
        private static MessagePublisher messagePublisher;
        private MessagePublisher()
        {
            subscribers = new Dictionary<string, Action<string>>();
        }
        public static MessagePublisher GetMessagePublisher()
        {
            lock (lockObject)
            {
                if (messagePublisher is null)
                {
                    messagePublisher = new MessagePublisher();
                }
                return messagePublisher;
            }
        }


        public void Subscribe(string subscriberId, Action<string> subscriberAction)
        {
            this.subscribers.Add(subscriberId, subscriberAction);
            subscriberAction("Subscribed to the publisher");
        }

        public void UnSubscribe(string subscriberId)
        {

            var subscriberAction = subscribers[subscriberId];
            this.subscribers.Remove(subscriberId);
            subscriberAction("UnSubscribed from the publisher");
        }

        public void PublishMessage(string message)
        {
            foreach (var subcriber in subscribers)
            {
                subcriber.Value(message);
            }
        }

    }
}
