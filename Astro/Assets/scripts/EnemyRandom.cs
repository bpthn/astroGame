using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandom : MonoBehaviour
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
        int index = Random.Range(1, 3);
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(5, 55);
            Debug.Log(randX);
            whereToSpawn = new Vector2(randX, -3.5f);
            if (Enemy.count < 10)
            {
                Instantiate(enemy[index], whereToSpawn, Quaternion.identity);
                Debug.Log("Random enemy");
            }
        }
    }
}
