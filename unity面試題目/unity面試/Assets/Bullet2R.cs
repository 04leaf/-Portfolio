using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2R : MonoBehaviour
{
    Vector2 movement;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.transform.position.x>0)
        {
            movement.x = Random.Range(-2, -7);
            movement.y = Random.Range(10, 16);
        }
        else
        {
            movement.x = Random.Range(2, 7);
            movement.y = Random.Range(10, 16);
        }
        rb.velocity =movement;
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
