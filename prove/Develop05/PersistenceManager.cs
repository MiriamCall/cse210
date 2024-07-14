/*
The PersistenceManager class is responsible for handling the serialization and
deserialization of the GoalTracker data to and from JSON files. It serves as an
abstraction layer between the application's data model and the file system.

Key features and responsibilities:
1. Encapsulation of JSON serialization settings, including the use of custom converters.
2. Providing methods to save and load GoalTracker data to/from files.
3. Error handling for various scenarios that might occur during file operations.
4. Maintaining a consistent format for data persistence across the application.

This class supports the application's data persistence needs while keeping the
serialization logic separate from the core business logic in the GoalTracker class.
*/

using System;
using System.IO;
using System.Text.Json;

public class PersistenceManager
{
    // JsonSerializerOptions to be used for all serialization/deserialization operations
    private readonly JsonSerializerOptions _jsonOptions;

    public PersistenceManager()
    {
        // Initialize JSON options with indented writing and custom GoalConverter
        _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new GoalConverter() }
        };
    }

    // Method to save GoalTracker data to a file
    public void Save(string filePath, GoalTracker goalTracker)
    {
        try
        {
            // Get serializable data from the GoalTracker
            var dataToSave = goalTracker.GetSerializableData();
            // Serialize the data to a JSON string
            string jsonString = JsonSerializer.Serialize(dataToSave, _jsonOptions);
            // Write the JSON string to the specified file
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Data saved successfully.");
        }
        catch (JsonException ex)
        {
            // Handle JSON serialization errors
            Console.WriteLine($"Error serializing the data: {ex.Message}");
        }
        catch (IOException ex)
        {
            // Handle file writing errors
            Console.WriteLine($"Error writing to the file: {ex.Message}");
        }
    }

    // Method to load GoalTracker data from a file
    public void Load(string filePath, GoalTracker goalTracker)
    {
        if (File.Exists(filePath))
        {
            try
            {
                // Read the entire file content
                string jsonString = File.ReadAllText(filePath);
                // Deserialize the JSON string to a JsonElement
                var dataLoaded = JsonSerializer.Deserialize<JsonElement>(jsonString, _jsonOptions);
                // Load the deserialized data into the GoalTracker
                goalTracker.LoadFromSerializedData(dataLoaded);
                Console.WriteLine("Data loaded successfully.");
            }
            catch (JsonException ex)
            {
                // Handle JSON parsing errors
                Console.WriteLine($"Error parsing the JSON file: {ex.Message}");
            }
            catch (IOException ex)
            {
                // Handle file reading errors
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
        }
        else
        {
            // Handle case where file doesn't exist
            Console.WriteLine("File not found.");
        }
    }
}