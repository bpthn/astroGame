using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOffScreen : MonoBehaviour
{
   public float topScreen = 20f;
    public float bottomScreen = -20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > topScreen)
            Destroy(gameObject);
        else if(transform.position.x < bottomScreen)
            Destroy(gameObject);
    }
}
