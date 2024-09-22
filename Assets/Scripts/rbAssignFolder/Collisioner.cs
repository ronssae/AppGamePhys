using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisioner : MonoBehaviour
{
    [SerializeField] private List<Rigidbody2D> elastic, inelastic, superInelastic;
    [SerializeField] private float box1_initialVelocity, box2_initialVelocity;

    [Min(0.0001f)]
    [SerializeField] private float box1_mass, box2_mass;

    [Button]
    public void StartDemo()
    {
        //Sets initial velocities
        elastic[0].velocity = new Vector2(box1_initialVelocity, 0);
        inelastic[0].velocity = new Vector2(box1_initialVelocity, 0);
        superInelastic[0].velocity = new Vector2(box1_initialVelocity, 0);
            
        elastic[1].velocity = new Vector2(box2_initialVelocity, 0);
        inelastic[1].velocity = new Vector2(box2_initialVelocity, 0);
        superInelastic[1].velocity = new Vector2(box2_initialVelocity, 0);

        //Sets initial mass
        elastic[0].mass = box1_mass;
        inelastic[0].mass = box1_mass;
        superInelastic[0].mass = box1_mass;

        elastic[1].mass = box2_mass;
        inelastic[1].mass = box2_mass;
        superInelastic[1].mass = box2_mass;

    }
}