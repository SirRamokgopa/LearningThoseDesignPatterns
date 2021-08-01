namespace Observer
{
    public class ForecastDisplay : WeatherObserver, DisplayElement {
        WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData) {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure) {}
        public void display() {}
    }
}