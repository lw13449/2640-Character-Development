﻿using System;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourID : IdBehaviour
{
    //public WorkSystemManager workSystemManagerObj;
    public NameID otherIdObj;

    private void OnTriggerEnter(Collider other)
    {
        otherIdObj = other.GetComponent<IdBehaviour>().nameIdObj;
        CheckId();
    }

    private void CheckId()
    {
        //foreach (var obj in workSystemManagerObj.workIdList)
        //{
        //    if (otherIdObj == obj.nameIdObj)
        //    {
        //        obj.workSystemObj.Work();
        //        obj.workEvent.Invoke();
        //    }
        //}
    }
}