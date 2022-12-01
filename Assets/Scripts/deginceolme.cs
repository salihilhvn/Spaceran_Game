using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class deginceolme : MonoBehaviour
{
    public AudioSource DeadSound;
    bool gameHasEnded;
    public CharacterMovementController movement;
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "engel")
        {
            //DeadSound.Play();
            gameHasEnded = true;
            movement.enabled = false;
            Restart();
            scoresystem.score = 0;
            //DeadSound.Play();
        }

    }
}
