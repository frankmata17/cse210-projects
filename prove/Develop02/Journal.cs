class Journal
{
    public List<Entry> entryList { get; set; } = new List<Entry>(); // Use a different field name

    public void AddEntry(Entry entry)
    {
        entryList.Add(entry); // Update the field reference
    }

    public void DisplayEntries()
    {
        foreach (var entry in entryList)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entryList)
            {
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.Prompt}");
                writer.WriteLine($"Response: {entry.Response}");
                writer.WriteLine();
            }
        }
        Console.WriteLine("Journal saved to file.");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            entryList.Clear(); // Clear existing entries
            using (StreamReader reader = new StreamReader(fileName))
            {
                Entry currentEntry = null;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.StartsWith("Date: "))
                    {
                        currentEntry = new Entry();
                        currentEntry.Date = line.Substring("Date: ".Length);
                    }
                    else if (line.StartsWith("Prompt: "))
                    {
                        currentEntry.Prompt = line.Substring("Prompt: ".Length);
                    }
                    else if (line.StartsWith("Response: "))
                    {
                        currentEntry.Response = line.Substring("Response: ".Length);
                        entryList.Add(currentEntry);
                    }
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
        else
        {
            Console.WriteLine("File not found. No changes made.");
        }
    }
}