using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AnimationStateContoller : MonoBehaviour

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
       if(Input.GetKey("q"))
        {
            animator.SetBool("IsWarmingUp", true);
            UnityEngine.Debug.Log("Warming up!");
        }

       if(!Input.GetKey("q"))
        {
            animator.SetBool("IsWarmingUp", false);
        }

        if (Input.GetKey("w"))
        {
            animator.SetBool("IsDoingSimpleDance", true);
            UnityEngine.Debug.Log("Getting into the groove!");
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("IsDoingSimpleDance", false);
        }

        if (Input.GetKey("e"))
        {
            animator.SetBool("IsDoingAdvancedMove", true);
            UnityEngine.Debug.Log("Amazing technique!");
        }

        if (!Input.GetKey("e"))
        {
            animator.SetBool("IsDoingAdvancedMove", false);

        }
        if (Input.GetKey("r"))
        {
            animator.SetBool("IsDoingFinalMove", true);
            UnityEngine.Debug.Log("Showstopper!");
        }

        if (!Input.GetKey("r"))
        {
            animator.SetBool("IsDoingFinalMove", false);
        }
    }
}
