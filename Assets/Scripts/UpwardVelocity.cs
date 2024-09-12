using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardVelocity : MonoBehaviour
{
    [SerializeField] private bool haveVelocity, haveY_axis;
    [SerializeField] private float velocity, y_axis;
    private float gravity = 9.81f;
    [SerializeField] private Rigidbody2D rb;
    private bool start;
    private bool timer;

    private void Start()
    {
        if (haveVelocity)
        {
            y_axis = (velocity * velocity) / (2 * gravity);
        }
        else if (haveY_axis)
        {
            velocity = Mathf.Sqrt(2 * gravity * y_axis);
        }
    }
    private void FixedUpdate()
    {
        if (start)
        {
            rb.velocity = new Vector2 (0f, velocity);
            start = false;
        }
    }

    [Button]
    public void StartDemo()
    {
        start = true;
    }
}
