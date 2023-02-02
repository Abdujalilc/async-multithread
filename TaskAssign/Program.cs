callMethod();
async void callMethod()
{
    Task<int> task = Method1();
    Method2();
    int count = await task;
}
async Task<int> Method1()
{
    int count = 0;
    await Task.Run(() =>
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(" Method 1");
            count += 1;
        }
    });
    //returning simple int
    return count;
}
void Method2()
{
    for (int i = 0; i < 25; i++)
    {
        Console.WriteLine(" Method 2");
        // Do something
        Task.Delay(100).Wait();
    }
}