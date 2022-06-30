using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 4f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    new public Collider2D collider;
    public int life = 3;
    public GameObject back;
    public GameObject wave;
    public GameObject lifetext;
    int hit = 0;

    void Start()
    {
        lifetext.GetComponent<Text>().text = ("Life:" +life);
    }
    // Update is called once per frame
    void Update()
    {
        if (animator.GetInteger("death") == 0)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed*Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("enemy")&&hit==0)
        {
            hit = 1;
            movement.x = 0;
            movement.y = 0;
            life = life - 1;
            lifetext.GetComponent<Text>().text = ("Life:" + life);
            animator.SetInteger("death", 1);
            Invoke("death", 1);
            

        }
    }
    
    void death()
    {
        if (life != 0)
        {
            animator.SetInteger("death", 2);
            Invoke("revive", 1);
        }
        else
        {
            wave.SetActive(false);
            back.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    void revive()
    {

            animator.SetInteger("death", 0);
            Invoke("moveagain", 2);

        
    }
    void moveagain()
    {
        hit=0;
    }    
}
