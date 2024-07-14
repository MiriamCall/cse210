// This code was commented by the assistance of Claude ai.
// This code was was contributed by Miriam Call, Grant Call, Claude ai
/*
This GoalConverter class is a custom JSON converter for the Goal class hierarchy.
Its purpose is to enable proper serialization and deserialization of Goal objects
while maintaining encapsulation and supporting polymorphism.

Why this class is necessary:
1. Polymorphism: The Goal class is abstract, with concrete subclasses like SimpleGoal,
   EternalGoal, and ChecklistGoal. This converter allows us to deserialize JSON into
   the correct subclass based on a "Type" property in the JSON data.
2. Encapsulation: By using custom serialization methods (GetSerializableData and
   LoadFromSerializedData), we can control exactly what data is serialized and how
   it's loaded, without exposing private fields or using public properties.
3. Flexibility: This approach allows us to change the internal structure of our Goal
   classes without breaking serialization, as long as we update the serialization methods.

This converter is used in conjunction with System.Text.Json to handle the conversion
between JSON and Goal objects in a way that respects our class design and OOP principles.
*/


// Import necessary namespaces for JSON handling
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Define a custom JsonConverter for the Goal class
public class GoalConverter : JsonConverter<Goal>
{
    // Override the Read method to customize deserialization
    public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Check if the current JSON token is the start of an object
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException("JSON token is not a start object");
        }

        // Parse the JSON into a JsonDocument
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            // Ensure the document was successfully parsed
            if (doc == null)
            {
                throw new JsonException("Failed to parse JSON");
            }

            // Get the root element of the JSON document
            JsonElement root = doc.RootElement;
            
            // Try to get the "Type" property from the JSON
            if (!root.TryGetProperty("Type", out JsonElement typeElement))
            {
                throw new JsonException("Missing 'Type' property in JSON");
            }

            // Get the string value of the "Type" property
            string type = typeElement.GetString();

            // Create the appropriate Goal subclass based on the "Type" value
            Goal goal = type switch
            {
                "Simple Goal" => new SimpleGoal(),
                "Eternal Goal" => new EternalGoal(),
                "Checklist Goal" => new ChecklistGoal(),
                _ => throw new JsonException($"Unknown goal type: {type}")
            };

            // Load the data from the JSON into the goal object
            goal.LoadFromSerializedData(root);

            // Return the fully populated goal object
            return goal;
        }
    }

    // Override the Write method to customize serialization
    public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
    {
        // Serialize the goal object using its GetSerializableData method
        JsonSerializer.Serialize(writer, value.GetSerializableData(), options);
    }
}