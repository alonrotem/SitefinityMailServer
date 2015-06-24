using System;
using System.Windows.Forms;
using System.Threading;

namespace SitefinityMailServer
{
    static class Program
    {
        // unique id for global mutex - Global prefix means it is global to the machine
        const string mutex_id = "Global\\{7B0F7A01-8759-45EA-AC08-CA14C876537D}";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            using (var mutex = new Mutex(false, mutex_id))
            {
                try
                {
                    try
                    {
                        if (!mutex.WaitOne(TimeSpan.FromSeconds(2), false))
                        {
                            MessageBox.Show("Sitefinity Mail Server is already running!", "Whazzzupppppp");
                            Environment.Exit(0);
                        }
                    }
                    catch (AbandonedMutexException)
                    {
                        // Log the fact the mutex was abandoned in another process, it will still get aquired
                    }
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MailServerUI());
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
