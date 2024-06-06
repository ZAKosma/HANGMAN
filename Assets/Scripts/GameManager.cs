using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public LetterInput letterInput;
    public LetterWordCheck letterWordCheck;
    public ManHealth manHealth;
    public WordGeneration wordGeneration;
    public FullEntryHandler fullEntryHandler;
    public UIManager uiManager;
    
    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
    
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    void Start()
    {
        // Initialize game components
        wordGeneration.GenerateWord();
        uiManager.InitializeUI();
        manHealth.InitializeHealth();
    }

    public void CheckGameOver()
    {
        if (manHealth.IsDead())
        {
            uiManager.ShowGameOver();
        }
        else if (letterWordCheck.IsWordGuessed())
        {
            uiManager.ShowVictory();
        }
    }
}