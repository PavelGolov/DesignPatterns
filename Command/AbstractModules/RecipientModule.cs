using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.AbstractModules
{
    public abstract class RecipientModule : Module, IRecipientModule
    {
        public RecipientModule(string serviceName)
            : base(serviceName)
        {
        }
        public abstract void SetMessage(string text, int length, Action<string, int> CallbackFunction);
    }
}
