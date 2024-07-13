using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GoalConverter : JsonConverter<Goal>
{
    public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            JsonElement root = doc.RootElement;
            string type = root.GetProperty("Type").GetString();

            Goal goal = type switch
            {
                "SimpleGoal" => new SimpleGoal(),
                "EternalGoal" => new EternalGoal(),
                "ChecklistGoal" => new ChecklistGoal(),
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