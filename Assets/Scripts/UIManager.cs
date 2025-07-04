
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public TMP_Text scoreDisplay;

    private void Start()
    {
        scoreDisplay.text = "";
        foreach (var entry in PlayerData.playerData.scores)
        {
            scoreDisplay.text += entry.playerName + ": " + entry.score + "\n";
        }
    }

    public void StartGame()
    {
        SaveInput();
        SceneManager.LoadScene(1);
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SaveInput()
    {
        PlayerData.playerData.playerName = playerNameInput.text;
    }
}
