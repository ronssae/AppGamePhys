using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbExp : MonoBehaviour
{
    [SerializeField] private float initialSpeed;
    [SerializeField] private Rigidbody2D bigBox;

    private void Start()
    {
        bigBox.velocity = new Vector2 (-initialSpeed, 0);
    }
}
