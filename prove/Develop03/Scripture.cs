/*public class Scripture
{   
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string scriptureText)
    {
      _reference = reference;
      /string[] words = scriptureText.Split();
      foreach (string word in words)
      {
        Word myWord = new Word(word);
        _words.Add(myWord);
      }/
      _words = scriptureText.Split().Select(word => new Word(word)).ToList();
    }
    }

    private Random random = new Random();
    public void HideRandomWords(int numberToHide)
    {
    /{
      numberToHide = 1;
      int index = random.Next(_words.Count);
      Word randomWord = _words[index];
      randomWord.Hide();
    }/
    
    public string GetDisplayText()
    {
      string displayText = "";
      foreach (Word word in _words)
      {
        displayText += $"{word.GetDisplayText() }";
      }
      return displayText;
    }

    public bool IsCompletelyHidden()
    {
      return _words.All(word => word.isHidden());
    }
}*/

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split().Select(word => new Word(word)).ToList();
    }

    private List<int> hiddenWordIndices = new List<int>();

    public void HideRandomWords(int count)
    {
      Random random = new Random();

    for (int i = 0; i < count; i++)
    {
        int wordIndex;
        do
        {
            wordIndex = random.Next(_words.Count);
        } while (hiddenWordIndices.Contains(wordIndex));

        hiddenWordIndices.Add(wordIndex);

        _words[wordIndex].Hide();
    }

    if (_words.Count - hiddenWordIndices.Count == 1)
    {
        int lastWordIndex = _words.FindIndex(word => !hiddenWordIndices.Contains(_words.IndexOf(word)));
        hiddenWordIndices.Add(lastWordIndex);
        _words[lastWordIndex].Hide();
    }
        /*Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            int wordIndex;

            do
            {
                wordIndex = random.Next(_words.Count);
            } while (hiddenWordIndices.Contains(wordIndex));

            hiddenWordIndices.Add(wordIndex);
            _words[wordIndex].Hide();
        } */
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
