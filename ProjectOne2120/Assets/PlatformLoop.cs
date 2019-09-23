using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLoop : MonoBehaviour
{
    public GameObject WallBuilder;

    void Update()
    {
        BuildAWallAtY(-1);
    }
    // Start is called before the first frame update
    void BuildAWallAtY(float y)
    {
        for (int xPos = 0; xPos < 40; xPos++)
        {
            for (int zPos = 0; zPos < 10; zPos++)
            {
                Instantiate(WallBuilder, new Vector3(xPos - 10, y, zPos), Quaternion.identity);
            }
        }
    }
}