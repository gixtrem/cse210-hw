using System;

public class Word
{
    private string _word;
    private bool _IsShown;

    public Word(string word)
    {
        _word = word;
        _IsShown = true;
    }

    public void DisplayWord()
    {
        if (_IsShown == false)
        {
            foreach (char letter in _word)
            {
                Console.Write("_");
            }
            Console.Write(" ");
        }
        else
        {
            Console.Write($"{_word} ");
        }
    }
