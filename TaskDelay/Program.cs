Console.OutputEncoding = System.Text.Encoding.UTF8;
await PrintAsync();   // вызов асинхронного метода
Console.WriteLine("Некоторые действия в методе Main");
Console.ReadLine();
// определение асинхронного метода
async Task PrintAsync()
{
    await Task.Delay(3000);     // имитация продолжительной работы
    // или так
    //await Task.Delay(TimeSpan.FromMilliseconds(3000));
    Console.WriteLine("Hello METANIT.COM");
}

PrintName("Tom");
PrintName("Bob");
PrintName("Sam");

void PrintName(string name)
{
    Thread.Sleep(3000);     // имитация продолжительной работы
    Console.WriteLine(name);
}

Console.ReadLine();

await PrintNameAsync("Tom");
await PrintNameAsync("Bob");
await PrintNameAsync("Sam");

// определение асинхронного метода
async Task PrintNameAsync(string name)
{
    await Task.Delay(3000);     // имитация продолжительной работы
    Console.WriteLine(name);
}

Console.ReadLine();