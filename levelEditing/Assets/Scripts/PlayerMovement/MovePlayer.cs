using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 3.0f;
    float gravity = 20.0f;
    private Vector3 movementForce = Vector3.zero;

    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }



    void Update()
    {
        movementForce = new Vector3(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        movementForce *= speed;


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if ((Mathf.Abs(this.transform.rotation.y)) == 1)
            {
                this.transform.Rotate(Vector3.up, -90);
                movementForce = transform.InverseTransformDirection(movementForce);
            }
            else if(this.transform.rotation.y == 0)
            {
                this.transform.Rotate(Vector3.up, 90);
                movementForce = transform.InverseTransformDirection(movementForce);
            }
            else if (this.transform.rotation.y == -0.7071068f)
            {
                this.transform.Rotate(Vector3.up, 180);
                movementForce = transform.InverseTransformDirection(movementForce);
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if ((Mathf.Abs(this.transform.rotation.y)) == 1)
            {
                this.transform.Rotate(Vector3.up, 90);
                movementForce = transform.InverseTransformDirection(movementForce);
            }
            else if (this.transform.rotation.y == 0)
            {
                this.transform.Rotate(Vector3.up, -90);
                movementForce = transform.InverseTransformDirection(movementForce);
            }
            else if (this.transform.rotation.y == 0.7071068f)
            {
                this.transform.Rotate(Vector3.up, -180);
                movementForce = transform.InverseTransformDirection(movementForce);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.rotation.y == -0.7071068f)
            {
                this.transform.Rotate(Vector3.up, -90);
                movementForce = transform.TransformDirection(movementForce);
            }

            else if (this.transform.rotation.y == 0.7071068f)
            {
                this.transform.Rotate(Vector3.up, 90);
                movementForce = transform.TransformDirection(movementForce);
            }

            else if(this.transform.rotation.y == 0)
            {
                this.transform.Rotate(Vector3.up, 180);
                movementForce = transform.TransformDirection(movementForce);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.rotation.y == -0.7071068f)
            {
                this.transform.Rotate(Vector3.up, 90);
                movementForce = transform.TransformDirection(movementForce);
            }

            else if (this.transform.rotation.y == 0.7071068f)
            {
                this.transform.Rotate(Vector3.up, -90);
                movementForce = transform.TransformDirection(movementForce);
            }

            else if (Mathf.Abs(this.transform.rotation.y) == 1)
            {
                this.transform.Rotate(Vector3.up, -180);
                movementForce = transform.TransformDirection(movementForce);
            }
        }

        movementForce.y -= gravity * Time.deltaTime;

        characterController.Move(movementForce * Time.deltaTime);
    }
}
