using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public TMP_Text scoreText;

    public TMP_Text livesText;
    public static GameManager Instance { get; private set; }
    public int lives;

    public int score;
    public GameObject grape;

    public int startLives;

    public float bombTimer;

    public GameObject cherryBomb;

    public int spawnTime;

    private int spawnCounter = 0;

    void Start()
    {
        lives = startLives;
        score = 0;
    }

    void Awake() {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        spawnCounter++;
        spawnCounter = spawnCounter % spawnTime;
        if(spawnCounter == 0) {
            GameObject newGrape = Instantiate(grape);
            newGrape.transform.SetPositionAndRotation(new Vector3(Random.Range(-2.0f,2.0f), 20.0f, 0.0f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
        }
    }

    void Update()
    {
        scoreText.text = "Score " + score.ToString();
        livesText.text = "Lives " + lives.ToString();
        if(lives <= 0) {
            SceneManager.LoadScene("Game Over");
        }
    }

    public void SpawnBomb() {
        GameObject newBomb = Instantiate(cherryBomb);
        newBomb.transform.SetPositionAndRotation(new Vector3(Random.Range(-2.0f,2.0f), 20.0f, 0.0f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
    }

    public void AddScore(int points) {
        score += points;
    }


}
