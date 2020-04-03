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
            AnimateWALK();
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            AnimateIDLE();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            AnimateWALK();
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            AnimateIDLE();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            AnimateWALK();
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            AnimateIDLE();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            AnimateWALK();
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            AnimateIDLE();
        }
    }

    private void AnimateIDLE()
    {
        animator.SetBool(walkIDanim, false);
        animator.SetBool(idleIDanim, true);
    }

    private void AnimateWALK()
    {
        animator.SetBool(walkIDanim, true);
        animator.SetBool(idleIDanim, false);
    }
}
