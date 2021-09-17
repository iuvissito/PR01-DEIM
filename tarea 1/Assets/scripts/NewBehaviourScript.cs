using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public int MiNum = 5;
    public float Deci = 10.5f;
    public string Saludito = "Hola simple humano";
    private string Pregunta = "¿que tal estas?";
    public string Orden = "SUMEMOS";
    private bool Alive = true;
    


    // Start is called before the first frame update
    void Start()
    {
        print(Saludito);
        print(MiNum);
        print(Orden);
        print(Deci + MiNum);
        
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
