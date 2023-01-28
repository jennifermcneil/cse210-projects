using System.IO;
public class FileHandling

{
    public string _fileName = "";
    public void Save(List<Entry> _entryList)
    {
        Console.WriteLine("Enter the filename, exp. (Filename).txt: ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entryList)

                outputFile.WriteLine($"{entry._date} | {entry._prompt} | {entry._userInput}");
        }
    }
    public void LoadFile(List<Entry> entryList)
    {
        Console.WriteLine("Enter the filename, exp. (Filename).txt: ");
        _fileName = Console.ReadLine();
        using (StreamReader sr = new StreamReader(_fileName))
        {
            entryList.Clear();
            string line;
            //Read and display lines from the file until the end of the file is reached.
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(" | ");
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._userInput = parts[2];
                entryList.Add(entry);
            }
        }
    }
}