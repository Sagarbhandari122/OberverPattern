using OberverPattern;
using OberverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverPattern
{
    public class WeatherData : ISubject
    {
        
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private List<IObserver> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }

        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observers != null && _observers.Count() > 0)
            {
                _observers.Remove(observer);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }
    }
}
