using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int wordsToHide = numberToHide;
        if (numberToHide > _words.Count)
        {
            wordsToHide = _words.Count;
        }

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }



    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        List<string> wordDisplays = new List<string>();
        foreach (Word word in _words)
        {
            wordDisplays.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", wordDisplays);

        return referenceText + "\n" + scriptureText;
    }

    
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}