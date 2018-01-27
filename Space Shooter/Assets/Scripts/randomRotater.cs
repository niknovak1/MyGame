using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomRotater : MonoBehaviour {

    public float tumble;

    void Start()
    {
        Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
