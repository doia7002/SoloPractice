using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoloPlayerCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    private float _timeSInceLastAttack = float.MaxValue;
    protected bool IsAttacking { get; set; }

    protected virtual void Update()
    {
        HandleAttackDelay();
    }
    private void HandleAttackDelay()
    {
        if (_timeSInceLastAttack <= 0.2f)
        { 
            _timeSInceLastAttack += Time.deltaTime;
        }
        if (IsAttacking&&_timeSInceLastAttack>0.2f)
        {
            _timeSInceLastAttack = 0;
            CallAttackEvent();
        }
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction) 
    {  
        OnLookEvent?.Invoke(direction); 
    }
    public void CallAttackEvent()
    { 
        OnAttackEvent?.Invoke();
    }
    
}
