using System;

public class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text)
    {
        _text = text;
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
        if (_isHidden == true)
        {
            string hidden = "";
            for (int i = 0; i < _text.Length; i++)
            {
                hidden += "_";
            }
            return hidden;
            
        }

        else
        {
            return _text;
        }
    }
}