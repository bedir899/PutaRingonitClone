using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{


    

    // Update is called once per frame
    void Update()
    {
        

        transform.Rotate(0, 0, 50 * Time.deltaTime, Space.Self);
    }
}
