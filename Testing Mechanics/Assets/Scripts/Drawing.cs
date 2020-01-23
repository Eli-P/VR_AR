using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    public float forwardInput;
    public float speed = .1f;
    public GameObject cock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = cock.transform.position;
        }
    }
}
