using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectory : MonoBehaviour
{
    [SerializeField] private float y_axis, time, distance;
    [SerializeField] private GameObject player;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }
    [Button]
    public void StartDemo()
    {
        rb.velocity = new Vector2((distance / time), (Mathf.Sqrt(2f * 9.81f * y_axis)));
    }
}