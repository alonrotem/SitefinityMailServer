using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace SitefinityMailServer
{
public class SMTPServer_old
    {
        TcpClient client;
        NetworkStream stream;
        System.IO.StreamReader reader;
        System.IO.StreamWriter writer;
        public SMTPServer_old(TcpClient client)
        {
            this.client = client;
            stream = client.GetStream();
            reader = new System.IO.StreamReader(stream);
            writer = new System.IO.StreamWriter(stream);
            writer.NewLine = "\r\n";
            writer.AutoFlush = true;
        }
        //static void Main(string[] args)
        //{
        //    TcpListener listener = new TcpListener(IPAddress.Loopback,25);­ 
        //    listener.Start();
        //    while (true)
        //    {
        //        SMTPServer handler = new SMTPServer(listener.AcceptTcpClient());­ 
        //        Thread thread = new System.Threading.Thread(new ThreadStart(handler.Run));
        //        thread.Start();
        //    }
        //}
        public void Run()
        {
            writer.WriteLine("220 localhost -- Fake proxy server");
            for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
            {
                Console.Error.WriteLine("Read line {0}", line);
                bool knownCommand = false;
                if (line.Length > 0)
                {
                    if (line.StartsWith("QUIT", StringComparison.OrdinalIgnoreCase))
                    {
                        client.Close();
                        knownCommand = true;
                        break;//exit while
                    }
                    //message has successfully been received
                    if ((line.StartsWith("EHLO", StringComparison.OrdinalIgnoreCase)) || (line.StartsWith("HELO", StringComparison.OrdinalIgnoreCase)))
                    {
                        knownCommand = true;
                        writer.Write("250 hi!");
                    }

                    if (line.StartsWith("RCPT TO", StringComparison.OrdinalIgnoreCase))
                    {
                        knownCommand = true;
                        writer.Write("250 OK");
                    }

                    if (line.StartsWith("MAIL FROM", StringComparison.OrdinalIgnoreCase))
                    {
                        knownCommand = true;
                        writer.Write("250 OK");
                    }

                    if (line.StartsWith("DATA", StringComparison.OrdinalIgnoreCase))
                    {
                        knownCommand = true;
                        writer.Write("354 Start mail input; end with");
                        StringBuilder data = new StringBuilder();
                        String subject = "";
                        line = reader.ReadLine();
                        if (line != null && line != ".")
                        {
                            const string SUBJECT = "Subject: ";
                            if (line.StartsWith(SUBJECT))
                                subject = line.Substring(SUBJECT.Length);
                            else data.AppendLine(line);
                            for (line = reader.ReadLine();
                                line != null && line != ".";
                                line = reader.ReadLine())
                            {
                                data.AppendLine(line);
                            }
                        }
                        String message = data.ToString();
                        Console.Error.WriteLine("Received ­ email with subject: {0} and message: {1}",
                            subject, message);
                        writer.WriteLine("250 OK");
                        client.Close();
                        return;
                    }
                    if (!knownCommand)
                    {
                        writer.Write("Unknown command");
                    }

                }
            }
        }
    }
}
