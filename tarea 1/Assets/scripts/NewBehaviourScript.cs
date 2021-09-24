using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int h = 0;
    int m = 0;
    int s = 0;
    int day = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("reloj");
    }
    IEnumerator reloj()
    {
        while (true)
        {
            print("la hora es " + h + "hour" + m + "min" + s + "seg");
            s++;
            yield return new WaitForSeconds(1f);

            if (s > 59)
            {
                s = 0;
                m++;
            }
            if (m > 59)
            {
                m = 0;
                h++;
            }
            if (h > 23)
            {

                print("BUENOS DIAS es el dia: " + day);
            }




        }


    }
    // Update is called once per frame



}
  



