using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleExpand : MonoBehaviour
{
    Transform[] circles = new Transform[2];
    public GameObject boxPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            GameObject g = Instantiate(boxPrefab, new Vector3(-4 + 2 * i, 0, 0), Quaternion.identity);
            circles[i] = g.transform;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //ExpandTheSphere(circles[0], Input.GetKey(KeyCode.A));
    }
    void ExpandTheSphere(Transform box ,float timer, float x, float y, float z, bool size)
    {
        x = 1;
        y = 1;
        z = 1;
        timer += Time.deltaTime;
        
        if (size)
        {
            transform.localScale += new Vector3(x, y, z);
        }
        else
        {
            transform.localScale += new Vector3(x - timer, y - timer, z - timer);
        }
    }
}
