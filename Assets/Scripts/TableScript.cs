using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableScript : MonoBehaviour
{
    private bool hasFlown = false;
    private Rigidbody rb;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !hasFlown)
        {
            rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);

            hasFlown = true;
        }
    }
}
