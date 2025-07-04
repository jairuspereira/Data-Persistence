using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class PlayerScoreList
{
    public List<PlayerScoreEntry> entries = new List<PlayerScoreEntry>();
}

[System.Serializable]
public class PlayerScoreEntry
{
    public string playerName;
    public int score;
}

public class PlayerData : MonoBehaviour
{
    public static PlayerData playerData;

    public List<PlayerScoreEntry> scores = new List<PlayerScoreEntry>();

    public string playerName;
    public int playerScore;

    void Awake()
    {
        if (playerData != null && playerData != this)
        {
            Destroy(gameObject);
            return;
        }
        playerData = this;
        DontDestroyOnLoad(gameObject);
        LoadAllDataFromFile();
    }

    public void SaveScore(int m_Points)
    {
        scores.Add(new PlayerScoreEntry { playerName = playerName, score = m_Points });
    }

    public void SaveAllDataToFile()
    {
        PlayerScoreList list = new PlayerScoreList { entries = scores };
        string json = JsonUtility.ToJson(list, true);
        File.WriteAllText(Application.persistentDataPath + "/scores.json", json);
    }

    public void LoadAllDataFromFile()
    {
        string path = Application.persistentDataPath + "/scores.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerScoreList list = JsonUtility.FromJson<PlayerScoreList>(json);
            scores = list.entries;
        }
    }
}