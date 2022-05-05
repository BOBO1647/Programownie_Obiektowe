using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    class CommonLogger : ILogger
    {
        private readonly ILogger[] loggers;
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public void Log(params string[] messages)
        {
            string time = DateTime.Now.ToString("yyyy-MM-ddTHH:MM:sszzz");
            //TODO - dostosować forma wysłanej wiadomości

            for (int i = 0; i < messages.Length; i++)
            {
                string requestText = time + ": " + messages[i] + "\n";
                byte[] requestBytes = Encoding.UTF8.GetBytes(requestText);

                this.CommonLogger.Send(requestBytes);
                //TODO Sprawdzić czemu nie działa
            }
        }
    }
}