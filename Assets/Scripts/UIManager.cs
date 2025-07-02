using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    
    public TMP_InputField nameInputField;

    public TMP_Text score;

    string scoreString;

    private void Start()
    {

        scoreString = PlayerData.playerScore.ToString();
        score.text = "High Score : " + scoreString;
        

    }

  
    
    public void StartGame()
    {
        PlayerData.playerName = nameInputField.text;
        SceneManager.LoadScene(1);
    }

    public void EndGame()
    {
        EditorApplication.ExitPlaymode();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}