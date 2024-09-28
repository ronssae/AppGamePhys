using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerate3D : MonoBehaviour
{
    [SerializeField] private float initialVelocity, finalVelocity, duration;
    [SerializeField] private Rigidbody rb;
    private bool start;
    private float timer;
    private bool decelerate;

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            timer += Time.deltaTime;

            if (!decelerate)
            {
                rb.velocity = Vector3.Lerp(new Vector3(initialVelocity, 0f), new Vector3(finalVelocity, 0f), timer / duration);

                if (timer >= duration)
                {
                    timer = 0;
                    decelerate = true;
                }
            }
            else if (decelerate)
            {
                rb.velocity = Vector3.Lerp(new Vector3(finalVelocity, 0f), new Vector3(initialVelocity, 0f), timer / duration);
            }
        }
    }

    [Button]
    public void TestDemo()
    {
        start = true;
        timer = 0f;
        decelerate = false;
    }
}
