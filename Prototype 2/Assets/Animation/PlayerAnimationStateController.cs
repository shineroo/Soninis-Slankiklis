using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationStateController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else animator.SetBool("isWalking", false);

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("isFiring", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("isFiring", false);
        }
    }
}
