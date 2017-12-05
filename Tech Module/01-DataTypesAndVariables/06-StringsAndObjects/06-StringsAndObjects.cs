using System;

class Program
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";

        object sentence = word1 + " " + word2;
        string newSentence = (string)sentence;

        Console.WriteLine(newSentence);
    }
}

