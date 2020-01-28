using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTriggers : MonoBehaviour
{
    public void Jump()
    {
        if (Input.GetKeyDown("c"))
        {
            this.GetComponent<Animator>().SetTrigger("Jump");
        }
        else
        {
            GetComponent<Animator>().SetTrigger("Idle");
        }
    }
    
    public void Walk()
    {
        if (Input.GetKeyDown("w"))
        {
            this.GetComponent<Animator>().SetTrigger("Walk");
        }
        else
        {
            GetComponent<Animator>().SetTrigger("Idle");
        }
    }
    public void WalkLeft()
    {
        if (Input.GetKeyDown("a"))
        {
            this.GetComponent<Animator>().SetTrigger("Left");
        }
        else
        {
            GetComponent<Animator>().SetTrigger("Idle");
        }
    }
    public void WalkRight()
    {
        if (Input.GetKeyDown("d"))
        {
            this.GetComponent<Animator>().SetTrigger("Right");
        }
        else
        {
            GetComponent<Animator>().SetTrigger("Idle");
        }
    }
}
