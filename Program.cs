
using System;
using System.Collections.Generic;
using System.Text.Json;
namespace DeSerialisation
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
        public string SummaryField;
        public IList<DateTimeOffset> DateAvailable { get; set; }
        public Dictionary<string, HighLowTemps> TemperatureRanges { get; set; }
        public string[] SummaryWords { get; set; }
    }
    public class HighLowTemps
    {
        public int High { get; set; }
        public int Low { get; set; }
    }
    public class program
    {
        static void Main(String[] args)
        {
            string jsonString =
            @"{
""Date"": ""2019-08-01T00:00:00-07:00"",
""TemperatureCelsius"": 90,
""Summary"": ""moderate"",
""DatesAvailable"": [
""2019-08-01T00:00:00-07:00"",
""2019-08-02T00:00:00-07:00""
],
""TemperatureRanges"": {
""Cold"": {
""High"": 20,
""Low"": -10
},
""Hot"": {
""High"": 60,
""Low"": 20
}
},
""SummaryWords"": [
""Cool"",
""Wwindy"",
""Humid""
]
}
"; WeatherForecast weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
            Console.WriteLine($"Date : {weatherForecast.Date}");
            Console.WriteLine($"Temperature in Celcius {weatherForecast.TemperatureCelsius}");
            Console.WriteLine($"Summary : {weatherForecast.Summary}");
        }
    }
}


