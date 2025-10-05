namespace ConsoleApp2;

public static class Data
{
    public static string ProcessData(string dataName)
    {
        Thread.Sleep(3000);

        return $"Обработка {dataName} завершена за 3 секунды";
    }

    public static void StartProcessData(int count)
    {
        for (var i = 1; i <= count; i++)
        {
            Console.WriteLine(ProcessData($"Файл {i}"));
        }
    }
}