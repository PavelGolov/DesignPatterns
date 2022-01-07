using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.AbstractModules
{
    public abstract class Module
    {
        public string ServiceName { get; set; }
        protected MessageHandler _messageHandler { get; set; }
        protected Module(string serviceName)
        {
            ServiceName = serviceName;
            _messageHandler = new MessageHandler();
        }
    }
}
