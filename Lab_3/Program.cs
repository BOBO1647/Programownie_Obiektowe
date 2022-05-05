

using System;
using Lab_3.Logger;

namespace Lab_3
{
    public class Program
    {
        public static void Main()
        {
            string host = "google.com";
            int port = 80;
            using (ClientSocket clientSocket = new ClientSocket(host, port))
            {
                // request:
                string requestText = "Message to sent ...";
                byte[] requestBytes = Encoding.UTF8.GetBytes(requestText);
                clientSocket.Send(requestBytes);

                clientSocket.Close();
            }
        }
    }
}