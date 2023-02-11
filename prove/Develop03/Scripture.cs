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
            Console.WriteLine(word.GetWord());
        }

    }
    public bool CompletelyHidden()
    {
        return true;
    }

    public void HideWords()
    {
        Random random = new Random();
        // select three random words the verse and hide them until all the words in the scripture are hidden
        // display entire scripture
        // While loop with counter ( while(*variable* < 3)  )
        while ((< 3))
            for (int i = 0; i < 3; i++)
            {
                // IF check if the the word is already hidden (use your getter to check the status of visible)
                // If it is NOT hidden then we set it to hidden;
                _wordList[random.Next(_wordList.Count())].SetVisible(false);
                // Incriment the counter


            }
    }


}

