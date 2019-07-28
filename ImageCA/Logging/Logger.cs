using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// The different logging levels
/// </summary>
/// <remarks>
/// Logging levels are: Debug, Warn, Error
/// </remarks>
public enum LogLevel : byte
{
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


namespace ImageCA.Logging
{
    /// <summary>
    /// logs log messages to the folder %APP-DATA%/Roaming/ImageCA/logs
    /// </summary>
    public static class Logger
    {
        private static FLogger fLogger;

        static Logger()
        {
            fLogger = new FLogger(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }

        /// <summary>
        /// log a single string
        /// </summary>
        /// <param name="logText">the string to log</param>
        /// <param name="logLevel">log level</param>
        public static void Log(string logText, LogLevel logLevel)
        {
            fLogger.Log(logText, logLevel);
        }

        /// <summary>
        /// log a string array
        /// </summary>
        /// <param name="logText">the string array to log</param>
        /// <param name="logLevel">log level</param>
        public static void Log(string[] logText, LogLevel logLevel)
        {
            fLogger.Log(logText, logLevel);
        }

        /// <summary>
        /// Close the log properly
        /// </summary>
        /// <param name="CloseReason">why the logger is being stopped</param>
        public static void EndLog(string CloseReason)
        {
            fLogger.EndLog(CloseReason);
        }
    }
}
