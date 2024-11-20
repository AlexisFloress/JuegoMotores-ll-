using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorplayer : MonoBehaviour
{
    public Animator animator;
    private float x, y;
    void Update()
    {
        animator.SetFloat("Velx", x);
        animator.SetFloat("Vely", y);
    }
}
