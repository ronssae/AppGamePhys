using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics1 : MonoBehaviour
{
    public Rigidbody2D rb;

    private float speed;
    [SerializeField] private float distance;
    [SerializeField] private float time;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Calculate speed
        speed = distance / time;

        // Set the target velocity
        Vector2 targetVelocity = transform.right * speed; // Assuming you want to move to the right

        // Use Lerp to smoothly change the velocity
        rb.velocity = Vector2.Lerp(rb.velocity, targetVelocity, Time.deltaTime / time);
    }
}