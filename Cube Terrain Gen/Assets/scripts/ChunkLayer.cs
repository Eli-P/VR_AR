using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkLayer : MonoBehaviour
{
    public int Layer;
    public GameObject[] blocks;
    private int rand;
    private int Chance;
    public Vector3[] Blockpos;
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i <= 3; ++i)
        {
            rand = Random.Range(0, 3);
            if (i == 0)
            {
                Instantiate(blocks[rand], transform.position + new Vector3(1,0,0), transform.rotation);
            }
            else if(i == 1)
            {
                Instantiate(blocks[rand], transform.position + new Vector3(-1, 0, 0), transform.rotation);
            }
            else if (i == 2)
            {
                Instantiate(blocks[rand], transform.position + new Vector3(0, 0, 1), transform.rotation);
            }
            else if (i == 3)
            {
                Instantiate(blocks[rand], transform.position + new Vector3(0, 0, -1), transform.rotation);
            }
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
