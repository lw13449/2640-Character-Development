using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class AiBrain : ScriptableObject
{
    public AiBase aiBaseObj;

    public void ChangeBase(AiBase obj)
    {
        aiBaseObj = obj;
    }

    public void Navigate(NavMeshAgent agent)
    {
        aiBaseObj.RunAgent(agent);
    }
}