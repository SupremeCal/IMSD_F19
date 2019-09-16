using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallComponent : MonoBehaviour
{
    public GameObject WallBuilder;

    // Start is called before the first frame update
    void Start()
    {
        //All pices of the wall being called in order to make the cube 
        BuildAWallAtZ(3);
        BuildAWallAtX(11);
        BuildAWallAtX(-9);
        BuildAWallAtY(0);
        BuildAWallAtY(14);

    }

    // Update is called once per frame
    // Void made in ordre to make the wall in the background
    void BuildAWallAtZ(float z)
    {
        for (int xPos = 0; xPos < 20; xPos++)
        {
            for (int yPos = 0; yPos < 15; yPos++)
            {
                Instantiate(WallBuilder, new Vector3(xPos * 1 - 10, yPos * 1f, z), Quaternion.identity);
            }
        }
    }
    //Void made in order to make the walls for both side walls 
    void BuildAWallAtX(float x)
    {
        for (int zPos = 0; zPos < 10; zPos++)
        {
            for (int yPos = 0; yPos < 15; yPos++)
            {
                Instantiate(WallBuilder, new Vector3(x + -2, yPos, zPos), Quaternion.identity);
            }
        }
    }
    // walls made to make floor and ceilling
    void BuildAWallAtY(float y)
    {
        for (int xPos = 0; xPos < 20; xPos++)
        {
            for (int zPos = 0; zPos < 10; zPos++)
            {
                Instantiate(WallBuilder, new Vector3(xPos - 10, y, zPos), Quaternion.identity);
            }
        }
    }
}
