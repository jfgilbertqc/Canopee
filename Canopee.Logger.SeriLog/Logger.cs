using Serilog;

using ILogger = Canopee.Common.ILogger;

namespace Canopee.Logger.SeriLog
{
    public class Logger : ILogger
    {
        public void LogDebug(string message) => Log.Information(message);

        public void LogError(string message) => Log.Error(message);

        public void LogInfo(string message) => Log.Information(message);

        public void LogWarning(string message) => Log.Warning(message);
    }
}