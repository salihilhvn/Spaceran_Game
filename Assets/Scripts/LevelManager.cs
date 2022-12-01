using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    int PickUpCount;
    int ObstacleCount;

    int StartingLiveCount = 3;

    int PickUpCounter;
    int LiveCounter;

 
    CharacterMovementController CharacterMovementController;
    UIManager UIManager;
    GameManager GameManager;
    LevelCreateManager LevelCreateManager;
    LevelProgressManager LevelProgressManager;

    void Awake()
    {
        LevelCreateManager = FindObjectOfType<LevelCreateManager>();
        CharacterMovementController = FindObjectOfType<CharacterMovementController>();
        UIManager = FindObjectOfType<UIManager>();
        LevelProgressManager = FindObjectOfType<LevelProgressManager>();
        GameManager = FindObjectOfType<GameManager>();

    }


    public void StartLevel()
    {
        PickUpCounter = 0;
        LiveCounter = StartingLiveCount;
        CharacterMovementController.EnablePlayerMovement();
  List<int> LevelObjCounts = LevelCreateManager.DecodeLevelInformation(LevelProgressManager.GetGameLevel());
        PickUpCount = LevelObjCounts[0];
        ObstacleCount = LevelObjCounts[1]; 
        UIManager.UpdateLevelInformation("Level" + LevelProgressManager.GetGameLevel().ToString());
        UIManager.UpdateLiveCounter(LiveCounter.ToString() + "/" + StartingLiveCount.ToString());
        UIManager.UpdateProgressSlider(PickUpCounter / (float)PickUpCount);


      
    }


   

    public void CollisionWithObstacle()
    {
        LiveCounter--;
        if (LiveCounter == 0)
        {
            ShowGameResult(false);
        }

        UIManager.UpdateLiveCounter(LiveCounter.ToString() + "/" + StartingLiveCount.ToString());
    }


    public void CollisionwithPickUpObject()
    {
        PickUpCounter++;
        if (PickUpCount == PickUpCounter)
        {

            ShowGameResult(true);
        }

        UIManager.UpdateProgressSlider(PickUpCounter / (float)PickUpCount);
    }



    void ShowGameResult(bool IsWon)
    {

        if (IsWon)
        {
            LevelProgressManager.ProgressLevel();

            UIManager.UpdateLevelEndText("YOU WON!");
        }
        else
        {
            UIManager.UpdateLevelEndText("YOU LOST!");
        }

        GameManager.GameLoopFinished();

        CharacterMovementController.StopAndResetPlayerController();
        LevelCreateManager.ClearLevel();

    }
}





