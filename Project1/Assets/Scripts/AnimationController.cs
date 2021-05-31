using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //attached to the player so the animation had acces to Disable function
    Animator playerAnimator;

    private void Awake()
    {
        playerAnimator = gameObject.GetComponent<Animator>();
    }
    //this is for player animation end for it to be put into an empty state once it is done doing a flip
    private void Disable()
    {
        playerAnimator.Play("New State");
    }
}
