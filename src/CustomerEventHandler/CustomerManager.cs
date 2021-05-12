using System;
using System.Threading.Tasks;
using Pitstop.Infrastructure.Messaging;

namespace CustomerEventHandler
{
    public class CustomerManager : IMessageHandlerCallback
    {
        IMessageHandler _messageHandler;
        public CustomerManager(IMessageHandler messageHandler)
        {
            _messageHandler = messageHandler;
        }
        public Task<bool> HandleMessageAsync(string type, string msg)
        {
            CustomerRegistered cust = new CustomerRegistered("ap1",msg);
            return null;
        }

    }
}