using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject player;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) { rb.AddForce(Vector2.right);
            rb.rotation += -0.75f;
        }

        if (Input.GetKey(KeyCode.A)) { rb.AddForce(Vector2.left);
            rb.rotation += 0.75f;
        }

        if (Input.GetKey(KeyCode.W)) { rb.AddForce(Vector2.up); }

        if (Input.GetKey(KeyCode.S)) { rb.AddForce(Vector2.down); }
        else { rb.rotation += 0.0f; }

    }
}
