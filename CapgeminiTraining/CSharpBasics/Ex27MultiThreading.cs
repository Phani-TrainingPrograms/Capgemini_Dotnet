using System;
using System.Threading;
using System.Threading.Tasks;
/*
 * Multithrading is a feature of OS where it can allow multiple tasks(Sequence of execution) to be accomplished parallelly. 
 * A process is an instance of an Exe. 
 * A thread is a sequence of execution within a process. A process can have multiple threads if the OS supports. 
 * Usually, a process will have a single thread. This is called as Main Thread. U can optionally create multiple threads called as WORKER threads that shall perform a task(Work) and close. If the Main thread closes, all the other threads by default terminates. However, using some techiques, we can make the main thread wait till the worker thread completes its task. 
 * Foreground Threads are one that makes the Main thread wait till it completes its task, however background threads cannot stop the Main thread from termination. In .NET, default is foreground threads.
 * All Threads in .NET are objects of System. Threading.Thread class. Its property IsBackgroundThread is used to make a thread a Background Thread. 
 * U can use delegates also to perform async operations. 
 * Whenever U instantiate a Thread class, it takes an instance of the delegate called ThreadStart. It is a void delegate with no args 
 * Task is a new feature of C# that allows tasks to be performed using multiple cores of the machine that executes the Application.
 * It is a new way of performing Async Operations in C#. They are all background threads internally.
 * The Task Class is the part of System.Threading.Tasks namespace and is commonly used with async and await keywords. 
 */
namespace CSharpBasics
{
    internal class MultiThreadingExample
    {
        static void SomeFunc()
        {
            string name = Thread.CurrentThread.Name;
            lock (typeof(MultiThreadingExample))
            {
                ConsoleIO.LoopThru(10, $"Some Big Task by {name}");
            }
        }

        //async shall have the Task object or Task<T> as its return type
        static async Task LongRunningOperationAsync()
        {
            Console.WriteLine("The Task has started");
            await ConsoleIO.LoopThru(10, "Task message");
            Console.WriteLine("Task has completed");
            await Task.Delay(2000);
        }
        static void Main(string[] args)
        {
            //threadingExample();
            //taskExample();
            Console.WriteLine("Main has started");
            Task t1 = LongRunningOperationAsync();
            //await ConsoleIO.LoopThru(5, "Main doing its job");
            t1.Wait();
            Console.WriteLine("The Main is terminating");
        }

        private static void taskExample()
        {
            Task t1 = LongRunningOperationAsync();
            ConsoleIO.LoopThru(5, "Main doing its job");
            //await t1;
            Console.WriteLine("The Main is terminating");
        }

        private static void threadingExample()
        {
            Console.WriteLine("Main has started");
            Thread thread = new Thread(SomeFunc);
            //thread.IsBackground = true;//Makes the thread as background.
            thread.Name = "First Thread";
            thread.Start();
            Thread thread2 = new Thread(SomeFunc);
            //thread2.IsBackground = true;
            thread2.Name = "Second Thread";

            thread2.Start();
            ConsoleIO.LoopThru(5, "Main doing its Job");
            Console.WriteLine("Main has Ended");
        }
    }
}
