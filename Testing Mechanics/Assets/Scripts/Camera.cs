using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 5;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Mouse Y");
        forwardInput = Input.GetAxis("Mouse X");
        //transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * forwardInput);
        transform.Rotate(Vector3.right, Time.deltaTime * turnSpeed * horizontalInput * -1);

    }
}
