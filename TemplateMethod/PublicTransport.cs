using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class PublicTransport : Car
    {
        private int _capacity { get; set; }
        public PublicTransport(string stateNumber, string manufacturer, int capacity)
            : base(stateNumber, manufacturer, "Общественный транспорт")
        {
            _capacity = capacity;
        }
        public void SetCapacity(int capacity)
        {
            _capacity = capacity;
        }
        public override string GetSubDescription()
        {
            return $"Вместимость: {_capacity.ToString()} человек\n";
        }
    }
}
