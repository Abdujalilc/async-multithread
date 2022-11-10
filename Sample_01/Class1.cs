using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_01
{
    internal class Class1
    {
        static void test1(string[] args)
        {
            Task<string> obTask = Task.Run(() => { return "Hello"; });
            Console.WriteLine(obTask.Result);
        }
        static void test2(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(getMyName));
            thread.Start();
        }
        public static void getMyName() { }
    }
}
