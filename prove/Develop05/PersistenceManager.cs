using System;
using System.IO;
using System.Text.Json;

public class PersistenceManager
{
    private readonly JsonSerializerOptions _jsonOptions;

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
        try
        {
            var dataToSave = goalTracker.GetSerializableData();
            string jsonString = JsonSerializer.Serialize(dataToSave, _jsonOptions);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Data saved successfully.");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error serializing the data: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error writing to the file: {ex.Message}");
        }
    }

    public void Load(string filePath, GoalTracker goalTracker)
    {
        if (File.Exists(filePath))
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                var dataLoaded = JsonSerializer.Deserialize<JsonElement>(jsonString, _jsonOptions);
                goalTracker.LoadFromSerializedData(dataLoaded);
                Console.WriteLine("Data loaded successfully.");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error parsing the JSON file: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}