CancellationTokenSource? tokenSource = new CancellationTokenSource();

CancellableMethod();

if (Console.ReadKey().KeyChar is 'c' or 'C')
{
    Console.WriteLine("\n" + "Thread is about to cancel");
    Thread.Sleep(3000);
    tokenSource.Cancel();
}

void CancellableMethod()
{
    Task.Run(() =>
    {
        int maxIterations = 100;
        for (int i = 0; i < maxIterations; ++i)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            if (tokenSource.IsCancellationRequested)
                tokenSource.Token.ThrowIfCancellationRequested();
        }
    }, tokenSource.Token);
}