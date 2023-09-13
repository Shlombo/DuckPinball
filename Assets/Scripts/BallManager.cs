using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{

    public GameObject grape;

    public int spawnTime;

    private int spawnCounter = 0;


    // Update is called once per frame
    void FixedUpdate()
    {
        spawnCounter++;
        spawnCounter = spawnCounter % spawnTime;
        if(spawnCounter == 0) {
            GameObject newGrape = Instantiate(grape);
            newGrape.transform.SetPositionAndRotation(new Vector3(Random.Range(-2.0f,2.0f), 5.0f, 0.0f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
        }
    }

    void Update()
    {
        
        
    }


}
