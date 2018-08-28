using NLog;

namespace WebDriverOnCore.LoggerManager
{
    public static class NLogManager
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public static Logger LogMessage { get => _logger; }
    }
}
