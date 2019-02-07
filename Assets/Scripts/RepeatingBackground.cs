using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private Renderer rend;
    private float horizontalLength;
    void Start()
    {
        rend = GetComponent<Renderer>();
        horizontalLength = rend.bounds.size.x;
    }

    // Update is called once per frame
    void Update() {
        if (transform.position.x < -horizontalLength) {
            RepositionBackground();
        }
    }

    private void RepositionBackground() {
        Vector2 groundOffset = new Vector2(horizontalLength * 2f, 0);
        transform.position = (Vector2) transform.position + groundOffset;
    }
}
