using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 0.5f); //ปรับเวลาที่ให้ posion ball อยู่ในscene

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        Debug.Log("hit enemy");
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            
        }
        GameObject e = Instantiate(impactEffect) as GameObject;
        e.transform.position = transform.position;


        Destroy(e, 0.4f);
        //Destroy(hitInfo.gameObject);
        Destroy(gameObject);
        
        this.gameObject.SetActive(false);

       





    }

   

    
}
