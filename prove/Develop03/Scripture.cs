using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string reference;
    private List<ScriptureWord> words;
    private int hiddenWordCount;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').Select(word => new ScriptureWord(word)).ToList();
        this.hiddenWordCount = 0;
    }

    public void Display()
    {
        Console.WriteLine(reference);
        foreach (var word in words)
        {
            Console.Write(word.IsHidden ? "***** " : word.Text + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
        var notHiddenWords = words.Where(word => !word.IsHidden).ToList();
        if (notHiddenWords.Count == 0)
        {
            return false; // All words are hidden
        }

        var random = new Random();
        var randomWord = notHiddenWords[random.Next(notHiddenWords.Count)];
        randomWord.Hide();
        hiddenWordCount++;
        return true;
    }

    public bool AllWordsHidden()
    {
        return hiddenWordCount == words.Count;
    }
}