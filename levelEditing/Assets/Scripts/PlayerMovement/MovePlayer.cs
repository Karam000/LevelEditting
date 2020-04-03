using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 3.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }



    // trial 3, only up 
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Vertical"), 0.0f, Input.GetAxis("Horizontal"));

        moveDirection *= speed;
        Debug.Log(transform.rotation.y);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if ((Mathf.Abs(this.transform.rotation.y)) == 1)
            {
                this.transform.Rotate(Vector3.up, 90);
                moveDirection = transform.TransformDirection(moveDirection);
            }
            else if(this.transform.rotation.y == 0)
            {
                this.transform.Rotate(Vector3.up, -90);
                moveDirection = transform.TransformDirection(moveDirection);
            }
            else if (this.transform.rotation.y == -0.7071068f)
            {
                this.transform.Rotate(Vector3.up, -180);
                moveDirection = transform.TransformDirection(moveDirection);
            }

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if ((Mathf.Abs(this.transform.rotation.y)) == 0)
            {
                this.transform.Rotate(Vector3.up, 180);
                moveDirection = transform.InverseTransformDirection(moveDirection);
            }
            else if (this.transform.rotation.y == 0.7071068f)
            {
                this.transform.Rotate(Vector3.up, -90);
                moveDirection = transform.InverseTransformDirection(moveDirection);
            }
            else if (this.transform.rotation.y == -0.7071068f)
            {
                this.transform.Rotate(Vector3.up, 90);
                moveDirection = transform.InverseTransformDirection(moveDirection);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.rotation.y == 0)
            {
                this.transform.Rotate(Vector3.up, 90);
                moveDirection = transform.TransformDirection(moveDirection);
            }

            else if (Mathf.Abs(transform.rotation.y) == 1)
            {
                this.transform.Rotate(Vector3.up, -90);
                moveDirection = transform.TransformDirection(moveDirection);
            }

            else if (this.transform.rotation.y == -0.7071068f)
            {
                this.transform.Rotate(Vector3.up, 180);
                moveDirection = transform.TransformDirection(moveDirection);
            }





            //if ((Mathf.Abs(this.transform.rotation.y)) == 0)
            //{
            //    this.transform.Rotate(Vector3.up, 90);
            //    moveDirection = transform.InverseTransformDirection(moveDirection);
            //}
            //else if ((Mathf.Abs(this.transform.rotation.y)) == 0.7071068f)
            //{
            //    this.transform.Rotate(Vector3.up, 90);
            //    moveDirection = transform.InverseTransformDirection(moveDirection);
            //}
            //else if ((Mathf.Abs(this.transform.rotation.y)) == -0.7071068f)
            //{
            //    this.transform.Rotate(Vector3.up, 90);
            //    moveDirection = transform.InverseTransformDirection(moveDirection);
            //}
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.rotation.y == 0)
            {
                this.transform.Rotate(Vector3.up, -90);
                moveDirection = transform.TransformDirection(moveDirection);
            }

            else if (Mathf.Abs(transform.rotation.y) == 1)
            {
                this.transform.Rotate(Vector3.up, 90);
                moveDirection = transform.TransformDirection(moveDirection);
            }

            else if (this.transform.rotation.y == 0.7071068f)
            {
                this.transform.Rotate(Vector3.up, -180);
                moveDirection = transform.TransformDirection(moveDirection);
            }
        }

        //moveDirection = transform.TransformDirection(moveDirection);

        moveDirection.y -= gravity * Time.deltaTime;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
