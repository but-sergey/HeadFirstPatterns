﻿namespace _2_Observer.Interfaces
{
    public interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
