using TMPro;
using UnityEngine;

public class Name : MonoBehaviour
{
    public TMP_InputField inputField;

    private void Start()
    {
        inputField.onEndEdit.AddListener(HandleInput);
    }

    private void HandleInput(string input)
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SaveInput(input);
        }
    }

    private void SaveInput(string input)
    {
        Debug.Log("Saved input: " + input);
        // Add your save logic here
    }
}