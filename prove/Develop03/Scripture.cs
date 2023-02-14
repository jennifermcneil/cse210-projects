public class Scripture
{
    // ATTRIBUTES (Class Variables)
    public Reference _reference;
    public List<Word> _wordList = new List<Word>();

    // CONSTRUCTOR (Method called once to setup the class. Often used to initialize variables (attributes))
    public Scripture(Reference reference, string verses)
    {
        _reference = reference;
        // Split verse string into an array of strings which we called words.
        string[] words = verses.Split(" ");
        // Iterate through each word in the the newly created string array and create word objects for each word.
        foreach (string word in words)
        {
            // Create temporary word object and pass in the word string into the Word clas constructor.
            Word wordObj = new Word(word);
            // Add the word object to the list of Word objects above on line 16
            _wordList.Add(wordObj);
        }


    }
    // METHODS (Functions)


    // Display each verse
    public void DisplayText()
    {
        foreach (Word word in _wordList)
        {
            if (word.GetVisible() == false)
            {

                word.Hide();
            }
            else
                word.Show();


            Console.Write(" ");
        }

        Console.WriteLine();
        Console.WriteLine();
    }

    public List<Word> StillShown()
    {
        List<Word> _wordsLeft = new List<Word>();
        foreach (Word word in _wordList)
        {
            if (word.GetVisible() == true)
            {
                _wordsLeft.Add(word);
            }
        }

        return _wordsLeft;
    }

    public bool DisplayNPrompt()
    {
        Console.Write(_reference.GetReferenceText());
        Console.Clear();
        DisplayText();
        Console.Write("Press enter to continue or type quit to end: ");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "quit")
        {
            return true;
        }
        else
        {
            Console.Clear();
            return false;
        }

    }


    public void HideWords()
    {
        Random random = new Random();

        if (DisplayNPrompt())
            System.Environment.Exit(0);

        while (true)
        {
            List<Word> _wordsLeft = StillShown();
            if (_wordsLeft.Count() == 0)
            {
                break;
            }


            for (int i = 0; i < 3; i++)
            {
                int randomIndex = random.Next(_wordsLeft.Count());
                _wordsLeft[randomIndex].SetVisible(false);

            }

            if (DisplayNPrompt())
                break;

        }
    }
}

