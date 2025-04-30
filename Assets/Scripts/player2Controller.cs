using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Controller : MonoBehaviour
{
    [SerializeField]
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput, verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            //move the vehicle forward
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
            Debug.Log(Time.deltaTime * turnSpeed * horizontalInput);
        }
    }
}
