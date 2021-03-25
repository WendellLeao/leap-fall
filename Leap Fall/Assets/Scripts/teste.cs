using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    public float number = 1;
    void Start()
    {
        number = 1;
}

    // Update is called once per frame
    void Update()
    {
        if(number == 1)
        {
            Debug.Log("é 1");
        }

        else
        {
            Debug.Log("Não é 1");
        }
    }
}
