using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TestingLessons : MonoBehaviour
{
    [SerializeField] private float timer, speed, distance, time, acceleration, duration, maxSpeed, upWard, yAxis;
    [SerializeField] private TextMeshProUGUI uiText;
    private float gravity = 9.81f;
    private float smooth = 3.0f;
    private float tiltAngle = 50.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = distance / time;
        upWard = Mathf.Sqrt(2f * gravity * yAxis);
    }

    void Update()
    {
        rb.velocity = new Vector2(speed, 0);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            timer += Time.deltaTime;
            acceleration = Mathf.Lerp(speed, maxSpeed, timer / duration);
            rb.velocity = new Vector2(acceleration, 0);

            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = new Vector2(acceleration - 5f, upWard);
                Rotate();
            }
            else if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = new Vector2(acceleration + 5f, -upWard);
                Rotate();
            }

        }
        else
        {
            timer = 0;
            rb.velocity = new Vector2(speed, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(speed - 5f, upWard);
            Rotate();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(speed + 5f, -upWard);
            Rotate();
        }

        uiText.text = "Velocity: " + rb.velocity;
    }
    void Rotate()
    {
        float tiltAroundZ = Input.GetAxis("Vertical") * tiltAngle;
        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}