using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandom3 : MonoBehaviour
{
    List<GameObject> enemy = new List<GameObject>();
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    //public GameObject enemy4;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemy.Add(enemy1);
        enemy.Add(enemy2);
        enemy.Add(enemy3);
       // enemy.Add(enemy4);
        int index = Random.Range(1, 4);
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(5, 55);
           // Debug.Log(randX);
            whereToSpawn = new Vector2(randX, -3.5f);
            Instantiate(enemy[index], whereToSpawn, Quaternion.identity);
        }
    }
}
