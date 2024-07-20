using System;
using System.Collections.Generic;
using System.IO;

class FileHandler
{
	public static void SaveLogsToFile(string filePath, List<Log> logs)
	{
		using (StreamWriter writer = new StreamWriter(filePath))
		{
			foreach (Log log in logs)
			{
				writer.WriteLine(log.ToString());
			}
		}
	}

    public static List<Log> LoadLogsFromFile(string filePath)
    {
        List<Log> logs = new List<Log>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Log log = Log.CreateLog(line);
                logs.Add(log);
            }
        }
        return logs;
    }

}

