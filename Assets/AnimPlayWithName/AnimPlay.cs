using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlay : MonoBehaviour
{
    Animator anim;
    [SerializeField] string animName = "Idle_A";
    [SerializeField] float animSpeed = .6f;
    private void Start()
    {
        anim = GetComponent<Animator>();

        anim.Play(animName);
        anim.speed = 0;
        Invoke(nameof(AnimStarter), Random.Range(.01f, .2f));
    }

    void AnimStarter()
    {
        anim.speed = animSpeed;
    }
}