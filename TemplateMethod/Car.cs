using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Car
    {
        private readonly string _typeCar;
        private string _stateNumber { get; set; }
        private string _manufacturer { get; set; }
        public Car(string stateNumber, string manufacturer, string typeCar)
        {
            _stateNumber = stateNumber;
            _manufacturer = manufacturer;
            _typeCar = typeCar;
        }
        public void SetStateNumber(string stateNumber)
        {
            _stateNumber = stateNumber;
        }
        public void SetManufacturer(string manufacturer)
        {
            _manufacturer = manufacturer;
        }
        public string GetDescription()
        {
            return $"{_typeCar}\nГосномер: {_stateNumber}\nПроизводитель: {_manufacturer}\n{GetSubDescription()}";
        }
        public abstract string GetSubDescription();
    }
}
