using Command.AbstractModules;
using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Modules
{
    public class NetworkingModule : RecipientModule
    {
        public NetworkingModule()
            :base("сетевой модуль")
        {
        }
        public override void SetMessage(string text, int length, Action<string, int> CallbackFunction)
        {
            Console.WriteLine($"Сервис: {ServiceName} Действие: сообщение \"{text}\" получено Дата и время: {DateTime.Now}");
            CallbackFunction(text, length);
        }
    }
}
