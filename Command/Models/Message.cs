using Command.AbstractModules;
using Command.Interfaces;
using Command.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Models
{
    public class Message
    {
        public string Text { get; set; }

        public int Length { get; set; }

        public Action<string,int> CallbackFunction;

        public RecipientModule Addressee { get; set; }
    }
}
