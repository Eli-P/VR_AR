using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBinding : MonoBehaviour
{
    public string parentFind = "Pommel";

    private GameObject parent = GameObject.Find("Pommel");
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.parent = parent.transform;
        transform.position = gameObject.transform.parent.position;

        transform.rotation = gameObject.transform.parent.rotation;
    }
}
