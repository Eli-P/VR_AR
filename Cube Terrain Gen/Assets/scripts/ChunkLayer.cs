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
    private int xn;
    private int xcheck;
    // Start is called before the first frame update
    void Start()
    {

        for(i = 0; i < 225; ++i)
        {
            if (i / 15 == xcheck)
            {
                ++xcheck;
            }
            xn = xcheck;
            x[i] = xn-8;
            if (j>14)
            {
                j = 0;
            }
            ++j;
            y[i] = j-8;
        }
        j = 0;
        
        i = 0;
        for(i = 0; i <= 3; ++i) { 
            
                Instantiate(blocks[1], transform.position + new Vector3(y[i],0,x[i]), transform.rotation);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
