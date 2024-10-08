using NaughtyAttributes;
using System.Collections;
using UnityEngine;

public class FreeFall : MonoBehaviour
{
    [Header("Predicted fall time (seconds)")]
    [SerializeField] private float predictedFallTime;
    [Header("Actual fall time (seconds)")]
    [SerializeField] private float actualFallTime;

    private float startHeight, fallStartTime;
    private bool isFalling = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startHeight = transform.position.y;
        predictedFallTime = Mathf.Sqrt(2 * startHeight / Mathf.Abs(Physics2D.gravity.y));
    }

    void Update()
    {
        if (!isFalling && rb.velocity.y < 0)
        {
            isFalling = true;
            fallStartTime = Time.time;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isFalling && collision.gameObject.CompareTag("Ground"))
        {
            isFalling = false;
            actualFallTime = Time.time - fallStartTime;
        }
    }
}