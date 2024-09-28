using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectory3D : MonoBehaviour
{
    [SerializeField] private float yAxis, time, distance;
    [SerializeField] private Rigidbody rb;

    [Button]
    public void TestDemo()
    {
        rb.velocity = new Vector2(distance / time, Mathf.Sqrt(2 * Mathf.Abs(Physics.gravity.y) * yAxis));
    }
}