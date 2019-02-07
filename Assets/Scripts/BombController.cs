using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public float spawnXPos = 15;
    private float yPos;
    private bool canHit = true;
    void Start() {
        yPos = Random.Range(-1f, 4.5f);
        transform.position = new Vector2(spawnXPos, yPos);
    }

    void Update() {
        if (transform.position.x < -15f) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (!canHit) {
            return;
        }

        Player p = null;
        if ((p = other.GetComponent<Player>()) != null) {
            if (p.hasShield) {
                canHit = false;
                p.popShield();
            }
            else {
                GameController.instance.GhostDied();
            }
        }
    }
}
