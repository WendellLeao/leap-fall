using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashSpyNegative : MonoBehaviour
{
    public float move;

    public bool isColidde = false;
    void Start()

    {

    }

    void Update()
    {
        Rigidbody2D rigibody = GetComponent<Rigidbody2D>();

        rigibody.velocity = new Vector2(move, 0);

        if (isColidde)
        {
            Colidiu();
            isColidde = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SmashSpy"))
        {
            isColidde = true;
        }

        if (collision.gameObject.CompareTag("SmashSpy_lvl_11"))
        {
            isColidde = true;
        }

        if (collision.gameObject.CompareTag("Chao"))
        {
            isColidde = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SmashSpy"))
        {
            isColidde = false;
        }

        if (collision.gameObject.CompareTag("Chao"))
        {
            isColidde = false;
        }

        if (collision.gameObject.CompareTag("SmashSpy_lvl_11"))
        {
            isColidde = false;
        }
    }

    void Colidiu()
    {
        move *= -1;
    }
}
