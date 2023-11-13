using OberverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverPattern.Displays
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private ISubject _weatherData;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine(String.Format("Avg/Min/Max temperature = {0}/{1}/{2}", _temperature - 1, _temperature, _temperature + 1));
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;

            Display();
        }
    }
}
