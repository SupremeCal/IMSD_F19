using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColorComponent : MonoBehaviour
{
    public Light lightColorChange;
    
    private float timer;
    private float startTimer;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

        startTimer += Time.deltaTime;

        if (startTimer >= 5)
        {
            timer += Time.deltaTime;
        }
        float r = Mathf.Sin(timer) / 2 + .5f;

        lightColorChange.color = new Color(r, 0, 0);

    }
}
