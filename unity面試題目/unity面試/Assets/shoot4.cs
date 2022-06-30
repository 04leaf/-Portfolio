using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot4 : MonoBehaviour
{
    
    int t;
    public int hz;
    public GameObject bullet;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t = t + 1;
        if(t%hz==0)
        {
            offset.x = 7;
            offset.y = Random.Range(-3,3);
            
            Instantiate(bullet, offset, transform.rotation);
        }
        else if(t%hz==hz/4)
        {
            offset.x = Random.Range(-3, 3);
            offset.y = -7;
            Instantiate(bullet, offset, transform.rotation);
        }
        else if (t % hz ==hz/2)
        {
            offset.x = -7 ;
            offset.y = Random.Range(-3, 3);
            Instantiate(bullet, offset, transform.rotation);
        }
        else if (t % hz == hz/4*3)
        {
            offset.x = Random.Range(-3, 3);
            offset.y = 7;
            Instantiate(bullet, offset, transform.rotation);
        }
    }
    
}
