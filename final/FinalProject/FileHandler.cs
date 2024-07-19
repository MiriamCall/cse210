using System;
using System.Collections.Generic;
using System.IO;

class FileHandler
{
	public static void SaveLogsToFile(string filePath, List<FeedingLog> feedingLogs)
	{
		using (StreamWriter writer = new StreamWriter(filePath))
		{
			foreach (FeedingLog log in feedingLogs)
			{
				writer.WriteLine(log.ToString());
			}
		}
	}

	public static List<FeedingLog> LoadLogsFromFile(string filePath)
	{
		List<FeedingLog> feedingLogs = new List<FeedingLog>();
		using (StreamReader reader = new StreamReader(filePath))
		{
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				FeedingLog log = FeedingLog.Parse(line);
				feedingLogs.Add(log);
			}
		}
		return feedingLogs;
	}
}

