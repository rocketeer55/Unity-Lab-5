using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    public float spawnXPos = 20f;
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
        Player p = null;
        if ((p = other.GetComponent<Player>()) != null) {
            p.getShield();
            Destroy(gameObject);
        }
    }
}
