using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CurrentConditionsDisplay: IObserver, IDisplay
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("current conditions: temperature, {0} degrees farenheit and {1} % humidity", temperature, humidity);
        }

        
    }
}
