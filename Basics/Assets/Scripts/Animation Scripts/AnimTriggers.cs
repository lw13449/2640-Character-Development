using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTriggers : MonoBehaviour
{
    private Animator _jump;
    private Animator _walk;
    private Animator _left;
    private Animator _right;

    public void Start()
    {
        _right = this.GetComponent<Animator>();
        _left = this.GetComponent<Animator>();
        _walk = this.GetComponent<Animator>();
        _jump = this.GetComponent<Animator>();
        this.GetComponent<Animator>().SetTrigger("Idle");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jump.SetTrigger("Jump");
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            _walk.SetTrigger("Walk");
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            _left.SetTrigger("Left");
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            _right.SetTrigger("Right");
        }
    }
}
