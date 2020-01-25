using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoWork : MonoBehaviour
{
    public NameID nameIDObj;
	public UnityEvent changeLocation;

    public void Work()
    {
        nameIDObj.GetComponent<UnityEvent>.changeLocation;
    }
}
