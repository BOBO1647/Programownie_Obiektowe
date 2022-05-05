using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    class FileLogger : WriterLogger
    {
        public FileLogger string path { get; set; }
        private virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            //Chyba tak to disposed skopiowane z internetu :)

            _disposed = true;

            // nie rozumiem protected stream: FileStream
        }
        ~FileLogger()
        {
            this.Dispose(false);
        }

        public override void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }
    }
}