using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowlimbleft : MonoBehaviour
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
        forwardInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward * speed * forwardInput);
    }
}
