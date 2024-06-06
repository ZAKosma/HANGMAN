using UnityEngine;

public class WordGeneration : MonoBehaviour
{
    public string[] words = { "cat", "dog", "bat" };
    public string currentWord;
    public LetterWordCheck letterWordCheck;

    public void GenerateWord()
    {
        int index = Random.Range(0, words.Length);
        currentWord = words[index];
        letterWordCheck.currentWord = currentWord;
    }
}