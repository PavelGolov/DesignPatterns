using Command.AbstractModules;
using Command.Interfaces;
using Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Command.Modules
{
    public class WorkingModule : Module, ISenderModule
    {
        private RecipientModule _addressee { get; set; }
        public WorkingModule(RecipientModule addressee)
            : base("рабочий модуль")
        {
            _addressee = addressee;
        }
        public Message GenerateMessage()
        {
            Random rand = new Random();
            string text = rand.Next().ToString();
            var message = new Message()
            {
                Text = text,
                Length = text.Count(),
                CallbackFunction = SetAnswer,
                Addressee = _addressee
            };

            Console.WriteLine($"Сервис: {ServiceName} Действие: сгенерировано сообщение \"{text}\" для отправки в {_addressee.ServiceName} Время: {DateTime.Now}" );

            return message;
        }

        public void Run()
        {
            var autoEvent = new AutoResetEvent(false);
            Timer timer = new Timer(SendMessageTimerCallback, autoEvent, 2000, 3000);
            autoEvent.WaitOne();
            timer.Dispose();
            Console.ReadLine();
        }

        public void SendMessageTimerCallback(object obj)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)obj;
            autoEvent.Set();
            SendMessage();
        }

        public void SetAnswer(string text, int length)
        {
            Console.WriteLine($"Сервис: {ServiceName} Действие: получен ответ на сообщение \"{text}\" из {_addressee.ServiceName} Дата и время: {DateTime.Now}");
            Run();
        }

        public void SendMessage()
        {
            var message = GenerateMessage();
            Console.WriteLine($"Сервис: {ServiceName} Действие: сообщение \"{message.Text}\" отправлено в {_addressee.ServiceName} Дата и время: {DateTime.Now}");
            _messageHandler.SendMessage(message);
        }
    }
}
