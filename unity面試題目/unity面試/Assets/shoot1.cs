using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot1 : MonoBehaviour
{
    int c = 0;
    public GameObject bullet;
    Vector2 offseta;
    Vector2 offsetb;
    int i;
    int j;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        c = c + 1;
        if (c % 100 == 0)
        {
            for (i=0; i<15;i++)
            {
                offseta = gameObject.transform.position;
                offseta.x=(float)(offseta.x+1.2*i);
                Instantiate(bullet, offseta, transform.rotation);
            }
        }
        if ((c% 110 == 0))
        {
            for(j=0;j<15;j++)
            {
                offsetb = gameObject.transform.position;
                offsetb.y = offsetb.y + 2;
                offsetb.x = (float)(offsetb.x + 0.6);
                offsetb.x = (float)(offsetb.x + 1.2 * j);
                Instantiate(bullet, offsetb, transform.rotation);
            }
            
        }
    }
}
