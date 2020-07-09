using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriftingAnimationController : MonoBehaviour
{
    private Animator animator;
    public void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        bool isDrifting=false;
        if(Input.GetKey(KeyCode.Space)&& (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A)))
        {
            animator.SetBool("leftDrift",true);
            GetComponentInParent<ArcadeKart>().Drift();
            isDrifting = true;
        }
        else
        {
            animator.SetBool("leftDrift", false);
           
        }
        if(Input.GetKey(KeyCode.Space)&& (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
        {
            animator.SetBool("rightDrift",true);
            GetComponentInParent<ArcadeKart>().Drift();
            isDrifting = true;
        }
        else
        {
            animator.SetBool("rightDrift", false);
           
        }
        if (!isDrifting)
        {
            GetComponentInParent<ArcadeKart>().StopDrift();
        }

    }
}
