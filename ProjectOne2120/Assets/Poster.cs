using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    public Material[] Post;
    Renderer rend;
 

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = Post[0];

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            rend.sharedMaterial = Post[1];
        }
        else if (Input.GetKey(KeyCode.C))
        {
            rend.sharedMaterial = Post[2];
        }
        else if (Input.GetKey(KeyCode.V))
        {
            rend.sharedMaterial = Post[3];
        }
    }
}
