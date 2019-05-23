using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C3L4
{
    public class UnmanagedResourcesHandler : IDisposable
    {

        private Timer _timer;

        public UnmanagedResourcesHandler()
        {
            _timer = new Timer(o => DoOnTick(o), null, 100, 100);
        }


        public void Start()
        {
            if (disposedValue == true)
                throw new ObjectDisposedException("UnmanagedResourcesHandler");
        }

        private void DoOnTick(object obj)
        {
            Console.WriteLine("Tick.");
            Console.ReadKey();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _timer.Dispose();
                    _timer = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnmanagedResourcesHandler()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
