using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDestroyerOnCollision : MonoBehaviour
{
    
    public void ApplyCollisionEffect()
    {
        Destroy(gameObject);
    }
}
