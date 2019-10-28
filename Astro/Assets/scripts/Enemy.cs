using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
     // Start is called before the first frame update
    public GameObject[] enemyPrefabs;
    int enemyIndex;
    float randPosX, randPosY;
    void Start()
    {
        InvokeRepeating("InstantiateEnemy", 0f, 1f);
    }

    void InstantiateEnemy()
    {
        enemyIndex = Random.Range(0,1);
        randPosX = Random.Range(-1f, 12f);
        // randPosY = Random.Range(-1f, 1f);
        Instantiate(enemyPrefabs[enemyIndex], new Vector3(randPosX, -1f, 1f),
                    enemyPrefabs[enemyIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
