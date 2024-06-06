using System.Collections.Generic;
using UnityEngine;

public class LetterWordCheck : MonoBehaviour
{
    public string currentWord;
    public List<char> guessedLetters = new List<char>();

    public void CheckLetter(char letter)
    {
        Debug.Log("Checking letter: " + letter + " in word: " + currentWord);
        List<int> positions = new List<int>();
        for (int i = 0; i < currentWord.Length; i++)
        {
            if (currentWord[i] == letter)
            {
                positions.Add(i);
            }
        }

        if (positions.Count > 0)
        {
            Debug.Log("Correct letter: " + letter);
            guessedLetters.Add(letter);
            GameManager.Instance.uiManager.UpdateGuessedLetters(letter, positions);
        }
        else
        {
            Debug.Log("Incorrect letter: " + letter);
            GameManager.Instance.manHealth.DecrementHealth();
            GameManager.Instance.uiManager.UpdateBadLetters(letter);
        }
        GameManager.Instance.CheckGameOver();
    }

    public bool IsWordGuessed()
    {
        foreach (char c in currentWord)
        {
            if (!guessedLetters.Contains(c))
            {
                return false;
            }
        }
        return true;
    }
}