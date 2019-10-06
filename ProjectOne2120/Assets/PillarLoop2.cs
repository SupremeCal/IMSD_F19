using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarLoop2 : MonoBehaviour
{
    public GameObject PillarBuilder2;
    // Start is called before the first frame update
    void Start()
    {
        BuildAWallAtZ(-13);
    }

    // Update is called once per frame
    void BuildAWallAtZ(float z)
    {
        for (int xPos = 0; xPos < 20; xPos++)
        {
            Instantiate(PillarBuilder2, new Vector3(xPos * 10 - 45, 0, z), Quaternion.identity);
        }
    }
}
