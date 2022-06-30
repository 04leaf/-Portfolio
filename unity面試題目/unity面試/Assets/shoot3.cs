using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot3 : MonoBehaviour
{
    Vector2 movement;
    public Rigidbody2D rb;
    
    public GameObject bullet;
    Vector2 offset;
    public float a;
    int i;
    int j;

    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.transform.position.x>0)
        {
            
            movement.x = -a;
            for (i = 1; i < 7; i++)
            {
                offset = gameObject.transform.position;
                offset.x = offset.x + Mathf.Cos((float)(i * Mathf.Deg2Rad * 60)) * 4.5f;
                offset.y = offset.y + Mathf.Sin((float)(i * Mathf.Deg2Rad * 60)) * 4.5f;
                Instantiate(bullet, offset, bullet.transform.rotation);
            }
            
        }    
        else
        {
            movement.x = a;
            for (j = 1; j < 7; j++)
            {
                offset = gameObject.transform.position;
                offset.x = offset.x + Mathf.Cos((float)(j * Mathf.Deg2Rad * 60)) * 4.5f;
                offset.y = offset.y + Mathf.Sin((float)(j * Mathf.Deg2Rad * 60)) * 4.5f;
                Instantiate(bullet, offset, bullet.transform.rotation);
            }
        }
        rb.velocity = movement;
        

        
            
            

        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
