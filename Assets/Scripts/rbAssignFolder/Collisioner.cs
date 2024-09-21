using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisioner : MonoBehaviour
{
    [SerializeField] private List<Rigidbody2D> boxes;
    [SerializeField] private float box1_initialVelocity, box2_initialVelocity;

    [Min(0.0001f)]
    [SerializeField] private float box1_mass, box2_mass;

    [Button]
    public void StartDemo()
    {
            boxes[0].velocity = new Vector2(box1_initialVelocity, 0);
            boxes[1].velocity = new Vector2(box2_initialVelocity, 0);
            boxes[0].mass = box1_mass;
            boxes[1].mass = box2_mass;
    }
}