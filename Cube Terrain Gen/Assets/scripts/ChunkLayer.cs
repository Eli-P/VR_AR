using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkLayer : MonoBehaviour
{
    public int Layer;
    public GameObject[] blocks;
    private int rand;
    private int Chance;
    public int[] x;
    public int[] y;
    private int j;
    private int i =-7;
    private float xf;
    // Start is called before the first frame update
    void Start()
    {


        //for(j = 0; j<= 225; ++j)
        //{
        //    ++i;
        //    if(i < 7)
        //    {
        //        i = -7;
        //    }
        //    y[j] = j-7;
        //
        //    x[i] = i;
        //}
        j = 0;
        
        i = 0;
        for(int i = 0; i <= 3; ++i) { 
            
                Instantiate(blocks[rand], transform.position + new Vector3(1,0,0), transform.rotation);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
