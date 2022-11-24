using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp {

    public class Rootobject {
        public string publishingOffice { get; set; }
        public DateTime reportDatetime { get; set; }
        public string targetArea { get; set; }
        public string headlineText { get; set; }
        public string text { get; set; }
    }

    public class Rootobject1 {
        public Class1[] Property1 { get; set; }
    }

    public class Class1 {
        public string publishingOffice { get; set; }
        public DateTime reportDatetime { get; set; }
        public Timesery[] timeSeries { get; set; }
        public Tempaverage tempAverage { get; set; }
        public Precipaverage precipAverage { get; set; }
    }

    public class Tempaverage {
        public Area[] areas { get; set; }
    }

    public class Area {
        public Area1 area { get; set; }
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Area1 {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Precipaverage {
        public Area2[] areas { get; set; }
    }

    public class Area2 {
        public Area3 area { get; set; }
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Area3 {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Timesery {
        public DateTime[] timeDefines { get; set; }
        public Area4[] areas { get; set; }
    }

    public class Area4 {
        public Area5 area { get; set; }
        public string[] weatherCodes { get; set; }
        public string[] weathers { get; set; }
        public string[] winds { get; set; }
        public string[] waves { get; set; }
        public string[] pops { get; set; }
        public string[] temps { get; set; }
        public string[] reliabilities { get; set; }
        public string[] tempsMin { get; set; }
        public string[] tempsMinUpper { get; set; }
        public string[] tempsMinLower { get; set; }
        public string[] tempsMax { get; set; }
        public string[] tempsMaxUpper { get; set; }
        public string[] tempsMaxLower { get; set; }
    }

    public class Area5 {
        public string name { get; set; }
        public string code { get; set; }
    }
}
