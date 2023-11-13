using OberverPattern.Displays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverPattern
{
    public class WeatherStation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Station");
            Console.WriteLine();

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            
            weatherData.SetMeasurements(80, 65, 30.4f);
            Console.WriteLine();
            weatherData.SetMeasurements(87, 70, 29.2f);
            Console.WriteLine();
            weatherData.SetMeasurements(78, 90, 29.2f);
            Console.WriteLine();
        }
    }
}

