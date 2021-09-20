using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int number = 0;
    string saludo = "hi peter";
    string respuesta = "BIENVENIDO A LOS JUEGOS DEL HAMBRE";
    string respuesta1 = "¡¡¡SOY INEVITABLE !!!";
    string despedida = "HA LLEGADO EL FINAL INSENSATO";


    // Start is called before the first frame update
    void Start()
    {
        for ( int number = 0;  number < 500; number++)


        
        { print(saludo);
            

            if (number == 100)
            {
                print(respuesta);
                
            }

            else if (number == 200)
            {

                print(respuesta1);
            }



        else {
                
            }

        }
        print(despedida);
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
