namespace ConsoleApp2;

public static class Program
{
    public static async Task Main(string[] args)
    {
        const int count = 3;
            
        Data.StartProcessData(count);
        await DataAsync.StartProcessDataAsync(count);
    }
}