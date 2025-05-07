using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherEditor
{

    [XmlRoot(ElementName = "weather")]
    public class Weather
    {

        [XmlElement(ElementName = "overcast")]
        public Overcast Overcast { get; set; }

        [XmlElement(ElementName = "fog")]
        public Fog Fog { get; set; }

        [XmlElement(ElementName = "rain")]
        public Rain Rain { get; set; }

        [XmlElement(ElementName = "windMagnitude")]
        public WindMagnitude WindMagnitude { get; set; }

        [XmlElement(ElementName = "windDirection")]
        public WindDirection WindDirection { get; set; }

        [XmlElement(ElementName = "snowfall")]
        public Snowfall Snowfall { get; set; }

        [XmlElement(ElementName = "storm")]
        public Storm Storm { get; set; }

        [XmlAttribute(AttributeName = "reset")]
        public int Reset { get; set; }

        [XmlAttribute(AttributeName = "enable")]
        public int Enable { get; set; }
    }

    [XmlRoot(ElementName = "current")]
        public class Current
        {

            [XmlAttribute(AttributeName = "actual")]
            public double Actual { get; set; }

            [XmlAttribute(AttributeName = "time")]
            public int Time { get; set; }

            [XmlAttribute(AttributeName = "duration")]
            public int Duration { get; set; }
        }

        [XmlRoot(ElementName = "limits")]
        public class Limits
        {

            [XmlAttribute(AttributeName = "min")]
            public double Min { get; set; }

            [XmlAttribute(AttributeName = "max")]
            public double Max { get; set; }
        }

        [XmlRoot(ElementName = "timelimits")]
        public class Timelimits
        {

            [XmlAttribute(AttributeName = "min")]
            public int Min { get; set; }

            [XmlAttribute(AttributeName = "max")]
            public int Max { get; set; }
        }

        [XmlRoot(ElementName = "changelimits")]
        public class Changelimits
        {

            [XmlAttribute(AttributeName = "min")]
            public double Min { get; set; }

            [XmlAttribute(AttributeName = "max")]
            public double Max { get; set; }
        }

        [XmlRoot(ElementName = "overcast")]
        public class Overcast
        {

            [XmlElement(ElementName = "current")]
            public Current Current { get; set; }

            [XmlElement(ElementName = "limits")]
            public Limits Limits { get; set; }

            [XmlElement(ElementName = "timelimits")]
            public Timelimits Timelimits { get; set; }

            [XmlElement(ElementName = "changelimits")]
            public Changelimits Changelimits { get; set; }
        }

        [XmlRoot(ElementName = "fog")]
        public class Fog
        {

            [XmlElement(ElementName = "current")]
            public Current Current { get; set; }

            [XmlElement(ElementName = "limits")]
            public Limits Limits { get; set; }

            [XmlElement(ElementName = "timelimits")]
            public Timelimits Timelimits { get; set; }

            [XmlElement(ElementName = "changelimits")]
            public Changelimits Changelimits { get; set; }
        }

        [XmlRoot(ElementName = "thresholds")]
        public class Thresholds
        {

            [XmlAttribute(AttributeName = "min")]
            public double Min { get; set; }

            [XmlAttribute(AttributeName = "max")]
            public double Max { get; set; }

            [XmlAttribute(AttributeName = "end")]
            public int End { get; set; }
        }

        [XmlRoot(ElementName = "rain")]
        public class Rain
        {

            [XmlElement(ElementName = "current")]
            public Current Current { get; set; }

            [XmlElement(ElementName = "limits")]
            public Limits Limits { get; set; }

            [XmlElement(ElementName = "timelimits")]
            public Timelimits Timelimits { get; set; }

            [XmlElement(ElementName = "changelimits")]
            public Changelimits Changelimits { get; set; }

            [XmlElement(ElementName = "thresholds")]
            public Thresholds Thresholds { get; set; }
        }

        [XmlRoot(ElementName = "windMagnitude")]
        public class WindMagnitude
        {

            [XmlElement(ElementName = "current")]
            public Current Current { get; set; }

            [XmlElement(ElementName = "limits")]
            public Limits Limits { get; set; }

            [XmlElement(ElementName = "timelimits")]
            public Timelimits Timelimits { get; set; }

            [XmlElement(ElementName = "changelimits")]
            public Changelimits Changelimits { get; set; }
        }

        [XmlRoot(ElementName = "windDirection")]
        public class WindDirection
        {

            [XmlElement(ElementName = "current")]
            public Current Current { get; set; }

            [XmlElement(ElementName = "limits")]
            public Limits Limits { get; set; }

            [XmlElement(ElementName = "timelimits")]
            public Timelimits Timelimits { get; set; }

            [XmlElement(ElementName = "changelimits")]
            public Changelimits Changelimits { get; set; }
        }

        [XmlRoot(ElementName = "snowfall")]
        public class Snowfall
        {

            [XmlElement(ElementName = "current")]
            public Current Current { get; set; }

            [XmlElement(ElementName = "limits")]
            public Limits Limits { get; set; }

            [XmlElement(ElementName = "timelimits")]
            public Timelimits Timelimits { get; set; }

            [XmlElement(ElementName = "changelimits")]
            public Changelimits Changelimits { get; set; }

            [XmlElement(ElementName = "thresholds")]
            public Thresholds Thresholds { get; set; }
        }

        [XmlRoot(ElementName = "storm")]
        public class Storm
        {

            [XmlAttribute(AttributeName = "density")]
            public double Density { get; set; }

            [XmlAttribute(AttributeName = "threshold")]
            public double Threshold { get; set; }

            [XmlAttribute(AttributeName = "timeout")]
            public int Timeout { get; set; }
        }


}
