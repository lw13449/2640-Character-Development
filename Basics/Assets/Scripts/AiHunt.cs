using System;
using UnityEngine;
using UnityEngine.AI;

public class AiHunt : AiBase
{
    public GameAction destinationAction;
    [HideInInspector]
    public Transform destination;

    protected void OnEnable()
    {
        if (destinationAction != null) destinationAction.raise += Raise;
    }

    protected void Raise(object obj)
    {
        destination = obj as Transform;
    }

    public override void RunAgent(NavMeshAgent agent)
    {
        agent.speed = speed.value;
        agent.angularSpeed = angularSpeed.value;
        //agent.destination = (destination != null ? destination.position);
    }
}