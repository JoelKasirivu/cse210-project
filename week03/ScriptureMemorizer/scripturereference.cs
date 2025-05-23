using System;
using System.Collections.Generic;
using System.Linq;

class ScriptureReference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public ScriptureReference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" : $"{Book} {Chapter}:{StartVerse}";
    }
}

class Word
{
    private string Text { get; set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}

class Scripture
{
    public ScriptureReference Reference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool HideRandomWords(int count = 2)
    {
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Count == 0) return false;

        var random = new Random();
        foreach (var word in visibleWords.OrderBy(_ => random.Next()).Take(count))
        {
            word.Hide();
        }
        return true;
    }

    public string GetDisplayText()
    {
        return $"{Reference}\n{string.Join(" ", Words)}";
    }
}

