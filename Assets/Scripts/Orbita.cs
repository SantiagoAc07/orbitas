using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour
{
    public Transform centerOfMass;

    public float orbitalSpeed = 10f;

    // Update is called once per frame
    void Update(){
        Orbit();

    }
    void Orbit(){

        transform.RotateAround(centerOfMass.position, Vector3.up, orbitalSpeed * Time.deltaTime);
        
    }
}
