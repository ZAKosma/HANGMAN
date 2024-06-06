using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text[] letterFields;
    public TMP_Text badLettersField;
    public TMP_Text unusedLettersField;
    public Image[] manImages;
    private HashSet<char> unusedLetters = new HashSet<char>("abcdefghijklmnopqrstuvwxyz".ToCharArray());

    public void InitializeUI()
    {
        badLettersField.text = "";
        foreach (TMP_Text letterField in letterFields)
        {
            letterField.text = "";
        }
        UpdateUnusedLetters();
        
        // Update all manImages to be set as not active
        foreach (Image manImage in manImages)
        {
            manImage.gameObject.SetActive(false);
        }
        
        // Hook update man image event into ManHealth event
        GameManager.Instance.manHealth.OnHealthChanged += UpdateManImage;
    }

    public void UpdateGuessedLetters(char letter, List<int> positions)
    {
        foreach (int pos in positions)
        {
            letterFields[pos].text = letter.ToString();
        }
        unusedLetters.Remove(letter);
        UpdateUnusedLetters();
    }

    public void UpdateBadLetters(char letter)
    {
        badLettersField.text += letter + " ";
        unusedLetters.Remove(letter);
        UpdateUnusedLetters();
    }

    public void UpdateBadLetters(string word)
    {
        foreach (char letter in word)
        {
            badLettersField.text += letter + " ";
            unusedLetters.Remove(letter);
        }
        UpdateUnusedLetters();
    }

    public void ShowGameOver()
    {
        Debug.Log("Game Over");
    }

    public void ShowVictory()
    {
        Debug.Log("Victory");
    }

    private void UpdateUnusedLetters()
    {
        unusedLettersField.text = new string(new List<char>(unusedLetters).ToArray());
    }

    void UpdateManImage(int health)
    {
        int visibleImages = 5 - health;

        for (int i = 0; i < manImages.Length; i++)
        {
            manImages[i].gameObject.SetActive(i < visibleImages);
        }
    }

}
