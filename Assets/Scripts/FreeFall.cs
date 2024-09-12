using NaughtyAttributes;
using System.Collections;
using UnityEngine;

public class FreeFall : MonoBehaviour
{
    public float predictedFallTime;
    private float actualFallTime;
    private bool isFalling = false;

    void Start()
    {
        actualFallTime = 0f;
    }

    void Update()
    {
        if (isFalling)
        {
            actualFallTime += Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isFalling = false;

            float timeDifference = Mathf.Abs(predictedFallTime - actualFallTime);
            Debug.Log($"Time Difference: {timeDifference}");
            if (timeDifference > 1f)
            {
                Debug.LogWarning("Time difference exceeds 1 second!");
            }
        }
    }

    public void StartFalling()
    {
        isFalling = true;
        actualFallTime = 0f;
    }
}
