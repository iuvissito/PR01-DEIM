using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cuenta");
    }
    IEnumerator Cuenta()
    {
        for (int n = 20; n >= 0; n--)
        {
            print(" contador :" + n);
            yield return new WaitForSeconds(1f);


        }
    }
    // Update is called once per frame
    void Update()
    {



    }
}