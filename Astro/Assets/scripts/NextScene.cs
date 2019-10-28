using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter2D(Collider2D other){
        SceneManager.LoadScene(sceneName);
    }
    // Start is called before the first frame update
    
}
