using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isAlive = false;
        int playerHealth = -10;
        if (playerHealth > 10)
        {
            print("player is alive");
        }
        else
        {
            print("plaeyr not alive :(");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
