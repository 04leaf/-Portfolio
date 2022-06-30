using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 movement;
    public Rigidbody2D rb;
    public float a;
    public float b;
    void Start()
    {
        if (gameObject.transform.position.y < 7)
        {
            movement.y = a;
        }
        else
        {
            movement.y = b;
        }
        rb.velocity = movement;
        Destroy(gameObject, 12);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
