using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLoop : MonoBehaviour
{
    public GameObject WallBuilder;

    void Update()
    {
        BuildAWallAtZ(-4);
    }
    // Start is called before the first frame update
    void BuildAWallAtZ(float z)
    {
        {
            for (int xPos = 0; xPos < 20; xPos++)
            {
                Instantiate(WallBuilder, new Vector3(xPos * 10 - 40, -5, z), Quaternion.identity);
            }
        }
    }
}