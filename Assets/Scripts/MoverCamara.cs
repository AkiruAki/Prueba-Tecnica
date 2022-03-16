using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    float movement = 0;
    float speed = 15;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            movement += speed;
        else if (Input.GetKeyUp(KeyCode.W))
            movement -= speed;

        if (Input.GetKeyDown(KeyCode.S))
            movement -= speed;
        else if (Input.GetKeyUp(KeyCode.S))
            movement += speed;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(transform.up, 2);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(transform.up, -2);

        if (Input.GetKey(KeyCode.Space))
            transform.Translate(new Vector3(0, 0.5f,0));
        if (Input.GetKey(KeyCode.LeftControl))
            transform.Translate(new Vector3(0, -0.5f, 0));

        rb.velocity = transform.forward * movement;

    }
}
