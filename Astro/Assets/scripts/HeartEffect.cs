using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartEffect : MonoBehaviour
{
    public int heart;
    public GameObject Effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Healthbar.health += heart;
        GameObject e = Instantiate(Effect) as GameObject;
        e.transform.position = transform.position;
        Destroy(gameObject);
        Debug.Log("get Heart");
        Debug.Log(Healthbar.health);
    }
}
