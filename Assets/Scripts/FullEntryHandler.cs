using UnityEngine;

public class FullEntryHandler : MonoBehaviour
{
    public void HandleFullGuess(string guess)
    {
        if (GameManager.Instance.letterWordCheck.currentWord == guess)
        {
            GameManager.Instance.uiManager.ShowVictory();
        }
        else
        {
            GameManager.Instance.manHealth.DecrementHealth();
            GameManager.Instance.uiManager.UpdateBadLetters(guess);
        }
        GameManager.Instance.CheckGameOver();
    }
}