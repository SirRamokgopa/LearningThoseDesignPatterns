namespace Observer
{
    public class StatisticsDisplay : WeatherObserver, DisplayElement {
        WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData) {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure) {}
        public void display() {}
    }
}