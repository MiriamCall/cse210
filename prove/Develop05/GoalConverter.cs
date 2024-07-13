using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GoalConverter : JsonConverter<Goal>
{
    public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException("JSON token is not a start object");
        }

        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            if (doc == null)
            {
                throw new JsonException("Failed to parse JSON");
            }

            JsonElement root = doc.RootElement;
            
            if (!root.TryGetProperty("Type", out JsonElement typeElement))
            {
                throw new JsonException("Missing 'Type' property in JSON");
            }

            string type = typeElement.GetString();

            Goal goal = type switch
            {
                "Simple Goal" => new SimpleGoal(),
                "Eternal Goal" => new EternalGoal(),
                "Checklist Goal" => new ChecklistGoal(),
                _ => throw new JsonException($"Unknown goal type: {type}")
            };

            goal.LoadFromSerializedData(root);
            return goal;
        }
    }

    public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.GetSerializableData(), options);
    }
}