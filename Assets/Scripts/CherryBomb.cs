using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryBomb : MonoBehaviour
{
    float startTime;

    
    void Awake() 
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if((Time.time - startTime) > GameManager.Instance.bombTimer) {
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
        GameManager.Instance.lives -= 1;
        Destroy(this.gameObject);
    }
}
