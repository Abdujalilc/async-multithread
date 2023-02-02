namespace Sample_01
{
    internal class Class1
    {
        //use task
        static void test1(string[] args)
        {
            Task<string> obTask = Task.Run(() => { return "Hello"; });
            Console.WriteLine(obTask.Result);
        }
        //use thread
        static void test2(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(getMyName));
            thread.Start();
        }
        public static void getMyName() { 
        
        }
    }
}
