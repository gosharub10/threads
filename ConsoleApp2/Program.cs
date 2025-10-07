namespace ConsoleApp2;

public static class Program
{
    public static async Task Main(string[] args)
    {
        const int count = 3;
            
        Data.ProcessBatchOfData(count);
        await DataAsync.ProcessBatchOfDataAsync(count);
    }
}