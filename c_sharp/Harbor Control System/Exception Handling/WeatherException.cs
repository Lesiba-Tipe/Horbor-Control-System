using System;

namespace Harbor_Control_System.Exception_Handling
{
    //public class WeatherException : [System.Serializable]
    public class WeatherException : Exception
    {
        public WeatherException(string message) : base($"{message} is testing Exception") { }

    }

}
