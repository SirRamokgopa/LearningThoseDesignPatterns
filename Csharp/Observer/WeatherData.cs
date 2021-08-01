using System;
using System.Collections;


namespace Observer {
    public class WeatherData : WeatherSubject {
        // Instance variable declarations
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        // Constructor
        public WeatherData() {
            observers = new ArrayList();
        }

        // Handling subsciptions
        public void registerObserver(WeatherObserver observer) { 
            observers.Add(observer);
        }
        public void removeObserver(WeatherObserver observer) {
            observers.Remove(observer);
        }
        public void notifyObservers() { 
            foreach (WeatherObserver observer in observers) {
                observer.update(temperature, humidity, pressure);
            }
        }

        private float getTemperature() {
            return temperature;
        }
        private float getHumidity() {
            return humidity;
        }
        private float getPressure() {
            return humidity;
        }

        // Notify observers
        public void measurmentsChanged() {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            measurmentsChanged();
        }

        /*
         * Later on, I can add actual weather data to this
         */
    }
}