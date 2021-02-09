using System;

namespace ClassDemoTracingAndConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadConfiguration();

            TraceWorker worker = new TraceWorker();
            worker.Start();
        }

        private static void ReadConfiguration()
        {
            

        }
    }
}
