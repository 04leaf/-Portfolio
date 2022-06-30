using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot3A : MonoBehaviour
{
    public GameObject shoot3;
    public int time;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
        offset.x = offset.x * -1;
        Instantiate(shoot3, transform.position, transform.rotation);
        Instantiate(shoot3, offset, transform.rotation);
        Invoke("wave2", time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void wave2()
    {
        Instantiate(shoot3, transform.position, transform.rotation);
        Instantiate(shoot3, offset, transform.rotation);
        Invoke("wave3", time);
    }
    void wave3()
    {
        Instantiate(shoot3, transform.position, transform.rotation);
        Instantiate(shoot3, offset, transform.rotation);
        Invoke("wave4", time);
    }
    void wave4()
    {
        Instantiate(shoot3, transform.position, transform.rotation);
        Instantiate(shoot3, offset, transform.rotation);
        Invoke("wave5", time);
    }
    void wave5()
    {
        Instantiate(shoot3, transform.position, transform.rotation);
        Instantiate(shoot3, offset, transform.rotation);
    }
}
