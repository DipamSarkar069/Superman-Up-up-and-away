using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_fly : MonoBehaviour
{
    public Game_Manager gameManager;
    public float jump = 1.5f;
    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = Vector2.up * jump;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
