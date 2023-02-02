GetCustomerIdAsync1();
GetCustomerIdAsync2();
Task<int> GetCustomerIdAsync1()
{
    return Task.FromResult(1);
}
ValueTask<int> GetCustomerIdAsync2()
{
    return new ValueTask<int>(1);
}
int GetSum(int a, int b)
{
    return a + b;
}

int addition = await AddAsync(4, 5);
Console.WriteLine(addition);
ValueTask<int> AddAsync(int a, int b)
{
    return new ValueTask<int>(a + b);
}

//as task
string message = await GetMessageAsync().AsTask();
Console.WriteLine(message); // Hello

async ValueTask<string> GetMessageAsync()
{
    await Task.Delay(0);
    return "Hello";
}