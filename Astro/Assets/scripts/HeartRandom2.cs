using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRandom2 : MonoBehaviour
{
    public List<Vector2> positionList = new List<Vector2>();

    public GameObject heart;
    // Start is called before the first frame update
    void Start()
    {
        randomHeart();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void randomHeart()
    {
        positionList.Add(GameObject.Find("posheart1").transform.position);
        positionList.Add(GameObject.Find("posheart2").transform.position);
        //positionList.Add(GameObject.Find("posheart3").transform.position);


        int max = 2;
        for (int i = 1; i < 3; i += 0)
        {
            int positionIndex = UnityEngine.Random.Range(0, max);
            
            Debug.Log("index = " + positionIndex);
            if (positionList[positionIndex] != null)
            {
                Instantiate(heart, positionList[positionIndex], Quaternion.identity);
                positionList.Remove(positionList[positionIndex]);
                i += 1;
                max -= 1;
            }
        }

    }
}
