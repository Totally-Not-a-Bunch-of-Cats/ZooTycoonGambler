using System;
using UnityEngine;

[Serializable]
public class Employee : MonoBehaviour
{
    public float moveSpeed = 1f;

    public Rigidbody2D rigidBody2D;

    public virtual void DoEffect()
    {
        
    }
}