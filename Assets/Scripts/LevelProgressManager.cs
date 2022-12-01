using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProgressManager : MonoBehaviour
{

    int GameLevel;

    public void SetGameLevel(int level)
    {
        GameLevel = level;
    }

    public int GetGameLevel()
    {
        return GameLevel;
    }

    public void ProgressLevel()
    {
        GameLevel++;
    }



}
