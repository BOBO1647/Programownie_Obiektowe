ClientSocket

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    public class ClientSocket : IDisposable
    {
        private bool disposed;

        private Socket socket;

        public ClientSocket(string host, int port)
        {
            IPHostEntry entry = Dns.GetHostEntry(host);

            this.socket = new Socket(SocketType.Stream, ProtocolType.Tcp);

            try
            {
                this.socket.Connect(entry.AddressList, port);
            }
            catch (SocketException ex)
            {
                this.socket.Dispose();

                throw ex;
            }
        }
        ~ClientSocket()
        {
            this.Dispose(false);
        }

        public int Send(byte[] buffer)
        {
            return this.socket.Send(buffer, SocketFlags.None);
        }

        public int Send(byte[] buffer, int offset, int size)
        {
            return this.socket.Send(buffer, offset, size, SocketFlags.None);
        }

        public int Receive(byte[] buffer)
        {
            return this.socket.Receive(buffer, SocketFlags.None);
        }

        public int Receive(byte[] buffer, int offset, int size)
        {
            return this.socket.Receive(buffer, offset, size, SocketFlags.None);
        }

        public void Close()
        {
            this.socket.Shutdown(SocketShutdown.Both);
            this.socket.Close();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    this.socket.Dispose();

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }
    }
}