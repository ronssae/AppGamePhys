using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectory : MonoBehaviour
{
    [SerializeField] private float y_axis, time, distance;
    [SerializeField] private Rigidbody2D rb;
    private float speed, velocity;
    private float gravity = 9.81f;

    private void Start()
    {
        speed = distance / time;
        velocity = Mathf.Sqrt(2 * gravity * y_axis);
    }

    [Button]
    public void StartDemo()
    {
        rb.velocity = new Vector2(speed, velocity);
    }
}