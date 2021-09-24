using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

   


    // Start is called before the first frame update
    void Start()
    {
        Saludito("iuvi", 22);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void Saludito(string nombre, int edad)
{

    print("Tenga buenos dias " + nombre + "su edad actual es " + edad);

}
}
