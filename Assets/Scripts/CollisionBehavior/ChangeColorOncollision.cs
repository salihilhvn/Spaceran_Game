using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOncollision : MonoBehaviour
{

    MeshRenderer MeshRenderer;
    [SerializeField]
    Color CollisionColor;

    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer = GetComponent<MeshRenderer>();    
    }

    public void ApplyCollisionEffect()
    {
        MeshRenderer.material.color = CollisionColor;
    }
}
