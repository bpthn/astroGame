using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagleRandom : MonoBehaviour
{
    public List<Vector2> positionList = new List<Vector2>();

    public GameObject eagle;
    // Start is called before the first frame update
    void Start()
    {
        randomEagle();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void randomEagle()
    {
        positionList.Add(GameObject.Find("poseagle1").transform.position);
        


        int max = 1;
        for (int i = 1; i < 2; i += 0)
        {
            int positionIndex = UnityEngine.Random.Range(0, max);

            Debug.Log("index = " + positionIndex);
            if (positionList[positionIndex] != null)
            {
                Instantiate(eagle, positionList[positionIndex], Quaternion.identity);
                positionList.Remove(positionList[positionIndex]);
                i += 1;
                max -= 1;
            }
        }

    }
}
