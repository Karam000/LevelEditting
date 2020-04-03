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
        animator = this.GetComponent<Animator>();

        walkIDanim = Animator.StringToHash("Walk");
        idleIDanim = Animator.StringToHash("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            AnimateWalk();
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            AnimateIdle();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            AnimateWalk();
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            AnimateIdle();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            AnimateWalk();
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            AnimateIdle();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            AnimateWalk();
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            AnimateIdle();
        }
    }

    private void AnimateIdle()
    {
        animator.SetBool(walkIDanim, false);
        animator.SetBool(idleIDanim, true);
    }

    private void AnimateWalk()
    {
        animator.SetBool(walkIDanim, true);
        animator.SetBool(idleIDanim, false);
    }
}
