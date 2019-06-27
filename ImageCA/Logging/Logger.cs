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
    public static class Logger
    {
        private static FLogger fLogger;

        static Logger()
        {
            fLogger = new FLogger(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }

        public static void Log(string logText, LogLevel logLevel)
        {
            fLogger.Log(logText, logLevel);
        }

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
