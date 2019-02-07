using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float xPos = -4.5f;
    public float upForce = 10f;
    public float maxVelocity = 4f;
    public bool hasShield = false;
    public GameObject shield;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {
        transform.position = new Vector2(xPos, transform.position.y);
        if (Input.GetKey(KeyCode.Space)) {
            rb2d.AddForce(new Vector2(0, upForce * Time.deltaTime));
        }

        if (rb2d.velocity.y > maxVelocity) {
            rb2d.velocity = new Vector2(0, maxVelocity);
        }
        else if (rb2d.velocity.y < -maxVelocity) {
            rb2d.velocity = new Vector2(0, -maxVelocity);
        }
        transform.rotation = Quaternion.identity;
    }

    public void popShield() {
        if (hasShield) {
            shield.SetActive(false);
            hasShield = false;
        }
    }

    public void getShield() {
        if (!hasShield) {
            shield.SetActive(true);
            hasShield = true;
        }
    }
}
