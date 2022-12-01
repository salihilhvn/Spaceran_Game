using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienturn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(true) {
            transform.Rotate(0, 0.1f, 0);

            if (transform.rotation.y == 230.0)
                transform.Rotate(0, -0.1f, 0);
            break;
    }
    }
}
