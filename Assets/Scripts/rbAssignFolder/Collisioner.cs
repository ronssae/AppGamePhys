using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisioner : MonoBehaviour
{
    [SerializeField] private Rigidbody2D box1, box2;
    [SerializeField] private float box1_initialVelocity, box2_initialVelocity;

    [Min(0.0001f)]
    [SerializeField] private float box1_mass, box2_mass;

    [Button]
    public void StartDemo()
    {
            box1.velocity = new Vector2(box1_initialVelocity, 0);
            box2.velocity = new Vector2(box2_initialVelocity, 0);
            box1.mass = box1_mass;
            box2.mass = box2_mass;
    }
}