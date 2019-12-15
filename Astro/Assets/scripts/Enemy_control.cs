using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy_control : MonoBehaviour
{
    List<Vector2> positionList = new List<Vector2>();
	List<GameObject> enemy = new List<GameObject>();

	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;

    

    // Start is called before the first frame update
    void Start()
    {
     randomEnemy();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void randomEnemy()
    {
        for(int i = 1; i < 12; i++)
        {
            positionList.Add(GameObject.Find("posenemy" + i).transform.position);
        }

        enemy.Add(enemy1);
        enemy.Add(enemy2);
        /*enemy.Add(enemy3);
        enemy.Add(enemy4);*/






        int enemyCount = 2;
        int max = 12;
        for (int i = 1; i < 12; i += 1)
        {
            int positionIndex = UnityEngine.Random.Range(0, max);
            int enemyIndex = UnityEngine.Random.Range(0, enemyCount);

            Debug.Log("index = " + positionIndex);
            if (positionList[positionIndex] != null)
            {
                if (enemy[enemyIndex] != null)
                {
                    Instantiate(enemy[enemyIndex], positionList[positionIndex], Quaternion.identity);
                    positionList.Remove(positionList[positionIndex]);
                    //i += 1;
                    //max -= 1;
                }
            }
        }

    }
}
