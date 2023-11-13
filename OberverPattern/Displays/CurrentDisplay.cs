using OberverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverPattern.Displays
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions : " + _temperature + "F degrees and  " + _humidity + "% humidity.");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            Display();
        }
    }
}
