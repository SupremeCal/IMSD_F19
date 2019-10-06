using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMOve2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(100 * Mathf.Sin(Time.time * 2) + 40, 0, -22);
    }
}
