using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int Ramdon;


    // Start is called before the first frame update
    void Start()
    {
        while (Ramdon != 10)
        {
            Ramdon = Random.Range(0, 20);

            print("El dado de la suerte ha sacado " + Ramdon);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
