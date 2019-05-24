using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StatsDisplay: IObserver, IDisplay
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200f;
        private float tempSum = 0.0f;
        private int numReadings;
        private WeatherData weatherdata;

        public StatsDisplay(WeatherData weatherData)
        {
            this.weatherdata = weatherData;
            weatherData.RegisterObserver(this);
            
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings++;
            if(temperature > maxTemp)
            {
                maxTemp = temperature;
            }
            if(temperature < minTemp)
            {
                minTemp = temperature;
            }

            Display();

        }
        public void Display()
        {
            Console.WriteLine("avg/Max/Min temperature = {0}/{1}/{2}", (tempSum/numReadings), maxTemp, minTemp);
        }
    }
}
