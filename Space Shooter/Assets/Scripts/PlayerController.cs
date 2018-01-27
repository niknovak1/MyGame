using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}
public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;
    public float tilt;
    public Boundary bound;
    public GameObject shot;
    public Transform ShotSpawn;

    private float nextFire;
    public float fireRate;

    private void Update()
    {

        if (Input.GetButton("Jump") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, ShotSpawn.position, ShotSpawn.rotation);
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;

        rb.position = new Vector3(Mathf.Clamp(rb.position.x,bound.xMin,bound.xMax), 0.0f, Mathf.Clamp(rb.position.z, bound.zMin, bound.zMax));
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x*(-tilt));
    }
}

