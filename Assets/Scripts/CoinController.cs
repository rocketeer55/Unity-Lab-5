using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float spawnXPos = 15;
    private float yPos;
    void Start() {
        yPos = Random.Range(-2f, 5f);
        transform.position = new Vector2(spawnXPos, yPos);
    }

    void Update() {
        if (transform.position.x < -15f) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.GetComponent<Player>() != null) {
            GameController.instance.GhostScored();
            Destroy(gameObject);
        }
    }
}
