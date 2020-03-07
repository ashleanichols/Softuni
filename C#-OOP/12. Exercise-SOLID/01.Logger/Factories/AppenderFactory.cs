﻿namespace Logger.Factories
{    
    using System;
    using Appenders;
    using Enums;
    using Layouts;
    using Loggers;

    public static class AppenderFactory
    {
        public static IAppender CreateAppender(string type, ILayout layout, ReportLevel reportLevel)
        {
            type = type.ToLower();

            switch (type)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout) { ReportLevel = reportLevel };
                case "fileappender":
                    return new FileAppender(layout, new LogFile()) { ReportLevel = reportLevel };
                default:
                    throw new ArgumentException("Invalid Appender Type!");
            }
        }
    }
}
