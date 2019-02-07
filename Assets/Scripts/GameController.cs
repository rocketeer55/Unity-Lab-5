using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
    public static GameController instance;
    public GameObject bombPrefab;
    public GameObject shieldPrefab;
    public GameObject coinPrefab;
    public GameObject gameOverText;
    public Text scoreText;
    public bool gameOver = false;
    
    private int score = 0;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
        else if (instance != null) {
            Destroy(gameObject);
        }
    }

    void Update() {
        if (gameOver == true && Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void FixedUpdate() {
        if (!gameOver && Random.Range(1f, 1000f) < 10f) {
            Instantiate(bombPrefab);
        }
        if (!gameOver && Random.Range(1f, 1000f) < 3f) {
            Instantiate(shieldPrefab);
        }
        if (!gameOver && Random.Range(1f, 1000f) < 15f) {
            Instantiate(coinPrefab);
        }
    }

    public void GhostDied() {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    public void GhostScored() {
        if (gameOver) {
            return;
        }

        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}
