Console.OutputEncoding = System.Text.Encoding.UTF8;
await PrintAsync();   // call async method
Console.WriteLine("Some actions in method Main");
Console.ReadLine();
// defime async method
async Task PrintAsync()
{
    await Task.Delay(3000);     // imitate
    // or
    //await Task.Delay(TimeSpan.FromMilliseconds(3000));
    Console.WriteLine("Hello METANIT.COM");
}

PrintName("Tom");
PrintName("Bob");
PrintName("Sam");

void PrintName(string name)
{
    Thread.Sleep(3000);     // imitate
    Console.WriteLine(name);
}

Console.ReadLine();

await PrintNameAsync("Tom");
await PrintNameAsync("Bob");
await PrintNameAsync("Sam");

// defime async method
async Task PrintNameAsync(string name)
{
    await Task.Delay(3000);     //imitate
    Console.WriteLine(name);
}

Console.ReadLine();