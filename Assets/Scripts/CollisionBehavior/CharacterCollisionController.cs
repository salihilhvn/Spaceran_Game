using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisionController : MonoBehaviour
{

    LevelManager LevelManager;

    private void Start()
    {
        LevelManager = FindObjectOfType<LevelManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out ChangeColorOncollision cco))
        {
            cco.ApplyCollisionEffect();
        }
        if(collision.gameObject.TryGetComponent(out PlayAudioOnCollision paoc))
        {
            paoc.ApplyCollisionEffect();
        }
        if(collision.gameObject.TryGetComponent(out GetDestroyerOnCollision gdoc))
        {
            gdoc.ApplyCollisionEffect();
        }
        if(collision.gameObject.TryGetComponent(out PlayAnimationOnCollision pao))
        {
            pao.ApplyCollisionEffect();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ChangeColorOncollision cco))
        {
            cco.ApplyCollisionEffect();
        }
        if (other.TryGetComponent(out PlayAudioOnCollision paoc))
        {
            paoc.ApplyCollisionEffect();
        }
        if (other.TryGetComponent(out GetDestroyerOnCollision gdoc))
        {
            gdoc.ApplyCollisionEffect();
        }
        if (other.TryGetComponent(out PlayAnimationOnCollision pao))
        {
            pao.ApplyCollisionEffect();
        }


        if (other.gameObject.CompareTag("Obstacle"))
        {
            LevelManager.CollisionWithObstacle();
        }
        else if (other.gameObject.CompareTag("PickUp"))
        {
            LevelManager.CollisionwithPickUpObject();
        }

    }


}
