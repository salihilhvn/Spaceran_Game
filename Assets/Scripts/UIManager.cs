using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//
using TMPro;//

public class UIManager : MonoBehaviour
{
    
    [SerializeField]
    TMP_Text LevelInformation;
    [SerializeField]
    TMP_Text LevelEndText;    


    [SerializeField]
    TMP_Text LiveCounter;
    [SerializeField]
    Slider ProgressSlider;

    [SerializeField]
    GameObject GameEndPanel;
    [SerializeField]
    GameObject GameplayPanel;  

    public void UpdateLiveCounter(string TextValue)
    {
        LiveCounter.text = TextValue;
    }

    public void UpdateProgressSlider(float SliderValue)
    {
        ProgressSlider.value = SliderValue;  
    }

    public void UpdateLevelEndText(string TextValue)
    {
        LevelEndText.text = TextValue;
    }
    

    public void UpdateLevelInformation(string TextValue)
    {
        LevelInformation.text = TextValue;
    }

    public void ShowGameplayPanel()
    {
        GameplayPanel.SetActive(true);
        GameEndPanel.SetActive(false);
    }

    public void ShowGameEndPanel()
    {
        GameplayPanel.SetActive(false);
        GameEndPanel.SetActive(true);
    }
}
