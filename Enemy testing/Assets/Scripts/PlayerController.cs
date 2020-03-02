using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 50;
    public float horizontalInput;
    public float jumpInput;
    public float forwardInput;
    public float rightInput;
    public Rigidbody rigidbody;
    public int jump = 10;
    public bool ground;
    public bool
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Mouse X");
        forwardInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 5 * forwardInput);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {

            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        }
        rightInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * rightInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        jumpInput = Input.GetAxis("Jump");
        if (ground)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.AddForce(Vector3.up * jump, ForceMode.Impulse);
                ground = false;
            }
        }
        //transform.Translate(Vector3.up * Time.deltaTime * speed * jumpInput);
    }
    private void OnCollisionEnter(Collision collision)
    {
        ground = true;
    }
}
