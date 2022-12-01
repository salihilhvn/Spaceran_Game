using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    UIManager UIManager;
    GameProgressSaveManager GameProgressSaveManager;
    LevelManager LevelManager;
    LevelProgressManager LevelProgressManager;
    private void Awake()
    {
        List<GameManager> gameManagers = FindObjectsOfType<GameManager>().ToList();

        if (gameManagers.Count > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {

        GameProgressSaveManager = FindObjectOfType<GameProgressSaveManager>();
        LevelManager = FindObjectOfType<LevelManager>();
        UIManager = FindObjectOfType<UIManager>();
        LevelProgressManager = FindObjectOfType<LevelProgressManager>();
        LevelProgressManager.SetGameLevel(GameProgressSaveManager.GetCurrentLevel());
      
    }

    public void StartGameLoop()
    {
        LevelManager.StartLevel();
        UIManager.ShowGameplayPanel();
    }

    public void GameLoopFinished()
    {
        UIManager.ShowGameEndPanel();
    }


    private void OnApplicationQuit()
    {
        GameProgressSaveManager.SaveCurrentLevel(LevelProgressManager.GetGameLevel());
    }

}
