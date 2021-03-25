using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMenu : MonoBehaviour
{
    public float moveX;
    void Start()

    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveX, 0);
    }

    void Update()
    {

    }
}
