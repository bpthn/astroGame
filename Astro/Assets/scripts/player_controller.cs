using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {
    public float speed;
    float x, sx;
    bool ks;
    Animator am;
    Rigidbody2D rb;
    public GameObject attackEffect;
    // Use this for initialization
    void Start () {
        am = GetComponent<Animator> ();
        rb = GetComponent<Rigidbody2D> ();
        sx = transform.localScale.x;
    }

    // Update is called once per frame
    void Update () {
        x = Input.GetAxis ("Horizontal");
        am.SetFloat ("speed", Abs (x));
        if (Input.GetKeyDown(KeyCode.W)) {
            am.SetBool ("jump", true);
            rb.velocity = new Vector2 (rb.velocity.x, 10f); //5f ตัวกำหนกว่าให้วิ่งเร็วหรือช้า  
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            am.SetBool ("shoot", true);
            rb.velocity = new Vector2 (rb.velocity.x, 1f);
                        
            
        }
        else {
            am.SetBool ("shoot", false);
            //am.SetBool("jump", false);
        }
        
        rb.velocity = new Vector2 (x * speed, rb.velocity.y);
        if (x > 0) {
            transform.localScale = new Vector2 (sx, transform.localScale.y);
            
        }
        if (x < 0)
        {
            transform.localScale = new Vector2(-sx, transform.localScale.y);
           
        }



    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        am.SetBool("jump", false);
        am.SetBool("shoot", false);

    }


    float Abs (float x) {
        return x >= 0f ? x : -x;
    }

    public void TakeEffect()
    {
        GameObject e = Instantiate(attackEffect) as GameObject;
        e.transform.position = transform.position;
        Debug.Log("Take Effect of player");
        Destroy(e, 0.5f);
    }






}