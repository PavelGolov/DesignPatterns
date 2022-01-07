using Command.AbstractModules;
using Command.Interfaces;
using Command.Modules;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipientModule networkingModule = new NetworkingModule();
            ISenderModule module = new WorkingModule(networkingModule);
            module.Run();
        }
    }
}
