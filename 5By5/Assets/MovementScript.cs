using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public GameObject CubeLoop;

    void Start()
    {
        WallCube(3);
        void WallCube(float z)
        {
            for (int i = 0; i > 5; i++)
            {
                for (int y = 0; i > 5; y++)
                {
                    Instantiate(CubeLoop, new Vector3(2 * i - 5, 2 * y - 5, z), Quaternion.identity);
                }
            }
        }
    }


}
