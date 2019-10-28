using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void Retry(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void BackHome(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
