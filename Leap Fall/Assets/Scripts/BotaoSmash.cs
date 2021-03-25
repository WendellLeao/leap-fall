using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoSmash : MonoBehaviour
{
    public float value = 0;
    void Start()
    {

    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Teste"))
        {
            GetComponent<teste>().number = value;
        }
    }
}
