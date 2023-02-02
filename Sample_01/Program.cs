Console.OutputEncoding = System.Text.Encoding.UTF8;
await PrintAsync();   // call async method
Console.WriteLine("Some action in method Main");
Console.ReadLine();

void Print()
{
    Thread.Sleep(3000);     // imitation
    Console.WriteLine("Hello METANIT.COM");
}

// declare async method
async Task PrintAsync()
{
    Console.WriteLine("PrintAsync methos started");     //sync
    await Task.Run(() => Print());                      //async
    Console.WriteLine("PrintAsync method finished");

    await Task.Run(() =>
    {
        Thread.Sleep(3000);// imitation
        Console.WriteLine("Hello METANIT.COM");
    });
}