using _2_Observer.Interfaces;
using System;


namespace _2_Observer.DisplayElements
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
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
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }

    }
}
