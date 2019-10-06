using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightloop : MonoBehaviour
{
    public GameObject LightBuild;
    // Start is called before the first frame update
    void Start()
    {
        BuildALightAtZ(10);
    }

    // Update is called once per frame
    void BuildALightAtZ(float z)
    {
        for (int xPos = 0; xPos < 20; xPos++)
        {
            Instantiate(LightBuild, new Vector3(xPos * 10 - 40, 9, z), Quaternion.identity);
        }
    }
}
