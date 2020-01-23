using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatehandle : MonoBehaviour
{
    public float forwardInput;
    public float speed = .1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.right* speed * forwardInput);
    }
}
