using System.IO;
using System.Text.Json;

public class PersistenceManager
{
    private JsonSerializerOptions _jsonOptions;

    public PersistenceManager()
    {
        _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new GoalConverter() }
        };
    }

    public void Save(string filePath, GoalTracker goalTracker)
    {
        var dataToSave = goalTracker.GetSerializableData();
        string jsonString = JsonSerializer.Serialize(dataToSave, _jsonOptions);
        File.WriteAllText(filePath, jsonString);
    }

    public void Load(string filePath, GoalTracker goalTracker)
    {
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            var dataLoaded = JsonSerializer.Deserialize<JsonElement>(jsonString, _jsonOptions);
            goalTracker.LoadFromSerializedData(dataLoaded);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
