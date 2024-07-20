class MedicationLog : Log
{
    private string _medicationName;
    private double _dosage;

    public MedicationLog()
    {
        _logName = "Medication Log";
        _medicationName = "";
        _dosage = 0.0;
    }

    public override void DisplayLog()
    {
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine($"{_logName}:");
        Console.WriteLine($"Timestamp: {_timeStamp}");
        Console.WriteLine($"Medication Name: {_medicationName}");
        Console.WriteLine($"Dosage: {_dosage} mg");
        Console.WriteLine($"You can take {_medicationName} in {_duration} hours or in {_duration / 60} minutes");
        Console.WriteLine("-----------------------------------------\n");
    }

    public string GetMedicationName()
    {
        return _medicationName;
    }

    public void SetMedicationName(string medicationName)
    {
        _medicationName = medicationName;
    }

    public double GetDosage()
    {
        return _dosage;
    }

    public void SetDosage(double dosage)
    {
        _dosage = dosage;
    }

    public void RecordMedication()
    {
        bool valid = false;
        while (!valid)
        {
            Console.Write("Enter medication name: ");
            string medicationName = Console.ReadLine();
            if (!string.IsNullOrEmpty(medicationName))
            {
                SetMedicationName(medicationName);

                Console.WriteLine("Enter dosage in mg: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double dosage))
                {
                    SetDosage(dosage);

                    Console.WriteLine("Enter medication duration in hours: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int duration))
                    {
                        // Convert hours to minutes for duration
                        SetDuration(duration * 60);
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number for duration.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid dosage.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a medication name.");
            }
        }
    }

    

    public override string ToString()
    {
        return $"{_logName}|{_timeStamp}|{_duration}|{_medicationName}";
    }

    public override Log Parse(string logString)
    {
        string[] parts = logString.Split('|');
        return new MedicationLog
        {
            _logName = parts[0],
            _timeStamp = DateTime.Parse(parts[1]),
            _duration = int.Parse(parts[2]),
            _medicationName = parts[3]
        };
    }
}