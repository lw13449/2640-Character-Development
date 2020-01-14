using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour
{
    public NameID nameIDOBJ;
        
    private void OnTriggerEnter(Collider other)
    {
        var otherNameID = other.GetComponent<MatchID>().nameIDOBJ;
        if (nameIDOBJ == null) return;
        var otherNameID = nameIDOBJ;
        if (nameIDOBJ == otherNameID)
        {
            //do work
        }

    }
    //check for multiple objects; check to see if it is more than one object. Like how many NameIDs it can have
    //the problem with the name and tag is it can only have one thing. 
    //How can I take an object running into another object and check it for multiple nameIDs
}
