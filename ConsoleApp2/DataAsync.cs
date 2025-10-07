namespace ConsoleApp2;

public static class DataAsync
{
    public static async Task<string> ProcessDataAsync(string dataName)
    {
        await Task.Delay(3000);
            
        return $"Обработка {dataName} завершена за 3 секунды";
    }

    public static async Task ProcessBatchOfDataAsync(int count)
    {
        var tasks = new List<Task<string>>();
            
        for (var i = 1; i <= count; i++)
        {
            tasks.Add(ProcessDataAsync($"Файл {i}"));
        }

        while (tasks.Count > 0)
        {
            var finished = await Task.WhenAny(tasks);
            tasks.Remove(finished);
            
            var result = await finished;
            Console.WriteLine(result);
        }
    }
}