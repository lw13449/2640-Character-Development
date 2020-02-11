using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Ridgedbody))]
[RequireComponent(typeof(Collider))]
public class ApplyForce : MonoBehaviour
{
    //Anthony's script requires Ridgedbodies. Attempt finding a solution without
    //ridgedbodies so character can push at crate and then hop on top of it
    
    //private Ridgedbody rb;
    //public Vector3Data forceDirection;
    public float force;
    void Start()
    {
        //rb.GetComponent<Ridgedbody>();
        //rb.AddForce(forceDirection.value*force);
    }

    private void OnCollisionEnter(Collision other)
    {
        //From here, box should move forward with Character in direction
        //character is facing. 
    }
}
