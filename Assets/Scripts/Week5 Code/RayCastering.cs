using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastering : MonoBehaviour
{
    [SerializeField] private float rayCastLength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit hit;
        //hit = Physics2D.Raycast(transform.position, Vector2.right, rayCastLength, LayerMask.NameToLayer("Ground"));
        if (Physics2D.Raycast(transform.position, Vector2.right, rayCastLength, 1 << LayerMask.NameToLayer("Ground")))
        {
            Debug.Log("Hit");
        }
        else
        {
            Debug.Log("No Hit");
        }
    }
        
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3.right * rayCastLength));
    }
}
