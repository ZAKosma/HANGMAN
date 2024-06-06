using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LetterInput : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button submitButton;

    void Start()
    {
        submitButton.onClick.AddListener(OnSubmit);
        inputField.onEndEdit.AddListener(OnSubmit);
    }

    void OnSubmit(string input)
    {
        if (input.Length == 1)
        {
            GameManager.Instance.letterWordCheck.CheckLetter(input[0]);
        }
        else if (input.Length == GameManager.Instance.wordGeneration.currentWord.Length)
        {
            GameManager.Instance.fullEntryHandler.HandleFullGuess(input);
        }
        inputField.text = string.Empty;
    }

    public void OnSubmit()
    {
        OnSubmit(inputField.text);
    }
}