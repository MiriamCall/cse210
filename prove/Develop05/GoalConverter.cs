using System;
using System.Collections.Generic;
using System.IO;
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
            string name = root.GetProperty("Name").GetString();
            string description = root.GetProperty("Description").GetString();
            int points = root.GetProperty("Points").GetInt32();
            bool completed = root.GetProperty("Completed").GetBoolean();

            Goal goal = type switch
            {
                nameof(SimpleGoal) => new SimpleGoal(name, description, points),
                nameof(EternalGoal) => new EternalGoal(name, description, points),
                nameof(ChecklistGoal) => new ChecklistGoal(name, description, points,
                                                           root.GetProperty("RequiredCount").GetInt32(),
                                                           root.GetProperty("BonusPoints").GetInt32()),
                _ => throw new NotSupportedException($"Goal type {type} is not supported.")
            };

            return goal;
        }
    }

    public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Type", value.GetType().Name);
        writer.WriteString("Name", value.Name);
        writer.WriteString("Description", value.Description);
        writer.WriteNumber("Points", value.Points);
        writer.WriteBoolean("Completed", value.Completed);

        if (value is ChecklistGoal checklistGoal)
        {
            writer.WriteNumber("RequiredCount", checklistGoal.RequiredCount);
            writer.WriteNumber("BonusPoints", checklistGoal.BonusPoints);
            writer.WriteNumber("CurrentCount", checklistGoal.CurrentCount);
        }

        writer.WriteEndObject();
    }
}
