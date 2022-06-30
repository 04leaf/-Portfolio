using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet3 : MonoBehaviour
{
    
    Vector3 center;    
    int a;
    float startangle;
    int angleSpeed = 60;
    float radius = 4.5f;
    
    // Start is called before the first frame update
    void Start()
    {

        center.x = 15;
        center.y = 0;
        center.z = 0;
        if (gameObject.transform.position.x>0)
        {
            
            startangle = GetAngle(center, gameObject.transform.position);

            a = 0;
        }
        
        else
        {
            center.x = -15;
            center.y = 0;
            center.z = 0;
      
            startangle = GetAngle(center, gameObject.transform.position);
            a = 1;
        }

        Destroy(gameObject,20);
    }

    // Update is called once per frame
    
    void Update()
    {

        
        if (a==0)
        {
            
            center.x = center.x - Time.deltaTime * 2;
            float currentAngle = Time.time * angleSpeed + startangle;
            gameObject.transform.position = center + new Vector3(radius * Mathf.Cos(Mathf.Deg2Rad * currentAngle), radius * Mathf.Sin(Mathf.Deg2Rad * currentAngle));
            
        }
        
        else
        {
            center.x = center.x + Time.deltaTime * 2;
            float currentAngle = Time.time * -angleSpeed + startangle+30;
            gameObject.transform.position = center + new Vector3(radius * Mathf.Cos(Mathf.Deg2Rad * currentAngle), radius * Mathf.Sin(Mathf.Deg2Rad * currentAngle));
        }
        
        
        
    }
    
    public float GetAngle(Vector2 a, Vector2 b)
    {
        // 這邊需要過濾掉位置相同的問題
        if (a.x == b.x && a.y >= b.y) return 0;

        b -= a;
        float angle = Mathf.Acos(-b.y / b.magnitude) * (180 / Mathf.PI);

        return (b.x < 0 ? -angle : angle);
    }
    
}
