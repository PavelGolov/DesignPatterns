using Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Interfaces
{
    public interface ISenderModule
    {
        public void SendMessage();
        public void Run();
    }
}
