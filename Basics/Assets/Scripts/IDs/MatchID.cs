using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class MatchID : MonoBehaviour
{
    [FormerlySerializedAs("ID")] public NameID id;
    [FormerlySerializedAs("OnMatch")] public UnityEvent onMatch;
    [FormerlySerializedAs("NoMatch")] public UnityEvent noMatch;
    public bool MatchMade { private get; set; }
    //public List<NameID> nameIDList;
        
    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<MatchID>();
        //var doWorkObj = other.GetComponent<DoWork>();
        //var otherNameID = doWorkObj.nameIDObj;
        
        //foreach (var nameID in nameIDList)
        //{
        //    if (nameID == otherNameID)
        //    {
        //        doWorkObj.Work();
        //    }
        //}
        if (otherID.id == id)
        {
            onMatch.Invoke();
        }
        else
        {
            noMatch.Invoke();
        }

    }
}
