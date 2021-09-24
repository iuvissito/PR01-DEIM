using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovent2 : MonoBehaviour
{
    Vector3 player1 = new Vector3(0f, 0f, 0f);
     public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(-1f, 0f, 0f);
        player1 = player1 + position * Time.deltaTime * speed;
        transform.position = player1;
    }
}

