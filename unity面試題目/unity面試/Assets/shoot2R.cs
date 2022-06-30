using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2R : MonoBehaviour
{
    int t = 0;
    public GameObject bullet;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = gameObject.transform.position;
        offset.x = offset.x * (-1);
    }

    // Update is called once per frame
    void Update()
    {
        t = t + 1;
        if(t%16==0)
        {
            Instantiate(bullet, gameObject.transform.position, transform.rotation);
        }
        else if((t+8)%16==0)
            {
                Instantiate(bullet, offset, transform.rotation);
            }
    }
}
