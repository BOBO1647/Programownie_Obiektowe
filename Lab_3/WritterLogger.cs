using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_3.Logger
{
    public abstract class WriterLogger : ILogger
    {

        protected TextWriter writer;


        public virtual void Log(params string[] messages)
        {

            string time = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            this.writer.Write(time + ":");
            for (int i = 0; i < messages.Length; i++)
            {
                this.writer.Write(" " + messages[i]);
            }
            this.writer.Write('\n');
            this.writer.Flush();
        }

        public abstract void Dispose();
    }
}
