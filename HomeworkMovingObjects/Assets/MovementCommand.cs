using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCommand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Line 17 utilizes the function Tangent in order to make the sphere stop twoards the center
        transform.position = new Vector3(5 * Mathf.Tan(Time.time), 2, 4 * Mathf.Cos(Time.time));
    }
}
