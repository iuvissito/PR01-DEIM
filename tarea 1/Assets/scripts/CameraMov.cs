using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoverCamara();
    }
   
     void MoverCamara()
    {
        transform.LookAt(player);

        print(playerObject.transform.position);

        float newx = playerObject.transform.position.x;
        float newy = playerObject.transform.position.y;
        float newz = transform.position.z;
        //transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y, transform.position.z);
        transform.position = new Vector3(newx, newy, newz);
    }
    // se me esta volviendo loco ,mirar e intentar solucionar porque

}
