using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour
{
    Animator animator;
    int walkIDanim = -1;
    int idleIDanim = -1;
    void Start()
    {
        animator = GetComponent<Animator>();

        walkIDanim = Animator.StringToHash("Walk");
        idleIDanim = Animator.StringToHash("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool(walkIDanim, true);
            animator.SetBool(idleIDanim, false);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool(walkIDanim, false);
            animator.SetBool(idleIDanim, true);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(Vector3.up, 180);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up, 90);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up, -90);
        }
    }
}
