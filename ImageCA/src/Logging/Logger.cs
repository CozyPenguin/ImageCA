using System;

namespace ImageCA {

    /// <summary>
    /// The different logging levels
    /// </summary>
    /// <remarks>
    /// Logging levels are: Debug, Warn, Error
    /// </remarks>
    public enum LogLevel : byte {
        /// <summary>
        /// Info Level
        /// </summary>
        Info,
        /// <summary>
        /// Debug Level
        /// </summary>
        Debug,
        /// <summary>
        /// Warn Level
        /// </summary>
        Warn,
        /// <summary>
        /// Error Level
        /// </summary>
        Error
    }

    /// <summary>
    /// logs log messages to %APP-DATA%/Roaming/ImageCA/logs
    /// </summary>
    public static class Debug {

        /// <summary>
        /// log a single string
        /// </summary>
        /// <param name="logText">the string to log</param>
        /// <param name="logLevel">log level</param>
        public static void Log (string logText, LogLevel logLevel) {
            Console.Write ("[" + DateTime.Now.ToLongTimeString () + "] ");
            switch (logLevel) {
                case LogLevel.Debug:
                    Console.Write ("[Debug] ");
                    break;
                case LogLevel.Info:
                    Console.Write ("[Info] ");
                    break;
                case LogLevel.Warn:
                    Console.Write ("[Warn] ");
                    break;
                case LogLevel.Error:
                    Console.Write ("[Error] ");
                    break;
            }
            Console.WriteLine (logText);
        }

        /// <summary>
        /// log a string array
        /// </summary>
        /// <param name="logText">the string array to log</param>
        /// <param name="logLevel">log level</param>
        public static void Log (string[] logText, LogLevel logLevel) {
            Console.Write ("[" + DateTime.Now.ToLongTimeString () + "] ");
            foreach (string textPart in logText) {
                switch (logLevel) {
                    case LogLevel.Debug:
                        Console.Write ("[Debug] ");
                        break;
                    case LogLevel.Warn:
                        Console.Write ("[Warn] ");
                        break;
                    case LogLevel.Error:
                        Console.Write ("[Error] ");
                        break;
                }
                Console.WriteLine (textPart);
            }
        }
    }
}