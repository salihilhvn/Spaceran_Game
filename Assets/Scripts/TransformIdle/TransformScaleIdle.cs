using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScaleIdle : MonoBehaviour
{
    float CurrentScale;

    [Range(0,1)]
    [SerializeField]
    float MinimumScale = 0.5f;

    void Update()
    {
        CurrentScale = Mathf.PingPong(Time.time, 1-MinimumScale) + MinimumScale;
        transform.localScale = Vector3.one * CurrentScale;
    }
}
