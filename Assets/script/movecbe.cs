using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecbe : MonoBehaviour {

    
    private Rigidbody rb;
    private Vector3 defaultPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }

    void FixedUpdate()
    {
        rb.MovePosition(new Vector3(defaultPos.x, defaultPos.y + Mathf.PingPong(Time.time,7), defaultPos.z));
    }
}
