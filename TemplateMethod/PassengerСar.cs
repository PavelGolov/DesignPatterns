using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class PassengerСar : Car
    {
        private decimal _maximumSpeed { get; set; }
        public PassengerСar(string stateNumber, string manufacturer, decimal maximumSpeed)
            : base(stateNumber, manufacturer, "Легковой автомобиль")
        {
            _maximumSpeed = maximumSpeed;
        }
        public void SetMaximumSpeed(decimal maximumSpeed)
        {
            _maximumSpeed = maximumSpeed;
        }
        public override string GetSubDescription()
        {
            return $"Максимальная скорость: {_maximumSpeed.ToString()} км\n";
        }
    }
}
