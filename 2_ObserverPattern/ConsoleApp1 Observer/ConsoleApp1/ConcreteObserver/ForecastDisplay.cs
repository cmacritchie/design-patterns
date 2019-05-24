using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ForecastDisplay: IObserver, IDisplay
    {
        private float currentPRessure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void RemoveSubscription()
        {
            weatherData.RemoveObserver(this);
            Console.WriteLine("forecast removed");
        }

        public void Display()
        {
            if(currentPRessure > lastPressure)
            {
                Console.WriteLine("Imrpoving weather on the way");
            } else if (currentPRessure == lastPressure)
            {
                Console.WriteLine("More of the same");
            } else if (currentPRessure < lastPressure )
            {
                Console.WriteLine("watch out for cooler, rainy weather");
            }
            
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPRessure;
            currentPRessure = pressure;
            Display();
        }
    }
}
