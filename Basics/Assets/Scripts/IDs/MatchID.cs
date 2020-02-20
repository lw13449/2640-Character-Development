﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MatchID : MonoBehaviour
{
    public List<NameID> nameIDList;
        
    private void OnTriggerEnter(Collider other)
    {
        var doWorkObj = other.GetComponent<DoWork>();
        var otherNameID = doWorkObj.nameIDObj;
        
        foreach (var nameID in nameIDList)
        {
            if (nameID == otherNameID)
            {
                doWorkObj.Work();
            }
        }

    }
}
