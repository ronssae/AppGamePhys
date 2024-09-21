using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGame : MonoBehaviour
{
    [SerializeField] private float target, origin;
    [SerializeField] private float magnitude;
    private Rigidbody2D rb;
    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        magnitude = Mathf.Sqrt((rb.transform.position.x * rb.transform.position.x) + (rb.transform.position.y * rb.transform.position.y));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
