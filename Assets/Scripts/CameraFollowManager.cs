using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowManager : MonoBehaviour
{
    [SerializeField]
    bool StayPut = false;

    [SerializeField]
    bool FollowOnlyHorizontal = false;

    [SerializeField]
    GameObject ObjectToFollow;

    private Vector3 PositionOffset;

    void Start()
    {
        PositionOffset = transform.position - ObjectToFollow.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!StayPut)
        {
            if (!FollowOnlyHorizontal)
            {
                transform.position = ObjectToFollow.transform.position + PositionOffset;
            }
            else
            {
                transform.position = new Vector3( transform.position.x,
                                                     (ObjectToFollow.transform.position + PositionOffset).y,
                                                       (ObjectToFollow.transform.position + PositionOffset).z );
            }
        }

    }
}
