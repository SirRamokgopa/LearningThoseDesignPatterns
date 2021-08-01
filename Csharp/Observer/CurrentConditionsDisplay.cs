using System;

namespace Observer
{
    public class CurrentConditionsDisplay : WeatherObserver, DisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherSubject weatherData;

        public CurrentConditionsDisplay(WeatherSubject weatherData) {
            // Pass the weatherSubject object to this display
            this.weatherData = weatherData;
            // Subscribe to the weather data
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        public void display() {
            Console.WriteLine($"Current conditions:\nTemperature\t{temperature} deg.\nHumidity\t{humidity}%\n");
        }
    }
}