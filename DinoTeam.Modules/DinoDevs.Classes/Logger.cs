using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDevs.Classes
{
    public class Logger
    {
        public string LogLevel { get; set; }
        public DateTime? Time { get; set; }
        public string LogFrom { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string More { get; set; }

        public Logger() {}
        public Logger(string logLevel = "", string logFrom = "",
            string controllerName = "", string actionName = "", string more = "")
        {
            this.LogLevel = logLevel;
            this.Time = DateTime.Now;
            this.LogFrom = LogFrom;
            this.ControllerName = controllerName;
            this.ActionName = actionName;
            this.More = more;
        }

        public string Print()
        {
            return "[" + Time + "]" + "[" + LogLevel + "]" + "[From controller:" +
                " " + ControllerName + ", action: " + ActionName + "]"
                + More + "\n";
        }
    }
}
