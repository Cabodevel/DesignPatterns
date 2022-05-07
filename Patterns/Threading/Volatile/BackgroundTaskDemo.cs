using System;
using System.Threading;

namespace NetCoreDessignPatterns.Threading.Volatile
{
    public static class BackgroundTaskDemo
    {
        //volatile
        private volatile static bool stopping = false;

        public static void MainThread()
        {
            new Thread(EfectuarTrabajo).Start();
            Thread.Sleep(5000);
            stopping = true;


            Console.WriteLine("Main exit");
            Console.ReadLine();
        }

        static void EfectuarTrabajo()
        {
            int i = 0;
            int j = 2;

            while (!stopping)
            {
                i++;
                j = 100 + (int)Math.Sin((double)i * 10d);
                Console.WriteLine(j);
            }
            Console.WriteLine("EfectuarTrabajo exit " + i);
        }
    }
}
