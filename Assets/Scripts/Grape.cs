using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Grape : MonoBehaviour
{
    int points = 1;

    void Awake() 
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Deadzone") {
            GameManager.Instance.SpawnBomb();
            Destroy(this.gameObject);
        } else if(collision.gameObject.tag == "Grapezone") {
            GameManager.Instance.AddScore(points);
            Destroy(this.gameObject);
        } else if(collision.gameObject.tag == "Bombzone") {
            Destroy(this.gameObject);
        }
    }


}
