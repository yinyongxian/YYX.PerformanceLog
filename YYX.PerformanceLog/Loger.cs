using log4net;

namespace YYX.PerformanceLog
{
    public class Loger : IDisposable
    {
        private bool disposedValue;
        private readonly ILog log;
        private string message;
        private DateTime startDatetime;

        public Loger(string message = "")
        {
            this.message = message;
            startDatetime = DateTime.Now;

            this.log = LogManager.GetLogger(typeof(Program));
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    var endDateTime = DateTime.Now;
                    message += Environment.NewLine + "Start datetime: " + startDatetime;
                    message += Environment.NewLine + "End datetime: " + endDateTime;
                    message += Environment.NewLine + "TimeSpan: " + (endDateTime - startDatetime);
                    message += Environment.NewLine;
                    log.Debug(message);
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Loger()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
