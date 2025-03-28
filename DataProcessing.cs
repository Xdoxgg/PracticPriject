using System.Text.Json;

namespace lab2WINFORMS;

public static class DataProcessing
{
    public static void WriteToFile<T>(string fileName, List<T> o)
    {
        
        string jsonString = JsonSerializer.Serialize(o);
        File.WriteAllText(fileName, jsonString);

    }

    public static List<T> GetFromFile<T>(string fileName)
    {
        return ReadJsonFromFile<T>(fileName);
    }
    
    private static List<T> ReadJsonFromFile<T>(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        
        return JsonSerializer.Deserialize<List<T>>(jsonString);
    }
}