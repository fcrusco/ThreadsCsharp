using System;
using System.Threading;

namespace ThreadsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início do programa principal (Thread ID: " + Thread.CurrentThread.ManagedThreadId + ")");

            // Cria uma nova thread
            Thread thread1 = new Thread(new ThreadStart(MetodoThread));
            thread1.Name = "Thread1";
            thread1.Start();

            // Cria outra thread usando lambda
            Thread thread2 = new Thread(() =>
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"[{Thread.CurrentThread.Name}] Valor: {i}");
                    Thread.Sleep(800);
                }
            });
            thread2.Name = "Thread2";
            thread2.Start();

            // Executa um código na thread principal
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"[Main Thread] Valor: {i}");
                Thread.Sleep(1000);
            }

            // Espera as threads terminarem
            thread1.Join();
            thread2.Join();

            Console.WriteLine("Fim do programa principal");
            Console.ReadKey();
        }

        static void MetodoThread()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"[{Thread.CurrentThread.Name}] Valor: {i}");
                Thread.Sleep(700);
            }
        }
    }
}
