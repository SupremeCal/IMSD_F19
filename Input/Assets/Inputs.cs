using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == false)
        {
            
            Vector3 TheNextPos = transform.position;
            TheNextPos.y = Mathf.Sin(Time.time) * 3;
            transform.position = TheNextPos;

        }
        else
        {
            Debug.Log("I stopped moving already");
        }
    }
}
