using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    public GameObject explozion;
    public GameObject playerexplozion;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "boundary") { return; }
        Instantiate(explozion, transform.position, transform.rotation);
        if(other.tag == "player")
        {
            Instantiate(playerexplozion, transform.position, transform.rotation);
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
