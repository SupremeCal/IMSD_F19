using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cube Moment is determined with a Tan Function For Y axies and a Cosin function for x axies 
         transform.position = new Vector3(3 * Mathf.Cos(Time.time), 5 * Mathf.Tan(Time.time*1), 0);
    }
}
