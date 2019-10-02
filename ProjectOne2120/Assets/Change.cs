using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{

    public float Speed1 = 2.0f;
    public float Speed2 = 2.0f;

    private float First = 0.0f;
    private float Second = 0.0f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        First += Speed1 * Input.GetAxis("Mouse X");
        Second -= Speed2 * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(Second, First, 0.0f);

    }
}
