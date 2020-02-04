using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pommel : MonoBehaviour
{
    public GameObject pommel1;
    public GameObject pommel2;
    public float switc;
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = pommel1.transform;
    }

    // Update is called once per frame
    void Update()
    {
        switc = Input.GetAxis("Vertical");
        if (switc > .5)
        {

            transform.parent = pommel2.transform;
            transform.position = pommel2.transform.position;
        }
        else if (switc < -.5)
        {

            transform.parent = pommel1.transform;
            transform.position = pommel1.transform.position;
        }

        transform.position = gameObject.transform.parent.position;

        transform.rotation = gameObject.transform.parent.rotation;
    }
}
