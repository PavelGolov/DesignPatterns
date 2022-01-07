using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Interfaces
{
    public interface IRecipientModule
    {
        public void SetMessage(string text, int length, Action<string, int> CallbackFunction);
    }
}
