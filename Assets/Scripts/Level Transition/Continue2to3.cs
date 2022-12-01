using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue2to3 : MonoBehaviour
{
    public void ContinueButton()
    {
        SceneManager.LoadScene(5);
    }
}