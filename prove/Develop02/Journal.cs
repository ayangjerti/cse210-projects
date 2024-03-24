public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
            e.Display();
    }

    public void SaveToFile(string file)
    {
        //saved the file as a .csv file with comma delineation. /// This exceeds requirement
        // file = "myFile.csv";
        file = "myFile.csv";

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry a in _entries)
            {
                outputFile.WriteLine($"{a._date},{a._promptText},{a._entryText},{a._mood}");
            }
        }
    }
// hsh
    public void LoadFromFile(string file)
    {
         file = "myFile.csv";
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] parts = line.Split(",");
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            newEntry._mood = parts[3];
            _entries.Add(newEntry);
        }

    }
}