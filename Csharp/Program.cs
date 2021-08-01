using System;
using Stratergy;
using Observer;

namespace Csharp
{
    public class Program
    {
        public static void Main()
        {
            // For the observer pattern
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData);
            // ForecastDisplay forecast = new ForecastDisplay(weatherData);
            // StatisticsDisplay stats = new StatisticsDisplay(weatherData);
            
            weatherData.setMeasurements(25, 66, 30.0f);
            weatherData.setMeasurements(19, 40, 27.0f);
            weatherData.setMeasurements(20, 60, 33.0f);


            // For the stratergy pattern
            /*
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehaviour(new FlyRocketPowered());
            model.performFly();
            */
        }
    }
}
