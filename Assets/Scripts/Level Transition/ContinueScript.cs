using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueScript : MonoBehaviour
{
    public void ContinueButton()
    {
        SceneManager.LoadScene(3);
    }
}