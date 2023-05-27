using System;
using System.Collections.Generic;

class Scripture
{
    private Reference reference;
    private List<Word> words;
    private List<Word> hiddenWords;

    public Scripture(string referenceTitle, string scriptureText){
        reference = new Reference(referenceTitle);
        words = new List<Word>();
        hiddenWords = new List<Word>();

        string[] textArray = scriptureText.Split(' ');
        foreach (string wordText in textArray){
            words.Add(new Word(wordText));
        }
    }

    public void DisplayScripture(){
        Console.WriteLine(reference.GetFullReference());
        foreach (Word word in words){
            if (hiddenWords.Contains(word)){
                Console.Write("___ ");
            }
            else{
                Console.Write(word.Text + " ");
            }
        }
    }

    public void HideRandomWord(){
        List<Word> availableWords = new List<Word>();
        foreach (Word word in words){
            if (!hiddenWords.Contains(word)){
                availableWords.Add(word);
            }
        }

        if (availableWords.Count > 0){
            Random random = new Random();
            int index = random.Next(0, availableWords.Count);
            hiddenWords.Add(availableWords[index]);
        }
    }
}
