[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/castleproject/Core")]
[assembly: System.Runtime.InteropServices.ComVisible(false)]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v7.0", FrameworkDisplayName=".NET 7.0")]
namespace Castle.Services.Logging.NLogIntegration
{
    public class ExtendedNLogFactory : Castle.Core.Logging.AbstractExtendedLoggerFactory
    {
        public ExtendedNLogFactory() { }
        public ExtendedNLogFactory(NLog.Config.LoggingConfiguration loggingConfiguration) { }
        public ExtendedNLogFactory(bool configuredExternally) { }
        public ExtendedNLogFactory(string configFile) { }
        public override Castle.Core.Logging.IExtendedLogger Create(string name) { }
        public override Castle.Core.Logging.IExtendedLogger Create(string name, Castle.Core.Logging.LoggerLevel level) { }
    }
    public class ExtendedNLogLogger : Castle.Services.Logging.NLogIntegration.NLogLogger, Castle.Core.Logging.IExtendedLogger, Castle.Core.Logging.ILogger
    {
        public ExtendedNLogLogger(NLog.Logger logger, Castle.Services.Logging.NLogIntegration.ExtendedNLogFactory factory) { }
        public Castle.Core.Logging.IContextProperties GlobalProperties { get; }
        public Castle.Core.Logging.IContextProperties ThreadProperties { get; }
        public Castle.Core.Logging.IContextStacks ThreadStacks { get; }
        protected new Castle.Services.Logging.NLogIntegration.ExtendedNLogFactory Factory { get; set; }
        public override Castle.Core.Logging.ILogger CreateChildLogger(string name) { }
        public Castle.Core.Logging.IExtendedLogger CreateExtendedChildLogger(string name) { }
    }
    public class GlobalContextProperties : Castle.Core.Logging.IContextProperties
    {
        public GlobalContextProperties() { }
        public object this[string key] { get; set; }
    }
    public class NLogFactory : Castle.Core.Logging.AbstractLoggerFactory
    {
        public NLogFactory() { }
        public NLogFactory(NLog.Config.LoggingConfiguration loggingConfiguration) { }
        public NLogFactory(bool configuredExternally) { }
        public NLogFactory(string configFile) { }
        public override Castle.Core.Logging.ILogger Create(string name) { }
        public override Castle.Core.Logging.ILogger Create(string name, Castle.Core.Logging.LoggerLevel level) { }
    }
    public class NLogLogger : Castle.Core.Logging.ILogger
    {
        public NLogLogger(NLog.Logger logger, Castle.Services.Logging.NLogIntegration.NLogFactory factory) { }
        protected Castle.Services.Logging.NLogIntegration.NLogFactory Factory { get; set; }
        public bool IsDebugEnabled { get; }
        public bool IsErrorEnabled { get; }
        public bool IsFatalEnabled { get; }
        public bool IsInfoEnabled { get; }
        public bool IsTraceEnabled { get; }
        public bool IsWarnEnabled { get; }
        protected NLog.Logger Logger { get; set; }
        public virtual Castle.Core.Logging.ILogger CreateChildLogger(string name) { }
        public void Debug(System.Func<string> messageFactory) { }
        public void Debug(string message) { }
        public void Debug(string message, System.Exception exception) { }
        public void DebugFormat(string format, params object[] args) { }
        public void DebugFormat(System.Exception exception, string format, params object[] args) { }
        public void DebugFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void DebugFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Error(System.Func<string> messageFactory) { }
        public void Error(string message) { }
        public void Error(string message, System.Exception exception) { }
        public void ErrorFormat(string format, params object[] args) { }
        public void ErrorFormat(System.Exception exception, string format, params object[] args) { }
        public void ErrorFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void ErrorFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Fatal(System.Func<string> messageFactory) { }
        public void Fatal(string message) { }
        public void Fatal(string message, System.Exception exception) { }
        public void FatalFormat(string format, params object[] args) { }
        public void FatalFormat(System.Exception exception, string format, params object[] args) { }
        public void FatalFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void FatalFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Info(System.Func<string> messageFactory) { }
        public void Info(string message) { }
        public void Info(string message, System.Exception exception) { }
        public void InfoFormat(string format, params object[] args) { }
        public void InfoFormat(System.Exception exception, string format, params object[] args) { }
        public void InfoFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void InfoFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public override string ToString() { }
        public void Trace(System.Func<string> messageFactory) { }
        public void Trace(string message) { }
        public void Trace(string message, System.Exception exception) { }
        public void TraceFormat(string format, params object[] args) { }
        public void TraceFormat(System.Exception exception, string format, params object[] args) { }
        public void TraceFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void TraceFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Warn(System.Func<string> messageFactory) { }
        public void Warn(string message) { }
        public void Warn(string message, System.Exception exception) { }
        public void WarnFormat(string format, params object[] args) { }
        public void WarnFormat(System.Exception exception, string format, params object[] args) { }
        public void WarnFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void WarnFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
    }
    public class ThreadContextProperties : Castle.Core.Logging.IContextProperties
    {
        public ThreadContextProperties() { }
        public object this[string key] { get; set; }
    }
    public class ThreadContextStack : Castle.Core.Logging.IContextStack
    {
        public ThreadContextStack() { }
        public int Count { get; }
        public void Clear() { }
        public string Pop() { }
        public System.IDisposable Push(string message) { }
    }
    public class ThreadContextStacks : Castle.Core.Logging.IContextStacks
    {
        public ThreadContextStacks() { }
        public Castle.Core.Logging.IContextStack this[string key] { get; }
    }
}