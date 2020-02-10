using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBinding : MonoBehaviour
{
    public string parentFind = "Pommel";
    public string KeyBind = "P";

    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find(parentFind);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (transform.parent == null)
            {
                transform.parent = parent.transform;
                transform.position = gameObject.transform.parent.position;

                transform.rotation = gameObject.transform.parent.rotation;
            }
            else if (transform.parent != null)
            {
                transform.parent = null;
            }
        }
    }
}
