using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string saludo = "HI HUMAN ,I AM PERFECT";
    string despedida = "ME HAS VENCIDO";
    int number = 1;

    // Start is called before the first frame update
    void Start()
    {

        
        



    }

    // Update is called once per frame
    void Update()
    {
        if (number <100)
        { print(saludo);
            number++;
        }
        
        else { 
            print(despedida);
        }
    }
}
