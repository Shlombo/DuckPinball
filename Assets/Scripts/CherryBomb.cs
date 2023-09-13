using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryBomb : MonoBehaviour
{
    float startTime;

    
    GameManager gameManager;
    
    void Awake() 
    {
        startTime = Time.time;
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if((Time.time - startTime) > gameManager.bombTimer) {
            BlowUp();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Deadzone") {
            Destroy(this.gameObject);
        }
    }

    void BlowUp() {
        gameManager.lives -= 1;
        Destroy(this.gameObject);
    }
}
