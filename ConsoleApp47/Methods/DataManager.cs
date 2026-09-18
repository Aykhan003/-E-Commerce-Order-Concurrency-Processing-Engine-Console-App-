using System.Text.Json;

namespace ConsoleApp47.Methods;

public static class DataManager
{
    static string directory = "C:\\Users\\User\\source\\repos\\ConsoleApp47\\ConsoleApp47\\";
    static string path = Path.Combine(directory, "Files");
    static string filePath = Path.Combine(path, "orders.json");

    static DataManager()
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
    }
    public static void SaveOrdersAsync<T>(List<T> orders)
    {
        string json = JsonSerializer.Serialize(orders);
        StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine(json);
        writer.Close();
    }
    public static List<T> LoadOrdersAsync<T>()
    {
        StreamReader reader = new StreamReader(filePath);
        string json = reader.ReadToEnd();
        reader.Close();
        if (string.IsNullOrWhiteSpace(json))
        {
            return new List<T>();
        }
        return JsonSerializer.Deserialize<List<T>>(json);
    }
}