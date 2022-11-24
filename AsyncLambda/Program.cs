// асинхронное лямбда-выражение
Func<string, Task> printer = async (message) =>
{
    await Task.Delay(3000);
    Console.WriteLine(message);
};

await printer("Hello World");
await printer("Hello METANIT.COM");

Console.ReadLine();