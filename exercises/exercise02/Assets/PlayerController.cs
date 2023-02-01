using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.001f;
    public float lauchForce = 100;

    float rotateSpeed = 0.1f;

    public Rigidbody rb;

    float lastRotateDirectionSwitchTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Time.time - lastRotateDirectionSwitchTime > 1f)
        // {
        //     rotateSpeed = rotateSpeed * -1;
        //     lastRotateDirectionSwitchTime = Time.time;
        // }
        // gameObject.transform.Rotate(0, rotateSpeed, 0);

        // Vector3 newPosition = new Vector3(gameObject.transform.position.x + 0.05f, gameObject.transform.position.y, gameObject.transform.position.z);
        // gameObject.transform.position = newPosition;
            if (Input.GetKey(KeyCode.Space))
            {
                gameObject.transform.Translate(gameObject.transform.forward * speed);
                rb. AddForce(gameObject.transform.forward * lauchForce);
            }
        

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "TargetCube")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.red;

            // If you wanted to remove the cube rather than change its color, you
            // would "Destroy" it using the following line of code.
            //Destroy(col.gameObject);
        }
    }
}
