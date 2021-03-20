using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour {

    Animator animator;

    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

        if(Input.GetKeyDown("h")) {
            animator.SetBool("isRunning", true);
        }
        
        else if(Input.GetKeyUp("h")) {
            animator.SetBool("isRunning", false);
        }

        else if(Input.GetKeyDown("b")) {
            animator.SetBool("isDancing", true);
        }
        
        else if(Input.GetKeyUp("b")) {
            animator.SetBool("isDancing", false);
        }

    }
}
