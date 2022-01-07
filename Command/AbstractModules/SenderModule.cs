using Command.Interfaces;
using Command.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.AbstractModules
{
    public abstract class SenderModule : Module, ISenderModule
    {
        public SenderModule(string serviceName)
            : base(serviceName)
        {
        }

        public abstract void SendMessage();
        public abstract void Run();
    }
}