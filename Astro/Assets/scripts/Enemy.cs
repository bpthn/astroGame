using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;
   // public GameObject attackEffect;

    

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
            
        }
        else
        {
            Debug.Log("Cannot destroy");
        }


    }

    void Die()
    {
        Destroy(gameObject);
        

        /*GameObject e = Instantiate(deathEffect) as GameObject;
        e.transform.position = transform.position;

        
        Destroy(e, 0.4f);*/ //หา assets of enemy death


        Debug.Log("kill enemy");
        this.gameObject.SetActive(false);

        if (gameObject.tag.Equals("Enemy_lv1"))
        {
            Score.scoreValue += 10;
        }
        
        if (gameObject.tag.Equals("Enemy_lv2"))
        {
            Score.scoreValue += 20;
        }
        if (gameObject.tag.Equals("Enemy_lv3"))
        {
            Score.scoreValue += 30;
        }

        if (gameObject.tag.Equals("Enemy_lv4"))
        {
            Score.scoreValue += 40;
        }

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            Debug.Log("Enemy hit player");
            player_controller player = col.GetComponent<player_controller>();
            player.TakeEffect();

            if (gameObject.tag.Equals("Enemy_lv1"))
            {
                Score.scoreValue -= 10;
                Healthbar.health -= 10f;
            }

            if (gameObject.tag.Equals("Enemy_lv2"))
            {
                Score.scoreValue -= 20;
                Healthbar.health -= 20f;
            }
            if (gameObject.tag.Equals("Enemy_lv3"))
            {
                Score.scoreValue -= 30;
                Healthbar.health -= 30f;
            }
            if (gameObject.tag.Equals("Enemy_lv4"))
            {
                Score.scoreValue -= 40;
                Healthbar.health -= 40f;
            }

           
        }
        


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
