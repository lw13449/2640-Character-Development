﻿using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class WeaponCollectable : Collectable
{
    public UnityEvent useEvent;
    
    public override void Use()
    {
        useEvent.Invoke();
    }

    public void Equip()
    {
        
    }

    public void Upgrade()
    {
        
    }

    public void Attack()
    {
        Debug.Log("Attack" + this);
        
    }
}