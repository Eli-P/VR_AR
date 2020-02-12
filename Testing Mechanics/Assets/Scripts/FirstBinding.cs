using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBinding : MonoBehaviour
{
    public string parentFind = "Pommel";
    public string KeyBind = "P";
    public GameObject player;
    public GameObject parent;
    public float pickupRange = 10;
    //public Rigidbody rigidbody;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find(parentFind);
        dist = Vector3.Distance(transform.position, player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
        if (Input.GetKeyDown(KeyCode.P) && dist < pickupRange)
        {
            if (transform.parent == null)
            {
                //transform.rotation = gameObject.transform.parent.rotation;
                transform.parent = parent.transform;
                //transform.position = gameObject.transform.parent.position;
                //rigidbody.useGravity = false;

            }
            else if (transform.parent != null)
            {
                transform.parent = null;
                //rigidbody.useGravity = true;
                
            }
        }

        transform.position = gameObject.transform.parent.position;
        transform.rotation = gameObject.transform.parent.rotation;
    }
}
