using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleExpand : MonoBehaviour
{
    GameObject[] circles;
    public GameObject boxPrefab;
    // Start is called before the first frame update
    void Start()
    {
        circles = new GameObject[3];
        for (int i = 0; i < 3; i++)
        {
            circles[i]= Instantiate(boxPrefab, new Vector3(-2 + (2 * i), 0, 0), Quaternion.identity); 
        }
    }
    // Update is called once per frame
    void Update()
    {
        circles[0].GetComponent<SizeChangeScript>().MakeMyBool(Input.GetKey(KeyCode.Q));
        circles[1].GetComponent<SizeChangeScript>().MakeMyBool(Input.GetKey(KeyCode.W));
        circles[2].GetComponent<SizeChangeScript>().MakeMyBool(Input.GetKey(KeyCode.P));

        //ExpandTheSphere(circles[0], Input.GetKey(KeyCode.A));
    }
        //void ExpandTheSphere(Transform box ,float timer, float x, float y, float z, bool size)
        //{
        //    x = 1;
        //    y = 1;
        //    z = 1;
        //    timer += Time.deltaTime;
        
        //    if (size)
        //    {
        //        transform.localScale += new Vector3(x, y, z);
        //    }
        //    else
        //    {
        //        transform.localScale += new Vector3(x - timer, y - timer, z - timer);
        //    }
        //}
}
