using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_mov : MonoBehaviour
{
    Vector3 offset;
    public Camera Gholam;
    public float MovementSpeed;
    
    // Use this for initialization
    void Start()
    {
        offset = Gholam.transform.position - transform.position;
        
        MovementSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * MovementSpeed;
        }
        Gholam.transform.position = transform.position + offset;
    }
}
