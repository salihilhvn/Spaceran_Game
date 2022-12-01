using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotateIdle : MonoBehaviour
{
    [SerializeField]
    Vector3 RotationSpeed = new Vector3(0,120,0);

    void Update()
    {
        transform.Rotate( RotationSpeed * Time.deltaTime);
    }
}
