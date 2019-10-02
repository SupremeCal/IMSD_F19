using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarLoop : MonoBehaviour
{
    public GameObject PillarBuilder;
    // Start is called before the first frame update
    void Start()
    {
        BuildAWallAtZ(1);
    }

    // Update is called once per frame
    void BuildAWallAtZ(float z)
    {
        for (int xPos = 0; xPos < 20; xPos++)
        {
             Instantiate(PillarBuilder, new Vector3(xPos * 10 - 40 ,0, z), Quaternion.identity);
        }
    }
}
