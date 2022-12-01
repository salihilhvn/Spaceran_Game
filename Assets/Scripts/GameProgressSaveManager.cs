using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgressSaveManager : MonoBehaviour
{
    string LevelKey = "LevelProgress";

    public void SaveCurrentLevel(int Level)
    {
        PlayerPrefs.SetInt(LevelKey, Level);
    }

    public int GetCurrentLevel()
    {
        return PlayerPrefs.GetInt(LevelKey, 1);
    }
}
