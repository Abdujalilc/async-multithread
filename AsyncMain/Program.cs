class Program
{
    async static Task Main(string[] args)
    {
        await PrintAsync();   // call async method
        Console.WriteLine("Some actions in method Main");


        void Print()
        {
            Thread.Sleep(3000);     // imitation
            Console.WriteLine("Hello METANIT.COM");
        }

        // define async method
        async Task PrintAsync()
        {
            Console.WriteLine("Начало метода PrintAsync");  // sync
            await Task.Run(() => Print());                  // async
            Console.WriteLine("Конец метода PrintAsync");
        }
    }
}