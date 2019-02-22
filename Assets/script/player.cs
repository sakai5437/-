using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rigid;
    float jumpForce = 200.0f;
   
    
        void Start()
    {
        this.rigid = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    public float speed = 10.0f;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.rigid.AddForce(transform.up * this.jumpForce);
        }

        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
    
    
    
    
}
