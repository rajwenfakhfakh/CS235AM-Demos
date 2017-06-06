﻿namespace Weather.Rest
{
    public class Forecast
    {
        public string Title { get; set; }
        public string ForecastText { get; set; }

        public override string ToString()
        {
            return Title + "\n" + ForecastText;
        }
    }

    public enum ForecastFormat { json, xml};
}
