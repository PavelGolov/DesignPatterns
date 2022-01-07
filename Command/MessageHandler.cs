using Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class MessageHandler
    {
        public string ServiceName = "обработчик сообщений";
        public MessageHandler()
        {
        }
        public void SendMessage(Message message)
        {
            string text = message.Text;
            int length = message.Length;
            var callbackFunction = message.CallbackFunction;

            Console.WriteLine($"Сервис: {ServiceName} Действие: сообщение \"{text}\" обработано Дата и время: {DateTime.Now}");

            message.Addressee.SetMessage(text, length, callbackFunction);
        }
    }
}
