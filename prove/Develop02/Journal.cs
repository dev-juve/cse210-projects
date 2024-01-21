

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

   public void AddEntry(Entry _newEntry)
   {
    _entries.Add(_newEntry);
   }
   public void DisplayAll()
   {
    foreach (Entry _entry in _entries)
    {
        _entry.DisplayEntry();
        Console.WriteLine("");
    }
   }

   public void SaveToFile(string _fileNameToSaveTo)
   {
      using (StreamWriter outputFile = new StreamWriter(_fileNameToSaveTo))
      {
        foreach (Entry _entry in _entries)
        {
            outputFile.WriteLine("");
            outputFile.WriteLine($"Date: {_entry._date}");
            outputFile.WriteLine($"Prompt: {_entry._promptText}");
            outputFile.WriteLine($"Answer: {_entry._entryText}");
            outputFile.WriteLine("");
        }
        
      }
    }

    public void LoadFromFile(string _fileNameToLoadFrom)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(_fileNameToLoadFrom);

        Entry loadedEntry = null;

        foreach (string line in lines)
        {
            if (line.StartsWith("Date:"))
            {
                loadedEntry = new Entry();
                loadedEntry._date = line.Substring("Date:".Length).Trim();
            }
            else if (line.StartsWith("Prompt:"))
            {
                loadedEntry._promptText = line.Substring("Prompt:".Length).Trim();
            }
            else if (line.StartsWith("Answer:"))
            {
                loadedEntry._entryText = line.Substring("Answer:".Length).Trim();
                _entries.Add(loadedEntry);
            }
        }

    }

   
}