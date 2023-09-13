using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grape : MonoBehaviour
{
    int points = 1;
    private GameManager gameManager;

    void Awake() 
    {
        gameManager = GameManager.Instance;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Deadzone") {
            Destroy(this.gameObject);
        }
    }

    void OnDestroy()
    {
        gameManager.SpawnBomb();
    }


}
