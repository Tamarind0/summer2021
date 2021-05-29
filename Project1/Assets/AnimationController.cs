using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator playerAnimator;

    private void Awake()
    {
        playerAnimator = gameObject.GetComponent<Animator>();
    }

    private void Disable()
    {
        playerAnimator.Play("New State");
    }
}
