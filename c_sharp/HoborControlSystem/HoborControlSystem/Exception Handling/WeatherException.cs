using System;

namespace HoborControlSystem.Exception_Handling
{
    public class WeatherException : Exception
    {
        public WeatherException(string message) : base($"{message}") { }

    }

}
