public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string textWord)
    {   
        _text = textWord;
        _isHidden = false;
        
    }

    public void Hide()
    {
        _isHidden = true;
    }
    
    public void Show()
    {
       _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "______" : _text;
    }

}

