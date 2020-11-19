using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTires : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
        {
            anim.SetBool("Rotate", true);
        }
        else
        {
            anim.SetBool("Rotate", false);
        }
    }
}
