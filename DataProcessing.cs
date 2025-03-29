using System.Text.Json;

namespace lab2;


public static class DataProcessing
{
    public static void WriteToFile<T>(List<T> o)
    {
        string fileName = $"..//..//..//Data//{typeof(T).ToString()}.json";
        fileName = fileName.Replace("lab2.", ""); 

        string jsonString = JsonSerializer.Serialize(o);
        File.WriteAllText(fileName, jsonString);

    }

    public static List<T> ReadJsonFromFile<T>()
    {
        string fileName = $"..//..//..//Data//{typeof(T).Name}.json";
        fileName = fileName.Replace("lab2.", ""); 

        try
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<List<T>>(jsonString);
        }
        catch (FileNotFoundException ex)
        {
            return new List<T>();
        }
        catch (Exception ex)
        {
            return new List<T>();
        }
    }
}