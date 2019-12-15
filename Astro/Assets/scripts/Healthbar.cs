using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    Image healthbar;
    float maxHealth = 100f;
    public static float health;
    //public GameObject gameOvertxt;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<Image>();
        health = maxHealth;
        //gameOvertxt.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (healthbar.fillAmount != 0f)
        {
            
            healthbar.fillAmount = health / maxHealth;
            Debug.Log(health);
        }
        else
        {
            //gameOvertxt.SetActive(true);
            SceneManager.LoadScene(sceneName);
        }

    }
}
