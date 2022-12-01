using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnCollision : MonoBehaviour
{
    string CollisionAnimKey = "Collided";
    Animator Animator;
    private void Start()
    {
        Animator = GetComponent<Animator>();
    }
    public void ApplyCollisionEffect()
    {
        Animator.SetTrigger(CollisionAnimKey);
    }
}
