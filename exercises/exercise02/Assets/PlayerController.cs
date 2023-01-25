using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.001f;
    public float lauchForce = 9999;

    float rotateSpeed = 15f;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 newPosition = new Vector3(gameObject.transform.position.x + 0.05f, gameObject.transform.position.y, gameObject.transform.position.z);
        // gameObject.transform.position = newPosition;
            if (Input.GetKey(KeyCode.Space))
            {
                gameObject.transform.Translate(gameObject.transform.forward * speed);
                rb. AddForce(gameObject.transform.forward * lauchForce);
            }
        

    }
}
