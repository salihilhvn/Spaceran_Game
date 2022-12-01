using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoresystem : MonoBehaviour
{
    public GameObject scoreText;

    public static int score;

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + score; 
    }
}
