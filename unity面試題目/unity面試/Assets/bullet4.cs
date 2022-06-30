using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet4 : MonoBehaviour
{
    public int speed;
    public SpriteRenderer sr;
    float a = 0;
    public GameObject player;
    float aim;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 position;
    // Start is called before the first frame update
    void Start()
    {

        Invoke("move", 0);

    }

    // Update is called once per frame
    void Update()
    {
        a=Vector3.Distance(player.transform.position, transform.position)/10*4;
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b,1- a);
    }
    public float GetAngle(Vector2 a, Vector2 b)
    {
        // 這邊需要過濾掉位置相同的問題
        if (a.x == b.x && a.y >= b.y) return 0;

        b -= a;
        float angle = Mathf.Acos(-b.y / b.magnitude) * (180 / Mathf.PI);

        return (b.x < 0 ? -angle : angle);
    }
    void move()
    {
        position.x = Random.Range(-4, 4);
        position.y = Random.Range(-4, 4);
        aim = GetAngle(position, transform.position);
        movement.x = Mathf.Cos(aim) * speed;
        movement.y = Mathf.Sin(aim) * speed;
        rb.velocity = movement;
    }

}
