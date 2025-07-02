using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
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
