using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Truck : Car
    {
        private decimal _capacity { get; set; }
        public Truck(string stateNumber, string manufacturer, decimal capacity)
            : base(stateNumber, manufacturer, "Грузовой автомобиль")
        {
            _capacity = capacity;
        }
        public void SetCapacity(decimal capacity)
        {
            _capacity = capacity;
        }
        public override string GetSubDescription()
        {
            return $"Грузоподъемность: {_capacity.ToString()} кг\n";
        }
    }
}
