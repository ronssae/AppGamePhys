using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics1 : MonoBehaviour
{
    [SerializeField] private bool haveSpeed, haveDistance, haveTime;
    [SerializeField] private float speed, distance, time;
    [SerializeField] private Rigidbody2D rb2d;
    private bool start;
    private float timer;

    private void Start()
    {
        if (haveSpeed && haveDistance)
        {
            time = distance / speed;
        }
        else if (haveSpeed && haveTime)
        {
            distance = speed * time;
        }
        else if (haveDistance && haveTime)
        {
            speed = distance / time;
        }
    }

    private void Update()
    {
        if (start)
        {
            timer += Time.deltaTime;
            if (timer < time)
            {
                rb2d.velocity = new Vector2(speed, 0f);
            }
            else
            {
                rb2d.velocity = Vector2.zero;
            }
        }
    }

    [Button]
    public void StartDemo()
    {
        start = true;
    }
}