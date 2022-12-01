using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    [SerializeField]
    bool MoveWithForce;

    [SerializeField]
    bool MoveLeftRight;
    
    [SerializeField]
    float MousePositionForceMultiplier = 5;

    [SerializeField]
    float VerticalDisplacementSpeed = 10;

    Rigidbody CharacterRigidbody;
    Vector3 PressStartPosition;

    Vector3 StartPosition;
    void Start()
    {
        CharacterRigidbody = GetComponent<Rigidbody>();
        StartPosition = transform.position;
    }



    void Update()
    {
        if (MoveWithForce)
        {
            MoveWithRigidBodyForce();
        }
        else if(MoveLeftRight)
        {
            MoveWithRigidBodyPosition();
        }
    }


    void MoveWithRigidBodyForce()
    {

        if (Input.GetMouseButtonDown(0))
        {
            PressStartPosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Vector3 MousePosDifference = Input.mousePosition - PressStartPosition;
            CharacterRigidbody.AddForce(new Vector3(MousePosDifference.x,0,MousePosDifference.y)*MousePositionForceMultiplier);
        }
    }

    void MoveWithRigidBodyPosition()
    {
        if (Input.GetMouseButton(0))
        {
            float XMovement = Input.GetAxis("Mouse X");
            CharacterRigidbody.MovePosition(transform.position + VerticalDisplacementSpeed * Time.deltaTime * Vector3.forward + XMovement * Vector3.right);
        }
        else
        {
            CharacterRigidbody.MovePosition(transform.position + VerticalDisplacementSpeed * Time.deltaTime * Vector3.forward);
        }
    }








    public void StopAndResetPlayerController()
    {
        transform.position = StartPosition;
        CharacterRigidbody.velocity = Vector3.zero;
        CharacterRigidbody.constraints = RigidbodyConstraints.FreezeAll;
    }
    public void EnablePlayerMovement()
    {
        CharacterRigidbody.constraints = RigidbodyConstraints.None;
    }



}
