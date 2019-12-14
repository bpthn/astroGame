using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_control : MonoBehaviour
{
    public List<Vector2> positionList = new List<Vector2>();

    public GameObject enemy1;
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
		positionList.Add(GameObject.Find("posenemy1").transform.position);
		positionList.Add(GameObject.Find("posenemy2").transform.position);
		positionList.Add(GameObject.Find("posenemy3").transform.position);
		positionList.Add(GameObject.Find("posenemy4").transform.position);

        int max = 4;
		for (int i = 1; i < 5; i += 0)
		{
			int positionIndex = UnityEngine.Random.Range(0, max);
			Debug.Log("index = " + positionIndex);
			if (positionList[positionIndex] != null)
			{
				Instantiate(enemy1, positionList[positionIndex], Quaternion.identity);
				positionList.Remove(positionList[positionIndex]);
				i += 1;
				max -= 1;
			}
		}

    }
}
