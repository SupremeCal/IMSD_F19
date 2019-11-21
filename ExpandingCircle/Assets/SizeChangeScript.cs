using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChangeScript : MonoBehaviour
{
    private bool isGettingBigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGettingBigger)
        {
            transform.localScale = Vector3.one * (1.1f * transform.localScale.x);
        }
        else
        {
            transform.localScale = Vector3.Lerp (transform.localScale, Vector3.zero, .1f);
        }
    }
    public void MakeMyBool(bool nextValue)
    {
        isGettingBigger = nextValue; 
    } 
}
