using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject txt;
    // Start is called before the first frame update
    void Start()
    {
        txt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
            Debug.Log("show tutorial");
            txt.SetActive(true);
            Destroy(txt.gameObject, 5);
        
    }

    
}
